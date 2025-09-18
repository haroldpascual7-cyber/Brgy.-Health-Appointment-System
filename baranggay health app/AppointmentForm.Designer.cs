namespace baranggay_health_app
{
    partial class AppointmentForm
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
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPatients = new System.Windows.Forms.Label();
            this.cbFilterPurpose = new System.Windows.Forms.ComboBox();
            this.schedule = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbPurpose = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGuardian = new System.Windows.Forms.TextBox();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.dptbirthdate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Doctors_BTN = new System.Windows.Forms.Button();
            this.History_BTN = new System.Windows.Forms.Button();
            this.Delete_BTN = new System.Windows.Forms.Button();
            this.loadpatientdata = new System.Windows.Forms.Button();
            this.Doctor_BTN = new System.Windows.Forms.Panel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.patientid = new System.Windows.Forms.TextBox();
            this.doctorid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Doctor_BTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAppointments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(313, 136);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RowHeadersWidth = 62;
            this.dgvAppointments.Size = new System.Drawing.Size(867, 388);
            this.dgvAppointments.StandardTab = true;
            this.dgvAppointments.TabIndex = 10;
            this.dgvAppointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellClick);
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            this.dgvAppointments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::baranggay_health_app.Properties.Resources.Screenshot_2025_02_16_142825;
            this.panel1.Controls.Add(this.lblTotalPatients);
            this.panel1.Controls.Add(this.cbFilterPurpose);
            this.panel1.Controls.Add(this.schedule);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.cbPurpose);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtGuardian);
            this.panel1.Controls.Add(this.cbDoctor);
            this.panel1.Controls.Add(this.txtContactNumber);
            this.panel1.Controls.Add(this.dptbirthdate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.PatientName);
            this.panel1.Controls.Add(this.cbSex);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 489);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lblTotalPatients
            // 
            this.lblTotalPatients.AutoSize = true;
            this.lblTotalPatients.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPatients.Location = new System.Drawing.Point(162, 37);
            this.lblTotalPatients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPatients.Name = "lblTotalPatients";
            this.lblTotalPatients.Size = new System.Drawing.Size(15, 16);
            this.lblTotalPatients.TabIndex = 29;
            this.lblTotalPatients.Text = "  ";
            // 
            // cbFilterPurpose
            // 
            this.cbFilterPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterPurpose.FormattingEnabled = true;
            this.cbFilterPurpose.Location = new System.Drawing.Point(204, 8);
            this.cbFilterPurpose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFilterPurpose.Name = "cbFilterPurpose";
            this.cbFilterPurpose.Size = new System.Drawing.Size(82, 23);
            this.cbFilterPurpose.TabIndex = 28;
            // 
            // schedule
            // 
            this.schedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.schedule.Location = new System.Drawing.Point(117, 309);
            this.schedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(157, 20);
            this.schedule.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(51, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Location = new System.Drawing.Point(117, 367);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(159, 20);
            this.txtAddress.TabIndex = 25;
            // 
            // cbPurpose
            // 
            this.cbPurpose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPurpose.FormattingEnabled = true;
            this.cbPurpose.Items.AddRange(new object[] {
            "",
            "General check up",
            "Vaccine",
            "Prenatal check up"});
            this.cbPurpose.Location = new System.Drawing.Point(117, 243);
            this.cbPurpose.Name = "cbPurpose";
            this.cbPurpose.Size = new System.Drawing.Size(159, 21);
            this.cbPurpose.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(37, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(158, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGuardian
            // 
            this.txtGuardian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGuardian.Location = new System.Drawing.Point(117, 335);
            this.txtGuardian.Multiline = true;
            this.txtGuardian.Name = "txtGuardian";
            this.txtGuardian.Size = new System.Drawing.Size(159, 23);
            this.txtGuardian.TabIndex = 20;
            // 
            // cbDoctor
            // 
            this.cbDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Items.AddRange(new object[] {
            "     ",
            "jhony",
            "clark",
            "kath",
            "anna"});
            this.cbDoctor.Location = new System.Drawing.Point(117, 275);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(159, 21);
            this.cbDoctor.TabIndex = 18;
            this.cbDoctor.SelectedIndexChanged += new System.EventHandler(this.cbDoctor_SelectedIndexChanged);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContactNumber.Location = new System.Drawing.Point(119, 200);
            this.txtContactNumber.Multiline = true;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(157, 23);
            this.txtContactNumber.TabIndex = 16;
            // 
            // dptbirthdate
            // 
            this.dptbirthdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dptbirthdate.Location = new System.Drawing.Point(117, 167);
            this.dptbirthdate.Name = "dptbirthdate";
            this.dptbirthdate.Size = new System.Drawing.Size(158, 20);
            this.dptbirthdate.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(53, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "BirthDate:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(53, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Guardian:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(51, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Schedule:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(30, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Doctor/Nurse:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(59, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Purpose:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(23, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(85, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sex:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(229, 126);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(57, 20);
            this.txtAge.TabIndex = 7;
            // 
            // PatientName
            // 
            this.PatientName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PatientName.Location = new System.Drawing.Point(131, 83);
            this.PatientName.Multiline = true;
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(156, 29);
            this.PatientName.TabIndex = 2;
            // 
            // cbSex
            // 
            this.cbSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cbSex.Location = new System.Drawing.Point(131, 126);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(55, 21);
            this.cbSex.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(197, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "PATIENT NAME:\r\n\r\n";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BackgroundImage = global::baranggay_health_app.Properties.Resources.topbackground1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.Doctors_BTN);
            this.panel3.Controls.Add(this.History_BTN);
            this.panel3.Controls.Add(this.Delete_BTN);
            this.panel3.Controls.Add(this.loadpatientdata);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(313, 522);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 106);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::baranggay_health_app.Properties.Resources.print2025;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(69, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 35);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(133, 25);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 28);
            this.button4.TabIndex = 30;
            this.button4.Text = "Print data";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(284, 25);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 22);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Doctors_BTN
            // 
            this.Doctors_BTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Doctors_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Doctors_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctors_BTN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Doctors_BTN.Location = new System.Drawing.Point(500, 24);
            this.Doctors_BTN.Name = "Doctors_BTN";
            this.Doctors_BTN.Size = new System.Drawing.Size(108, 23);
            this.Doctors_BTN.TabIndex = 3;
            this.Doctors_BTN.Text = "Load Doctors Data";
            this.Doctors_BTN.UseVisualStyleBackColor = false;
            this.Doctors_BTN.Click += new System.EventHandler(this.Doctors_BTN_Click);
            // 
            // History_BTN
            // 
            this.History_BTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.History_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.History_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.History_BTN.Location = new System.Drawing.Point(392, 24);
            this.History_BTN.Name = "History_BTN";
            this.History_BTN.Size = new System.Drawing.Size(75, 22);
            this.History_BTN.TabIndex = 2;
            this.History_BTN.Text = "History";
            this.History_BTN.UseVisualStyleBackColor = false;
            this.History_BTN.Click += new System.EventHandler(this.History_BTN_Click);
            // 
            // Delete_BTN
            // 
            this.Delete_BTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Delete_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_BTN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Delete_BTN.Location = new System.Drawing.Point(761, 22);
            this.Delete_BTN.Name = "Delete_BTN";
            this.Delete_BTN.Size = new System.Drawing.Size(72, 24);
            this.Delete_BTN.TabIndex = 1;
            this.Delete_BTN.Text = "Delete";
            this.Delete_BTN.UseVisualStyleBackColor = false;
            this.Delete_BTN.Click += new System.EventHandler(this.Delete_BTN_Click);
            // 
            // loadpatientdata
            // 
            this.loadpatientdata.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loadpatientdata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadpatientdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadpatientdata.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loadpatientdata.Location = new System.Drawing.Point(632, 24);
            this.loadpatientdata.Name = "loadpatientdata";
            this.loadpatientdata.Size = new System.Drawing.Size(103, 22);
            this.loadpatientdata.TabIndex = 0;
            this.loadpatientdata.Text = "Load Patient Data";
            this.loadpatientdata.UseVisualStyleBackColor = false;
            this.loadpatientdata.Click += new System.EventHandler(this.button3_Click);
            // 
            // Doctor_BTN
            // 
            this.Doctor_BTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Doctor_BTN.BackColor = System.Drawing.Color.PaleGreen;
            this.Doctor_BTN.BackgroundImage = global::baranggay_health_app.Properties.Resources.topbackground;
            this.Doctor_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Doctor_BTN.Controls.Add(this.searchbtn);
            this.Doctor_BTN.Controls.Add(this.pictureBox1);
            this.Doctor_BTN.Controls.Add(this.searchtxt);
            this.Doctor_BTN.Controls.Add(this.patientid);
            this.Doctor_BTN.Controls.Add(this.doctorid);
            this.Doctor_BTN.Controls.Add(this.label1);
            this.Doctor_BTN.Location = new System.Drawing.Point(1, 1);
            this.Doctor_BTN.Name = "Doctor_BTN";
            this.Doctor_BTN.Size = new System.Drawing.Size(1179, 134);
            this.Doctor_BTN.TabIndex = 9;
            this.Doctor_BTN.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchbtn.Location = new System.Drawing.Point(959, 88);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(70, 22);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::baranggay_health_app.Properties.Resources.healthcare_clipart_health_barangay_worker_18__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1039, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 85);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // searchtxt
            // 
            this.searchtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchtxt.Location = new System.Drawing.Point(773, 90);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(177, 20);
            this.searchtxt.TabIndex = 3;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // patientid
            // 
            this.patientid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientid.Location = new System.Drawing.Point(63, 36);
            this.patientid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientid.Name = "patientid";
            this.patientid.Size = new System.Drawing.Size(93, 20);
            this.patientid.TabIndex = 2;
            this.patientid.Visible = false;
            // 
            // doctorid
            // 
            this.doctorid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doctorid.Location = new System.Drawing.Point(63, 12);
            this.doctorid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doctorid.Name = "doctorid";
            this.doctorid.Size = new System.Drawing.Size(93, 20);
            this.doctorid.TabIndex = 1;
            this.doctorid.Visible = false;
            this.doctorid.TextChanged += new System.EventHandler(this.cbDoctor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(239, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BARANGGAY HEALTH APPOINTMENT SYSTEM";
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1175, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.Doctor_BTN);
            this.Name = "AppointmentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Doctor_BTN.ResumeLayout(false);
            this.Doctor_BTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.DateTimePicker dptbirthdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGuardian;
        private System.Windows.Forms.ComboBox cbPurpose;
        private System.Windows.Forms.Panel Doctor_BTN;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox doctorid;
        private System.Windows.Forms.TextBox patientid;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Doctors_BTN;
        private System.Windows.Forms.Button History_BTN;
        private System.Windows.Forms.Button Delete_BTN;
        private System.Windows.Forms.Button loadpatientdata;
        private System.Windows.Forms.DateTimePicker schedule;
        private System.Windows.Forms.ComboBox cbFilterPurpose;
        private System.Windows.Forms.Label lblTotalPatients;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}