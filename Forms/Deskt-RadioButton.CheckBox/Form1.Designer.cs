namespace Deskt_RadioButton.CheckBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox3 = new GroupBox();
            checkBox4 = new System.Windows.Forms.CheckBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(211, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 72);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Wielkość liter w imieniu:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(23, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(51, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Tag = "imD";
            radioButton2.Text = "Duże";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(23, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Tag = "imM";
            radioButton1.Text = "Małe";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(211, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(188, 97);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Wielkość liter w nazwisku:";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(23, 72);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(121, 19);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Tag = "naN";
            radioButton5.Text = "Wielkość dowolna";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(23, 47);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(51, 19);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Tag = "naD";
            radioButton4.Text = "Duże";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(23, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(51, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Tag = "naM";
            radioButton3.Text = "Małe";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox4);
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Location = new Point(12, 234);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(387, 72);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dodatkowe opcje:";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(199, 47);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(186, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Nazwisko: Blokuj wielkość liter";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(199, 22);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(159, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Imię: Blokuj wielkość liter";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(41, 47);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(152, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Nazwisko: Blokuj edycję";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(41, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Imię: Blokuj edycję";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 318);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Elementy wyboru: CheckBox, RadioButton:. AL";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
