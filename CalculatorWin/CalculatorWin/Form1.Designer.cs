namespace CalculatorWin
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.bad = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("LCD", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 57);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n1.Location = new System.Drawing.Point(12, 104);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(64, 59);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseMnemonic = false;
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n3.Location = new System.Drawing.Point(245, 104);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(64, 59);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseMnemonic = false;
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n6.Location = new System.Drawing.Point(245, 198);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(64, 59);
            this.n6.TabIndex = 6;
            this.n6.Text = "6";
            this.n6.UseMnemonic = false;
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n5.Location = new System.Drawing.Point(126, 198);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(64, 59);
            this.n5.TabIndex = 5;
            this.n5.Text = "5";
            this.n5.UseMnemonic = false;
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n4.Location = new System.Drawing.Point(12, 198);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(64, 59);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseMnemonic = false;
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n7
            // 
            this.n7.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n7.Location = new System.Drawing.Point(12, 292);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(64, 59);
            this.n7.TabIndex = 7;
            this.n7.Text = "7";
            this.n7.UseMnemonic = false;
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n8.Location = new System.Drawing.Point(126, 292);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(64, 59);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseMnemonic = false;
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n9.Location = new System.Drawing.Point(245, 292);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(64, 59);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseMnemonic = false;
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n0
            // 
            this.n0.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n0.Location = new System.Drawing.Point(126, 379);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(64, 59);
            this.n0.TabIndex = 0;
            this.n0.Text = "0";
            this.n0.UseMnemonic = false;
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n2.Location = new System.Drawing.Point(126, 104);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(64, 59);
            this.n2.TabIndex = 11;
            this.n2.Text = "2";
            this.n2.UseMnemonic = false;
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // bad
            // 
            this.bad.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bad.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bad.Location = new System.Drawing.Point(364, 104);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(64, 59);
            this.bad.TabIndex = 12;
            this.bad.Text = "+";
            this.bad.UseMnemonic = false;
            this.bad.UseVisualStyleBackColor = false;
            this.bad.Click += new System.EventHandler(this.bad_Click);
            // 
            // bsub
            // 
            this.bsub.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bsub.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bsub.Location = new System.Drawing.Point(364, 198);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(64, 59);
            this.bsub.TabIndex = 13;
            this.bsub.Text = "-";
            this.bsub.UseMnemonic = false;
            this.bsub.UseVisualStyleBackColor = false;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // bequal
            // 
            this.bequal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bequal.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bequal.Location = new System.Drawing.Point(470, 104);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(64, 59);
            this.bequal.TabIndex = 15;
            this.bequal.Text = "=";
            this.bequal.UseMnemonic = false;
            this.bequal.UseVisualStyleBackColor = false;
            this.bequal.Click += new System.EventHandler(this.bequal_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnC.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnC.Location = new System.Drawing.Point(245, 379);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(64, 59);
            this.btnC.TabIndex = 16;
            this.btnC.Text = "C";
            this.btnC.UseMnemonic = false;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // bmult
            // 
            this.bmult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bmult.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bmult.Location = new System.Drawing.Point(364, 292);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(64, 59);
            this.bmult.TabIndex = 17;
            this.bmult.Text = "*";
            this.bmult.UseMnemonic = false;
            this.bmult.UseVisualStyleBackColor = false;
            this.bmult.Click += new System.EventHandler(this.bmult_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dot.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dot.Location = new System.Drawing.Point(12, 379);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(64, 59);
            this.dot.TabIndex = 18;
            this.dot.Text = ".";
            this.dot.UseMnemonic = false;
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // bdiv
            // 
            this.bdiv.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bdiv.Font = new System.Drawing.Font("LCD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bdiv.Location = new System.Drawing.Point(364, 379);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(64, 59);
            this.bdiv.TabIndex = 19;
            this.bdiv.Text = "/";
            this.bdiv.UseMnemonic = false;
            this.bdiv.UseVisualStyleBackColor = false;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(546, 447);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button n1;
        private Button n3;
        private Button n6;
        private Button n5;
        private Button n4;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button n0;
        private Button n2;
        private Button bad;
        private Button bsub;
        private Button bequal;
        private Button btnC;
        private Button bmult;
        private Button dot;
        private Button bdiv;
    }
}