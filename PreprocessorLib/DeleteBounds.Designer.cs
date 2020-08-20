﻿namespace PreprocessorLib
{
    partial class DeleteBounds
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.rbnOnLine = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbnOnNode = new System.Windows.Forms.RadioButton();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.txtNode = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNoNode = new System.Windows.Forms.Label();
            this.errorNoLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(6, 142);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(156, 23);
            this.btnRemoveAll.TabIndex = 76;
            this.btnRemoveAll.Text = "Удалить все закрепления";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // rbnOnLine
            // 
            this.rbnOnLine.AutoSize = true;
            this.rbnOnLine.Checked = true;
            this.rbnOnLine.Location = new System.Drawing.Point(6, 28);
            this.rbnOnLine.Name = "rbnOnLine";
            this.rbnOnLine.Size = new System.Drawing.Size(113, 17);
            this.rbnOnLine.TabIndex = 77;
            this.rbnOnLine.TabStop = true;
            this.rbnOnLine.Text = "по номеру линии:";
            this.rbnOnLine.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Удалить закрепления:";
            // 
            // rbnOnNode
            // 
            this.rbnOnNode.AutoSize = true;
            this.rbnOnNode.Location = new System.Drawing.Point(6, 51);
            this.rbnOnNode.Name = "rbnOnNode";
            this.rbnOnNode.Size = new System.Drawing.Size(106, 17);
            this.rbnOnNode.TabIndex = 79;
            this.rbnOnNode.Text = "по номеру узла:";
            this.rbnOnNode.UseVisualStyleBackColor = true;
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(125, 27);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(72, 20);
            this.txtLine.TabIndex = 80;
            this.txtLine.Enter += new System.EventHandler(this.txtLine_Enter);
            // 
            // txtNode
            // 
            this.txtNode.Location = new System.Drawing.Point(125, 50);
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(72, 20);
            this.txtNode.TabIndex = 81;
            this.txtNode.Enter += new System.EventHandler(this.txtNode_Enter);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(6, 113);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 82;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(87, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 83;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNoNode
            // 
            this.lblNoNode.AutoSize = true;
            this.lblNoNode.ForeColor = System.Drawing.Color.Red;
            this.lblNoNode.Location = new System.Drawing.Point(3, 82);
            this.lblNoNode.Name = "lblNoNode";
            this.lblNoNode.Size = new System.Drawing.Size(92, 13);
            this.lblNoNode.TabIndex = 89;
            this.lblNoNode.Text = "Нет такого узла!";
            this.lblNoNode.Visible = false;
            // 
            // errorNoLine
            // 
            this.errorNoLine.AutoSize = true;
            this.errorNoLine.ForeColor = System.Drawing.Color.Red;
            this.errorNoLine.Location = new System.Drawing.Point(3, 95);
            this.errorNoLine.Name = "errorNoLine";
            this.errorNoLine.Size = new System.Drawing.Size(94, 13);
            this.errorNoLine.TabIndex = 88;
            this.errorNoLine.Text = "Нет такой линии!";
            this.errorNoLine.Visible = false;
            // 
            // DeleteBounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNoNode);
            this.Controls.Add(this.errorNoLine);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNode);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.rbnOnNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbnOnLine);
            this.Controls.Add(this.btnRemoveAll);
            this.Location = new System.Drawing.Point(20, 390);
            this.Name = "DeleteBounds";
            this.Size = new System.Drawing.Size(280, 220);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.RadioButton rbnOnLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbnOnNode;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.TextBox txtNode;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNoNode;
        private System.Windows.Forms.Label errorNoLine;
    }
}
