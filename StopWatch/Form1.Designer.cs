namespace StopWatch
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
            this.components = new System.ComponentModel.Container();
            this.startBTN = new System.Windows.Forms.Button();
            this.stopBTN = new System.Windows.Forms.Button();
            this.restartBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startBTN.Font = new System.Drawing.Font("LCD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startBTN.Location = new System.Drawing.Point(67, 223);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(120, 46);
            this.startBTN.TabIndex = 1;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // stopBTN
            // 
            this.stopBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.stopBTN.Font = new System.Drawing.Font("LCD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stopBTN.Location = new System.Drawing.Point(288, 223);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(120, 46);
            this.stopBTN.TabIndex = 2;
            this.stopBTN.Text = "Stop";
            this.stopBTN.UseMnemonic = false;
            this.stopBTN.UseVisualStyleBackColor = false;
            this.stopBTN.Click += new System.EventHandler(this.stopBTN_Click);
            // 
            // restartBTN
            // 
            this.restartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.restartBTN.Font = new System.Drawing.Font("LCD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restartBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.restartBTN.Location = new System.Drawing.Point(699, 223);
            this.restartBTN.Name = "restartBTN";
            this.restartBTN.Size = new System.Drawing.Size(120, 46);
            this.restartBTN.TabIndex = 3;
            this.restartBTN.Text = "Restart";
            this.restartBTN.UseVisualStyleBackColor = false;
            this.restartBTN.Click += new System.EventHandler(this.restartBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LCD", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(672, 108);
            this.label2.TabIndex = 4;
            this.label2.Text = "00:00:00.000";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.restartBTN);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.startBTN);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button startBTN;
        private Button stopBTN;
        private Button restartBTN;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}