namespace Hospital_Administration_and_Appointment_System_prj
{
    partial class FrmSecretaryDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaryDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.secName = new System.Windows.Forms.Label();
            this.secTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateNotice = new System.Windows.Forms.Button();
            this.rchNotice = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAppList = new System.Windows.Forms.Button();
            this.btnBranchPanel = new System.Windows.Forms.Button();
            this.btnDocPanel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.mskTime = new System.Windows.Forms.MaskedTextBox();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_logout);
            this.groupBox1.Controls.Add(this.secName);
            this.groupBox1.Controls.Add(this.secTc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(289, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Informations";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(197, 123);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(84, 29);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // secName
            // 
            this.secName.AutoSize = true;
            this.secName.Location = new System.Drawing.Point(108, 84);
            this.secName.Name = "secName";
            this.secName.Size = new System.Drawing.Size(40, 21);
            this.secName.TabIndex = 4;
            this.secName.Text = "null";
            // 
            // secTc
            // 
            this.secTc.AutoSize = true;
            this.secTc.Location = new System.Drawing.Point(108, 42);
            this.secTc.Name = "secTc";
            this.secTc.Size = new System.Drawing.Size(109, 21);
            this.secTc.TabIndex = 3;
            this.secTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name\r\nSurname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateNotice);
            this.groupBox2.Controls.Add(this.rchNotice);
            this.groupBox2.Location = new System.Drawing.Point(14, 186);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(289, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create a notice";
            // 
            // btnCreateNotice
            // 
            this.btnCreateNotice.Location = new System.Drawing.Point(8, 215);
            this.btnCreateNotice.Name = "btnCreateNotice";
            this.btnCreateNotice.Size = new System.Drawing.Size(273, 36);
            this.btnCreateNotice.TabIndex = 1;
            this.btnCreateNotice.Text = "Create";
            this.btnCreateNotice.UseVisualStyleBackColor = true;
            this.btnCreateNotice.Click += new System.EventHandler(this.btnCreateNotice_Click);
            // 
            // rchNotice
            // 
            this.rchNotice.Location = new System.Drawing.Point(8, 22);
            this.rchNotice.Name = "rchNotice";
            this.rchNotice.Size = new System.Drawing.Size(273, 187);
            this.rchNotice.TabIndex = 0;
            this.rchNotice.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnAppList);
            this.groupBox3.Controls.Add(this.btnBranchPanel);
            this.groupBox3.Controls.Add(this.btnDocPanel);
            this.groupBox3.Location = new System.Drawing.Point(14, 456);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(602, 83);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quick Access";
            // 
            // btnAppList
            // 
            this.btnAppList.Location = new System.Drawing.Point(286, 22);
            this.btnAppList.Name = "btnAppList";
            this.btnAppList.Size = new System.Drawing.Size(144, 52);
            this.btnAppList.TabIndex = 2;
            this.btnAppList.Text = "Appointment List";
            this.btnAppList.UseVisualStyleBackColor = true;
            this.btnAppList.Click += new System.EventHandler(this.btnAppList_Click);
            // 
            // btnBranchPanel
            // 
            this.btnBranchPanel.Location = new System.Drawing.Point(147, 21);
            this.btnBranchPanel.Name = "btnBranchPanel";
            this.btnBranchPanel.Size = new System.Drawing.Size(133, 53);
            this.btnBranchPanel.TabIndex = 1;
            this.btnBranchPanel.Text = "Branch Panel";
            this.btnBranchPanel.UseVisualStyleBackColor = true;
            this.btnBranchPanel.Click += new System.EventHandler(this.btnBranchPanel_Click);
            // 
            // btnDocPanel
            // 
            this.btnDocPanel.Location = new System.Drawing.Point(6, 21);
            this.btnDocPanel.Name = "btnDocPanel";
            this.btnDocPanel.Size = new System.Drawing.Size(135, 52);
            this.btnDocPanel.TabIndex = 0;
            this.btnDocPanel.Text = "Doctor Panel";
            this.btnDocPanel.UseVisualStyleBackColor = true;
            this.btnDocPanel.Click += new System.EventHandler(this.btnDocPanel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.mskID);
            this.groupBox4.Controls.Add(this.cmbDoctor);
            this.groupBox4.Controls.Add(this.cmbBranch);
            this.groupBox4.Controls.Add(this.mskTime);
            this.groupBox4.Controls.Add(this.mskDate);
            this.groupBox4.Controls.Add(this.txtid);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(313, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(303, 426);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Appointment Panel";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(121, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 21);
            this.label13.TabIndex = 13;
            this.label13.Text = "Situation:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(109, 280);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 25);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Free";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "TC:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Doctor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Branch:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date:";
            // 
            // mskID
            // 
            this.mskID.Location = new System.Drawing.Point(102, 240);
            this.mskID.Name = "mskID";
            this.mskID.Size = new System.Drawing.Size(154, 28);
            this.mskID.TabIndex = 6;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(102, 205);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(154, 29);
            this.cmbDoctor.TabIndex = 5;
            // 
            // cmbBranch
            // 
            this.cmbBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(102, 169);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(154, 29);
            this.cmbBranch.TabIndex = 4;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // mskTime
            // 
            this.mskTime.Location = new System.Drawing.Point(102, 132);
            this.mskTime.Mask = "00:00";
            this.mskTime.Name = "mskTime";
            this.mskTime.Size = new System.Drawing.Size(154, 28);
            this.mskTime.TabIndex = 3;
            this.mskTime.ValidatingType = typeof(System.DateTime);
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(102, 96);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(154, 28);
            this.mskDate.TabIndex = 2;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(102, 58);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(154, 28);
            this.txtid.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "id:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(626, 19);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(421, 255);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Branches";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Location = new System.Drawing.Point(626, 285);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox6.Size = new System.Drawing.Size(421, 254);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(5, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(411, 223);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(121, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 36);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Announcements";
            this.button1.UseVisualStyleBackColor = true;
//            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSecretaryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1061, 555);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSecretaryDetail";
            this.Text = "Ankara Hospital";
            this.Load += new System.EventHandler(this.FrmSecretaryDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label secTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label secName;
        private System.Windows.Forms.Button btnCreateNotice;
        private System.Windows.Forms.RichTextBox rchNotice;
        private System.Windows.Forms.Button btnAppList;
        private System.Windows.Forms.Button btnBranchPanel;
        private System.Windows.Forms.Button btnDocPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.MaskedTextBox mskID;
        public System.Windows.Forms.ComboBox cmbDoctor;
        public System.Windows.Forms.ComboBox cmbBranch;
        public System.Windows.Forms.MaskedTextBox mskTime;
        public System.Windows.Forms.MaskedTextBox mskDate;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button1;
    }
}