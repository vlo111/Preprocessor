using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ELW.Library.Math;
using ELW.Library.Math.Exceptions;
using ELW.Library.Math.Expressions;
using ELW.Library.Math.Tools;
using System.Diagnostics;
using ModelComponents;

namespace PreprocessorLib
{
    public partial class ProjectForm : Form
    {

        public void CreateMaterialsFile(string FileName)
        {
            int currentModel = this.GetCurrentModelIndex();

            // создадим файл materiasl.elems            
            StringBuilder stringBuilder = new StringBuilder();
            //StreamWriter streamWriter = new StreamWriter(Path.GetDirectoryName(this.FullProjectFileName) + "\\materials.elems");
            StreamWriter streamWriter = new StreamWriter(Path.GetDirectoryName(FileName) + "\\materials.elems");

            //stringBuilder.AppendLine(this.currentFullModel.FiniteElementModels[currentModel].NE.ToString()); // пишем число КЭ
            foreach (MyFiniteElement FE in this.currentFullModel.FiniteElementModels[currentModel].FiniteElements)
            {
                stringBuilder.AppendLine(FE.MaterialPropertyID.ToString()); // пишем номер свойства
            }

            streamWriter.Write(stringBuilder.ToString());
            streamWriter.Dispose();
        }


        public void CreateSFMFile(string FileName)
        {
            int index = this.GetCurrentModelIndex();
            int i;

            // создадим бинарный файл *.sfm
            FileStream F1 = null;
            try
            {
                //F1 = new FileStream(Path.ChangeExtension(this.FullProjectFileName, "sfm"), FileMode.Create, FileAccess.ReadWrite);
                F1 = new FileStream(FileName, FileMode.Create, FileAccess.ReadWrite);
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            BinaryWriter writer1 = new BinaryWriter(F1);

            byte[] array1 = { 0x53, 0x69, 0x67, 0x6d, 0x61, 0x20, 0x46, 0x6f, 0x72, 0x6d };
            writer1.Write(array1);   // префикс - 10 байт

            byte[] array2 = { 0x03, 0x00, 0x00, 0x00 };
            writer1.Write(array2);   // версия - 4 байта

            Int16 bytes = 8;
            writer1.Write(bytes);    // Хранит количество байт отведенных под хранение числа с плавающей точкой - 2 байт

            writer1.Write((byte)0x00);    // тип задачи - 1 байт            

            byte var = Convert.ToByte(variant.Text);
            writer1.Write(var);   // варинат - 1 байт           

            Int16 NRC = 3;
            if (this.currentFullModel.FiniteElementModels.Count != 0)
            {
                NRC = (Int16)this.currentFullModel.FiniteElementModels[index].NRC;
            }
            writer1.Write(NRC);   // NRC - 2 байта

            // пишем магические 4 байта
            Int32 magic = 0;
            writer1.Write(magic);

            double DB = currentFullModel.geometryModel.Points.Max(pt => pt.X) - currentFullModel.geometryModel.Points.Min(pt => pt.X);
            double DH = currentFullModel.geometryModel.Points.Max(pt => pt.Y) - currentFullModel.geometryModel.Points.Min(pt => pt.Y);
            writer1.Write(DB);  // ширина - 8 байт
            writer1.Write(DH);  // выстока - 8 байт 

            double r = 0.0;
            if (this.currentFullModel.geometryModel.Circles.Count != 0) r = this.currentFullModel.geometryModel.Circles[0].Radius;
            writer1.Write(r);   // радиус отверстия - 8 байт            

            double thickness = 0.1;
            if (this.currentFullModel.FiniteElementModels.Count != 0)
            {
                if (this.currentFullModel.FiniteElementModels[index].Materials.Count != 0)
                {
                    thickness = this.currentFullModel.FiniteElementModels[index].Materials[0].Thickness;
                }
            }
            writer1.Write(thickness); // толщина - 8 байт

            double RsumX = 0.0;
            double RsumY = 0.0;
            //if (this.currentFullModel.FiniteElementModels.Count != 0)
            //{
            //    foreach (MyNode node in this.currentFullModel.FiniteElementModels[index].Nodes)
            //    {
            //        RsumX += node.ForceX;
            //        RsumY += node.ForceY;
            //    }
            //}
            writer1.Write(RsumX); // Суммарная нагрузка по X - 8 байт
            writer1.Write(RsumY); // Суммарная нагрузка по Y - 8 байт


            Int32 NLD = 0;
            if (this.currentFullModel.FiniteElementModels.Count != 0) NLD = this.currentFullModel.FiniteElementModels[index].NLD;
            writer1.Write(NLD); // число случаев нагружения - 4 байта

            Int32 NDF = 2;
            if (this.currentFullModel.FiniteElementModels.Count != 0) NDF = this.currentFullModel.FiniteElementModels[index].NDF;
            writer1.Write(NDF); // число степеней свободы - 4 байта

            Int32 NCN = 3;
            if (this.currentFullModel.FiniteElementModels.Count != 0) NCN = this.currentFullModel.FiniteElementModels[index].NCN;
            writer1.Write(NCN); // число узлов в элементе - 4 байта

            Int32 NMAT = 1;
            if (this.currentFullModel.FiniteElementModels.Count != 0) NMAT = this.currentFullModel.FiniteElementModels[index].NMAT;
            writer1.Write(NMAT); // число материалов - 4 байта

            double E = 720000;
            double p = 0.3;
            double T = 38000;
            double L = 0.8;
            if (this.currentFullModel.FiniteElementModels.Count > 0)
            {
                if (this.currentFullModel.FiniteElementModels[index].Materials.Count != 0)
                {
                    E = this.currentFullModel.FiniteElementModels[index].Materials[0].ElasticModulus; // берем первое свойство. вообще, формат файла устарел, потому что может быть три различных материала, а они собраны вместе только в конце..
                    p = this.currentFullModel.FiniteElementModels[index].Materials[0].PoissonsRatio;
                    T = this.currentFullModel.FiniteElementModels[index].Materials[0].Tension;
                }
            }
            writer1.Write(E);
            writer1.Write(p);
            writer1.Write(T);
            writer1.Write(L);
            
            Int32 numOfAreas = this.currentFullModel.geometryModel.Areas.Count;
            writer1.Write(numOfAreas); // число зон - 4 байта


            List<MyPoint> points = new List<MyPoint>(); // узлы зоны назовем points
            foreach (MyArea area in this.currentFullModel.geometryModel.Areas)
            {
                for (i = 0; i < 8; i++)
                {
                    if (points.IndexOf(area.Nodes[i]) == -1) points.Add(area.Nodes[i]);
                }
            }

            Int32 numOfPoints = points.Count;
            writer1.Write(numOfPoints); // число узлов зон - 4 байта

            foreach (MyPoint point in points)
            {
                writer1.Write((Int16)point.Id); // номер узла зоны
                byte[] magic6 = new byte[6];
                writer1.Write(magic6); // 6 магичесеких байт
                writer1.Write(point.X);         // X
                writer1.Write(point.Y);         // Y
            }



            foreach (MyArea area in this.currentFullModel.geometryModel.Areas)
            {
                foreach (MyPoint point in area.Nodes)
                {
                    writer1.Write((Int16)point.Id); // номер узла зоны
                }
            }

            // пишем параметры PRM1, PRM2 и PRM3.. в последней сигме их 6, но читает из sfm она только 3((

            for (int k = 0; k < 3; k++)
            {
                double prm = 0.0;
                writer1.Write(prm);
            }

            double ort4 = 0.0;
            writer1.Write(ort4);

            double ort8 = 0.0;
            double ort9 = 0.0;
            double ort10 = 0.0;
            double ort14 = 0.0;
            if (this.currentFullModel.FiniteElementModels.Count > 0)
                if (this.currentFullModel.FiniteElementModels[index].Materials.Count >= 2)
                {
                    ort8 = this.currentFullModel.FiniteElementModels[index].Materials[1].ElasticModulus;
                    ort9 = this.currentFullModel.FiniteElementModels[index].Materials[1].PoissonsRatio;
                    ort10 = this.currentFullModel.FiniteElementModels[index].Materials[1].Tension;
                    ort14 = this.currentFullModel.FiniteElementModels[index].Materials[1].Thickness;
                }
            writer1.Write(ort8);
            writer1.Write(ort9);
            writer1.Write(ort10);

            double ort11 = 0.0;
            writer1.Write(ort11);

            writer1.Write(ort14);



            double ort15 = 0.0;
            double ort16 = 0.0;
            double ort17 = 0.0;
            double ort21 = 0.0;
            if (this.currentFullModel.FiniteElementModels.Count > 0) 
                if (this.currentFullModel.FiniteElementModels[index].Materials.Count == 3)
                {
                    ort15 = this.currentFullModel.FiniteElementModels[index].Materials[2].ElasticModulus;
                    ort16 = this.currentFullModel.FiniteElementModels[index].Materials[2].PoissonsRatio;
                    ort17 = this.currentFullModel.FiniteElementModels[index].Materials[2].Tension;
                    ort21 = this.currentFullModel.FiniteElementModels[index].Materials[2].Thickness;
                }
            writer1.Write(ort15);
            writer1.Write(ort16);
            writer1.Write(ort17);

            double ort18 = 0.0;
            writer1.Write(ort18);

            writer1.Write(ort21);

            F1.Dispose();
        }

        public void CreateFEAndNodesFiles(string FileName)
        {
            int currentModel = this.GetCurrentModelIndex();

            // создадим файлы prep_griddm.nodes и prep_griddm.elems
            // griddm.nodes
            StringBuilder stringBuilder = new StringBuilder();
            //StreamWriter streamWriter = new StreamWriter(Path.GetDirectoryName(this.FullProjectFileName) + "\\prep_griddm.nodes");
            StreamWriter streamWriter = new StreamWriter(Path.GetDirectoryName(FileName) + "\\prep_griddm.nodes");
            MyFiniteElementModel model = this.currentFullModel.FiniteElementModels[currentModel];
            /*
            stringBuilder.AppendLine(this.currentFullModel.FiniteElementModels[currentModel].NP.ToString()); // пишем число узлов
            for (int i = 1; i <= 2 * this.currentFullModel.FiniteElementModels[currentModel].NP; i++)
            {
                stringBuilder.AppendLine(this.currentFullModel.FiniteElementModels[currentModel].CORD[i].ToString().Replace(",", "."));    // координаты узлов
            }*/
            stringBuilder.AppendLine(model.Nodes.Count.ToString());
            model.Nodes.Sort((n,m) => n.Id.CompareTo(m.Id));
            foreach (MyNode node in model.Nodes)
            {
                stringBuilder.AppendLine(Math.Round(node.X, 10).ToString().Replace(',', '.'));
                stringBuilder.AppendLine(Math.Round(node.Y, 10).ToString().Replace(',', '.'));
            }

            streamWriter.Write(stringBuilder.ToString());
            streamWriter.Flush();
            streamWriter.Close();
            streamWriter.Dispose();

            // griddm.elems
            stringBuilder = new StringBuilder();
            streamWriter = new StreamWriter(Path.GetDirectoryName(FileName) + "\\prep_griddm.elems");

            stringBuilder.AppendLine(model.FiniteElements.Count.ToString());
            foreach (MyFiniteElement elem in model.FiniteElements)
            {
                List<MyNode> nodes = new List<MyNode>(elem.Nodes);
                // сортировка узлов КЭ против часовой стрелке //
                double[] angle = new double[3];
                for (int i = 1; i < 3; i++) {
                    angle[i]=Math.Atan2(nodes[i].Y-nodes[0].Y,nodes[i].X-nodes[0].X);
                    if (angle[i] < 0) angle[i] += Math.PI*2;
                }
               stringBuilder.AppendLine(nodes[0].Id.ToString());      
                if (angle[1] > angle[2]) {
                    if (angle[1] - angle[2] < Math.PI)
                    {
                        stringBuilder.AppendLine(nodes[2].Id.ToString());
                        stringBuilder.AppendLine(nodes[1].Id.ToString());
                    }
                    else
                    {
                        stringBuilder.AppendLine(nodes[1].Id.ToString());
                        stringBuilder.AppendLine(nodes[2].Id.ToString());
                    }
                }
                else {
                    if (angle[2] - angle[1] < Math.PI)
                    {
                        stringBuilder.AppendLine(nodes[1].Id.ToString());
                        stringBuilder.AppendLine(nodes[2].Id.ToString());
                    }
                    else
                    {
                        stringBuilder.AppendLine(nodes[2].Id.ToString());
                        stringBuilder.AppendLine(nodes[1].Id.ToString());
                    }
                }
            }            
            streamWriter.Write(stringBuilder.ToString());
            streamWriter.Flush();
            streamWriter.Close();
            streamWriter.Dispose();
        }

        public void CreateBoundsFile(string FileName)
        {
            int currentModel = this.GetCurrentModelIndex();

            // создадим файл bounds.nodes            
            StringBuilder stringBuilder = new StringBuilder();
            //StreamWriter streamWriter = new StreamWriter(Path.GetDirectoryName(this.FullProjectFileName) + "\\bounds.nodes");
            StreamWriter streamWriter = new StreamWriter(Path.GetDirectoryName(FileName) + "\\bounds.nodes");
            List<MyNode> boundedNodes = currentFullModel.FiniteElementModels[currentModel].Nodes.FindAll(n => n.BoundType != 0);
            /*
            stringBuilder.AppendLine(this.currentFullModel.FiniteElementModels[currentModel].NB.ToString()); // пишем число закреплений
            for (int i = 1; i <= this.currentFullModel.FiniteElementModels[currentModel].NB; i++)
            {
                stringBuilder.AppendLine(this.currentFullModel.FiniteElementModels[currentModel].NBC[i].ToString() + " " + this.currentFullModel.FiniteElementModels[currentModel].NFIX[i].ToString());    // номер_узла_пробел_тип_закрепления
            }*/
            stringBuilder.AppendLine(boundedNodes.Count.ToString());
            foreach (MyNode node in boundedNodes)
                stringBuilder.AppendLine(node.Id.ToString() + " " + node.BoundType.ToString());

            streamWriter.Write(stringBuilder.ToString());
            streamWriter.Dispose();
        }

        public void CreateForceFile(string FileName)
        {
            int currentModel = this.GetCurrentModelIndex();

            // создадим файл forces.nodes            
            StringBuilder stringBuilder = new StringBuilder();
            //StreamWriter streamWriter = new StreamWriter(Path.GetDirectoryName(this.FullProjectFileName) + "\\forces.nodes");
            StreamWriter streamWriter = new StreamWriter(Path.GetDirectoryName(FileName) + "\\forces.nodes");

            int forcedNodes = 0;
            foreach (MyNode node in this.currentFullModel.FiniteElementModels[currentModel].Nodes)
            {
                // подчищаем ошибки округления..
                if (node.BoundType == 10) node.ForceX = 0;
                if (node.BoundType == 01) node.ForceY = 0;
                if (node.BoundType == 11) node.ForceY = node.ForceX = 0;
                if (node.ForceX != 0 || node.ForceY != 0) forcedNodes++;                
            }

            stringBuilder.AppendLine(forcedNodes.ToString()); // пишем число нагруженных узлов
            foreach (MyNode node in currentFullModel.FiniteElementModels[currentModel].Nodes)
                stringBuilder.AppendLine(node.ForceX.ToString().Replace(",", ".") + " " + node.ForceY.ToString().Replace(",", "."));    // нагрузка по x _пробел_ нагрузка по y

            streamWriter.Write(stringBuilder.ToString());
            streamWriter.Dispose();
        }
    }
}