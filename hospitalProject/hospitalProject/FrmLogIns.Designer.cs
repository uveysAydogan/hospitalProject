namespace hospitalProject
{
    partial class FrmLogIns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIns));
            this.btnDrLogin = new System.Windows.Forms.Button();
            this.btnPatLogin = new System.Windows.Forms.Button();
            this.btnSecLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDrLogin
            // 
            this.btnDrLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDrLogin.BackgroundImage")));
            this.btnDrLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrLogin.Location = new System.Drawing.Point(60, 234);
            this.btnDrLogin.Name = "btnDrLogin";
            this.btnDrLogin.Size = new System.Drawing.Size(207, 183);
            this.btnDrLogin.TabIndex = 0;
            this.btnDrLogin.UseVisualStyleBackColor = true;
            this.btnDrLogin.Click += new System.EventHandler(this.btnDrLogin_Click);
            // 
            // btnPatLogin
            // 
            this.btnPatLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatLogin.BackgroundImage")));
            this.btnPatLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPatLogin.Location = new System.Drawing.Point(306, 234);
            this.btnPatLogin.Name = "btnPatLogin";
            this.btnPatLogin.Size = new System.Drawing.Size(207, 183);
            this.btnPatLogin.TabIndex = 1;
            this.btnPatLogin.UseVisualStyleBackColor = true;
            this.btnPatLogin.Click += new System.EventHandler(this.btnPatLogin_Click);
            // 
            // btnSecLogin
            // 
            this.btnSecLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSecLogin.BackgroundImage")));
            this.btnSecLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSecLogin.Location = new System.Drawing.Point(560, 234);
            this.btnSecLogin.Name = "btnSecLogin";
            this.btnSecLogin.Size = new System.Drawing.Size(207, 183);
            this.btnSecLogin.TabIndex = 2;
            this.btnSecLogin.UseVisualStyleBackColor = true;
            this.btnSecLogin.Click += new System.EventHandler(this.btnSecLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(116, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(356, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(597, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secretary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(608, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(483, 62);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rainbow Hospital";
            // 
            // FrmLogIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(844, 512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSecLogin);
            this.Controls.Add(this.btnPatLogin);
            this.Controls.Add(this.btnDrLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogIns";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrLogin;
        private System.Windows.Forms.Button btnPatLogin;
        private System.Windows.Forms.Button btnSecLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

