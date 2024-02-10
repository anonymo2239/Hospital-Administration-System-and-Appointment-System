namespace Hospital_Administration_and_Appointment_System_prj
{
    partial class FrmPatientDetail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkeditinfo = new System.Windows.Forms.LinkLabel();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rchComplain = new System.Windows.Forms.RichTextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbbranch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appBranchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appDoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appSituationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patientTCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAppointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_ProjectDataSet = new Hospital_Administration_and_Appointment_System_prj.Hospital_ProjectDataSet();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.table_AppointmentsTableAdapter = new Hospital_Administration_and_Appointment_System_prj.Hospital_ProjectDataSetTableAdapters.Table_AppointmentsTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAppointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ProjectDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkeditinfo);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(318, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Informations";
            // 
            // lnkeditinfo
            // 
            this.lnkeditinfo.AutoSize = true;
            this.lnkeditinfo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkeditinfo.Location = new System.Drawing.Point(145, 134);
            this.lnkeditinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkeditinfo.Name = "lnkeditinfo";
            this.lnkeditinfo.Size = new System.Drawing.Size(169, 18);
            this.lnkeditinfo.TabIndex = 6;
            this.lnkeditinfo.TabStop = true;
            this.lnkeditinfo.Text = "Edit your informations";
            this.lnkeditinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkeditinfo_LinkClicked);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(140, 104);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(60, 21);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "NULL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(140, 73);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "NULL";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(140, 45);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(109, 21);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "00000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_logout);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rchComplain);
            this.groupBox2.Controls.Add(this.cmbDoctor);
            this.groupBox2.Controls.Add(this.cmbbranch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(11, 181);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(318, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Panel";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(5, 281);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(83, 36);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(127, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(162, 28);
            this.txtID.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(144, 258);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Make an appointment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rchComplain
            // 
            this.rchComplain.Location = new System.Drawing.Point(127, 154);
            this.rchComplain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rchComplain.Name = "rchComplain";
            this.rchComplain.Size = new System.Drawing.Size(162, 100);
            this.rchComplain.TabIndex = 5;
            this.rchComplain.Text = "";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(126, 111);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(162, 29);
            this.cmbDoctor.TabIndex = 4;
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbDoctor_SelectedIndexChanged);
            // 
            // cmbbranch
            // 
            this.cmbbranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbranch.FormattingEnabled = true;
            this.cmbbranch.Location = new System.Drawing.Point(127, 69);
            this.cmbbranch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbbranch.Name = "cmbbranch";
            this.cmbbranch.Size = new System.Drawing.Size(162, 29);
            this.cmbbranch.TabIndex = 3;
            this.cmbbranch.SelectedIndexChanged += new System.EventHandler(this.cmbbranch_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Complaint:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Physician:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(333, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(572, 268);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appIDDataGridViewTextBoxColumn,
            this.appDateDataGridViewTextBoxColumn,
            this.appTimeDataGridViewTextBoxColumn,
            this.appBranchDataGridViewTextBoxColumn,
            this.appDoctorDataGridViewTextBoxColumn,
            this.appSituationDataGridViewCheckBoxColumn,
            this.patientTCIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableAppointmentsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // appIDDataGridViewTextBoxColumn
            // 
            this.appIDDataGridViewTextBoxColumn.DataPropertyName = "AppID";
            this.appIDDataGridViewTextBoxColumn.HeaderText = "AppID";
            this.appIDDataGridViewTextBoxColumn.Name = "appIDDataGridViewTextBoxColumn";
            // 
            // appDateDataGridViewTextBoxColumn
            // 
            this.appDateDataGridViewTextBoxColumn.DataPropertyName = "AppDate";
            this.appDateDataGridViewTextBoxColumn.HeaderText = "AppDate";
            this.appDateDataGridViewTextBoxColumn.Name = "appDateDataGridViewTextBoxColumn";
            // 
            // appTimeDataGridViewTextBoxColumn
            // 
            this.appTimeDataGridViewTextBoxColumn.DataPropertyName = "AppTime";
            this.appTimeDataGridViewTextBoxColumn.HeaderText = "AppTime";
            this.appTimeDataGridViewTextBoxColumn.Name = "appTimeDataGridViewTextBoxColumn";
            // 
            // appBranchDataGridViewTextBoxColumn
            // 
            this.appBranchDataGridViewTextBoxColumn.DataPropertyName = "AppBranch";
            this.appBranchDataGridViewTextBoxColumn.HeaderText = "AppBranch";
            this.appBranchDataGridViewTextBoxColumn.Name = "appBranchDataGridViewTextBoxColumn";
            // 
            // appDoctorDataGridViewTextBoxColumn
            // 
            this.appDoctorDataGridViewTextBoxColumn.DataPropertyName = "AppDoctor";
            this.appDoctorDataGridViewTextBoxColumn.HeaderText = "AppDoctor";
            this.appDoctorDataGridViewTextBoxColumn.Name = "appDoctorDataGridViewTextBoxColumn";
            // 
            // appSituationDataGridViewCheckBoxColumn
            // 
            this.appSituationDataGridViewCheckBoxColumn.DataPropertyName = "AppSituation";
            this.appSituationDataGridViewCheckBoxColumn.HeaderText = "AppSituation";
            this.appSituationDataGridViewCheckBoxColumn.Name = "appSituationDataGridViewCheckBoxColumn";
            // 
            // patientTCIDDataGridViewTextBoxColumn
            // 
            this.patientTCIDDataGridViewTextBoxColumn.DataPropertyName = "PatientTCID";
            this.patientTCIDDataGridViewTextBoxColumn.HeaderText = "PatientTCID";
            this.patientTCIDDataGridViewTextBoxColumn.Name = "patientTCIDDataGridViewTextBoxColumn";
            // 
            // tableAppointmentsBindingSource
            // 
            this.tableAppointmentsBindingSource.DataMember = "Table_Appointments";
            this.tableAppointmentsBindingSource.DataSource = this.hospital_ProjectDataSet;
            // 
            // hospital_ProjectDataSet
            // 
            this.hospital_ProjectDataSet.DataSetName = "Hospital_ProjectDataSet";
            this.hospital_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(333, 285);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(572, 219);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Appointments";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(2, 24);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(568, 192);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // table_AppointmentsTableAdapter
            // 
            this.table_AppointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(914, 523);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPatientDetail";
            this.Text = "Ankara Hospital";
            this.Load += new System.EventHandler(this.FrmPatientDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAppointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ProjectDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rchComplain;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbbranch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel lnkeditinfo;
        private Hospital_ProjectDataSet hospital_ProjectDataSet;
        private System.Windows.Forms.BindingSource tableAppointmentsBindingSource;
        private Hospital_ProjectDataSetTableAdapters.Table_AppointmentsTableAdapter table_AppointmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appBranchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appDoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn appSituationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientTCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_logout;
    }
}