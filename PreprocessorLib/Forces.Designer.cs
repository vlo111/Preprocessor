namespace PreprocessorLib
{
    partial class Forces
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.function = new System.Windows.Forms.TextBox();
            this.sortByX = new System.Windows.Forms.RadioButton();
            this.sortByY = new System.Windows.Forms.RadioButton();
            this.ascSort = new System.Windows.Forms.RadioButton();
            this.descSort = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxExcludeNodes = new System.Windows.Forms.CheckBox();
            this.txtExcludedNodes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(92, 239);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Закрыть";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(8, 210);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(113, 23);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "Добавить нагрузку";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Номера линий:";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(87, 12);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(168, 20);
            this.number.TabIndex = 14;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Функция F(X) = ";
            // 
            // function
            // 
            this.function.Location = new System.Drawing.Point(125, 74);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(129, 20);
            this.function.TabIndex = 16;
            // 
            // sortByX
            // 
            this.sortByX.AutoSize = true;
            this.sortByX.Checked = true;
            this.sortByX.Location = new System.Drawing.Point(3, 4);
            this.sortByX.Name = "sortByX";
            this.sortByX.Size = new System.Drawing.Size(47, 17);
            this.sortByX.TabIndex = 85;
            this.sortByX.TabStop = true;
            this.sortByX.Text = "по X";
            this.sortByX.UseVisualStyleBackColor = true;
            // 
            // sortByY
            // 
            this.sortByY.AutoSize = true;
            this.sortByY.Location = new System.Drawing.Point(74, 4);
            this.sortByY.Name = "sortByY";
            this.sortByY.Size = new System.Drawing.Size(47, 17);
            this.sortByY.TabIndex = 86;
            this.sortByY.Text = "по Y";
            this.sortByY.UseVisualStyleBackColor = true;
            // 
            // ascSort
            // 
            this.ascSort.AutoSize = true;
            this.ascSort.Checked = true;
            this.ascSort.Location = new System.Drawing.Point(3, 3);
            this.ascSort.Name = "ascSort";
            this.ascSort.Size = new System.Drawing.Size(31, 17);
            this.ascSort.TabIndex = 87;
            this.ascSort.TabStop = true;
            this.ascSort.Text = ">";
            this.ascSort.UseVisualStyleBackColor = true;
            // 
            // descSort
            // 
            this.descSort.AutoSize = true;
            this.descSort.Location = new System.Drawing.Point(74, 3);
            this.descSort.Name = "descSort";
            this.descSort.Size = new System.Drawing.Size(31, 17);
            this.descSort.TabIndex = 88;
            this.descSort.Text = "<";
            this.descSort.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sortByY);
            this.panel1.Controls.Add(this.sortByX);
            this.panel1.Location = new System.Drawing.Point(125, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 24);
            this.panel1.TabIndex = 89;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ascSort);
            this.panel2.Controls.Add(this.descSort);
            this.panel2.Location = new System.Drawing.Point(125, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 24);
            this.panel2.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Сортировка:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Тип сортировки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Направление нагрузки:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 104;
            this.button1.Text = "Удалить нагрузки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxExcludeNodes
            // 
            this.cbxExcludeNodes.AutoSize = true;
            this.cbxExcludeNodes.Location = new System.Drawing.Point(11, 123);
            this.cbxExcludeNodes.Name = "cbxExcludeNodes";
            this.cbxExcludeNodes.Size = new System.Drawing.Size(113, 17);
            this.cbxExcludeNodes.TabIndex = 105;
            this.cbxExcludeNodes.Text = "Исключить узлы:";
            this.cbxExcludeNodes.UseVisualStyleBackColor = true;
            this.cbxExcludeNodes.CheckedChanged += new System.EventHandler(this.cbxExcludeNodes_CheckedChanged);
            // 
            // txtExcludedNodes
            // 
            this.txtExcludedNodes.Enabled = false;
            this.txtExcludedNodes.Location = new System.Drawing.Point(125, 121);
            this.txtExcludedNodes.Name = "txtExcludedNodes";
            this.txtExcludedNodes.Size = new System.Drawing.Size(129, 20);
            this.txtExcludedNodes.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(125, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "25*cos(0.05*x-1.7)^3.3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(128, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 24);
            this.panel3.TabIndex = 110;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(64, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(28, 17);
            this.radioButton2.TabIndex = 110;
            this.radioButton2.Text = "-";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 109;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "+";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 111;
            this.label5.Text = "Пример:";
            // 
            // Forces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(265, 270);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExcludedNodes);
            this.Controls.Add(this.cbxExcludeNodes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.function);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Forces";
            this.ShowInTaskbar = false;
            this.Text = "Нагрузки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Forces_FormClosed);
            this.Load += new System.EventHandler(this.Forces_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox function;
        public System.Windows.Forms.TextBox number;
        private System.Windows.Forms.RadioButton sortByX;
        private System.Windows.Forms.RadioButton sortByY;
        private System.Windows.Forms.RadioButton ascSort;
        private System.Windows.Forms.RadioButton descSort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbxExcludeNodes;
        private System.Windows.Forms.TextBox txtExcludedNodes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
    }
}