namespace Zadanie_03_układ_równań_liniowych
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtA1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtC2 = new TextBox();
            txtB2 = new TextBox();
            txtA2 = new TextBox();
            txtC1 = new TextBox();
            txtB1 = new TextBox();
            groupBox2 = new GroupBox();
            lblWynik = new Label();
            btnOblicz = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtA1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtC2);
            groupBox1.Controls.Add(txtB2);
            groupBox1.Controls.Add(txtA2);
            groupBox1.Controls.Add(txtC1);
            groupBox1.Controls.Add(txtB1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Wartości: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 179);
            label6.Name = "label6";
            label6.Size = new Size(22, 15);
            label6.TabIndex = 11;
            label6.Text = "c2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 150);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 10;
            label5.Text = "b2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 121);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 9;
            label4.Text = "a2:";
            // 
            // txtA1
            // 
            txtA1.Location = new Point(46, 31);
            txtA1.Name = "txtA1";
            txtA1.Size = new Size(100, 23);
            txtA1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 92);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 8;
            label3.Text = "c1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 63);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 7;
            label2.Text = "b1:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 34);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 6;
            label1.Text = "a1:";
            // 
            // txtC2
            // 
            txtC2.Location = new Point(47, 176);
            txtC2.Name = "txtC2";
            txtC2.Size = new Size(100, 23);
            txtC2.TabIndex = 5;
            // 
            // txtB2
            // 
            txtB2.Location = new Point(46, 147);
            txtB2.Name = "txtB2";
            txtB2.Size = new Size(100, 23);
            txtB2.TabIndex = 4;
            // 
            // txtA2
            // 
            txtA2.Location = new Point(47, 118);
            txtA2.Name = "txtA2";
            txtA2.Size = new Size(100, 23);
            txtA2.TabIndex = 3;
            // 
            // txtC1
            // 
            txtC1.Location = new Point(47, 89);
            txtC1.Name = "txtC1";
            txtC1.Size = new Size(100, 23);
            txtC1.TabIndex = 2;
            // 
            // txtB1
            // 
            txtB1.Location = new Point(47, 60);
            txtB1.Name = "txtB1";
            txtB1.Size = new Size(100, 23);
            txtB1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblWynik);
            groupBox2.Location = new Point(283, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 128);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Wynik: ";
            // 
            // lblWynik
            // 
            lblWynik.AutoSize = true;
            lblWynik.Location = new Point(21, 58);
            lblWynik.Name = "lblWynik";
            lblWynik.Size = new Size(126, 15);
            lblWynik.TabIndex = 0;
            lblWynik.Text = "Tutaj pojawi się wynik.";
            // 
            // btnOblicz
            // 
            btnOblicz.Location = new Point(283, 154);
            btnOblicz.Name = "btnOblicz";
            btnOblicz.Size = new Size(75, 23);
            btnOblicz.TabIndex = 1;
            btnOblicz.Text = "Oblicz";
            btnOblicz.UseVisualStyleBackColor = true;
            btnOblicz.Click += btnOblicz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 234);
            Controls.Add(btnOblicz);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Układ równań liniowych - Aleksander Grochowski 3TP";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtC2;
        private TextBox txtB2;
        private TextBox txtA2;
        private TextBox txtC1;
        private TextBox txtB1;
        private TextBox txtA1;
        private GroupBox groupBox2;
        private Label lblWynik;
        private Button btnOblicz;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
