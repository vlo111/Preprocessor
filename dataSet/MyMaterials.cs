using System;
using System.Collections.Generic;

using System.Text;

namespace ModelComponents
{
    [Serializable]
    public class MyMaterials
    {
        public List<MyMaterial> ListOfMaterials;

        public MyMaterials()
        {
            ListOfMaterials = new List<MyMaterial>();

            ListOfMaterials.Add(new MyMaterial(ListOfMaterials.Count,"Алюминий", 7200000, 0.3, 38000, 0.1));
            ListOfMaterials.Add(new MyMaterial(ListOfMaterials.Count,"6061-T651 Al Plate", 9900000, 0.33, 35000, 0.5));
            ListOfMaterials.Add(new MyMaterial(ListOfMaterials.Count,"2024-T351 Al Plate", 10700000, 0.33, 42000, 0.4));
        }

    }
}
