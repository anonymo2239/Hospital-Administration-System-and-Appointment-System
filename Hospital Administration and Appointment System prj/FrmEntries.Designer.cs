namespace Hospital_Administration_and_Appointment_System_prj
{
    partial class FrmEntries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntries));
            this.btnPaitent = new System.Windows.Forms.Button();
            this.btnPhysician = new System.Windows.Forms.Button();
            this.btnSecretary = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPaitent
            // 
            this.btnPaitent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaitent.BackgroundImage")));
            this.btnPaitent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaitent.Location = new System.Drawing.Point(15, 80);
            this.btnPaitent.Margin = new System.Windows.Forms.Padding(6);
            this.btnPaitent.Name = "btnPaitent";
            this.btnPaitent.Size = new System.Drawing.Size(193, 192);
            this.btnPaitent.TabIndex = 0;
            this.btnPaitent.UseVisualStyleBackColor = true;
            this.btnPaitent.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPhysician
            // 
            this.btnPhysician.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhysician.BackgroundImage")));
            this.btnPhysician.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhysician.Location = new System.Drawing.Point(220, 80);
            this.btnPhysician.Margin = new System.Windows.Forms.Padding(6);
            this.btnPhysician.Name = "btnPhysician";
            this.btnPhysician.Size = new System.Drawing.Size(193, 192);
            this.btnPhysician.TabIndex = 1;
            this.btnPhysician.UseVisualStyleBackColor = true;
            this.btnPhysician.Click += new System.EventHandler(this.btnPhysician_Click);
            // 
            // btnSecretary
            // 
            this.btnSecretary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSecretary.BackgroundImage")));
            this.btnSecretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSecretary.Location = new System.Drawing.Point(425, 80);
            this.btnSecretary.Margin = new System.Windows.Forms.Padding(6);
            this.btnSecretary.Name = "btnSecretary";
            this.btnSecretary.Size = new System.Drawing.Size(193, 192);
            this.btnSecretary.TabIndex = 2;
            this.btnSecretary.UseVisualStyleBackColor = true;
            this.btnSecretary.Click += new System.EventHandler(this.btnSecretary_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 59);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ankara Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label3.Location = new System.Drawing.Point(263, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Physician";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label4.Location = new System.Drawing.Point(468, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Secretary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(440, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "About Us";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSecretary);
            this.Controls.Add(this.btnPhysician);
            this.Controls.Add(this.btnPaitent);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmEntries";
            this.Text = "Ankara Hospital Entry";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaitent;
        private System.Windows.Forms.Button btnPhysician;
        private System.Windows.Forms.Button btnSecretary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

