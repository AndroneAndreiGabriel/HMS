
namespace HospitalManagementSystem
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.PatientName = new System.Windows.Forms.TextBox();
            this.PatientNameLbl = new System.Windows.Forms.Label();
            this.PatientGender = new System.Windows.Forms.ComboBox();
            this.PatientDOB = new System.Windows.Forms.DateTimePicker();
            this.PatientGenderLbl = new System.Windows.Forms.Label();
            this.PatientDOBLbl = new System.Windows.Forms.Label();
            this.PatientAddress = new System.Windows.Forms.TextBox();
            this.PatientAddressLbl = new System.Windows.Forms.Label();
            this.PatientPhone = new System.Windows.Forms.TextBox();
            this.PatientPhoneLbl = new System.Windows.Forms.Label();
            this.PatientCovidTest = new System.Windows.Forms.ComboBox();
            this.PatientCovidTestLbl = new System.Windows.Forms.Label();
            this.PatientAllergiesLbl = new System.Windows.Forms.Label();
            this.PatientAllergies = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReturnHomeImg = new System.Windows.Forms.PictureBox();
            this.ReturnHomeLbl = new System.Windows.Forms.Label();
            this.PatientSideImg = new System.Windows.Forms.PictureBox();
            this.PatientSideLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TestsNumber = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PatientsNumber = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PatientsDGV = new System.Windows.Forms.DataGridView();
            this.AddPatient = new System.Windows.Forms.Button();
            this.EditPatient = new System.Windows.Forms.Button();
            this.DeletePatient = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.PatientCheckInDateLbl = new System.Windows.Forms.Label();
            this.PatientCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.PatientCheckOutDateLbl = new System.Windows.Forms.Label();
            this.PatientCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.PatientDaysInHospital = new System.Windows.Forms.TextBox();
            this.PatientDaysInHospitalLbl = new System.Windows.Forms.Label();
            this.PatientAgeLbl = new System.Windows.Forms.Label();
            this.PatientAge = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnHomeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientSideImg)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientName
            // 
            this.PatientName.Location = new System.Drawing.Point(220, 41);
            this.PatientName.Margin = new System.Windows.Forms.Padding(4);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(205, 30);
            this.PatientName.TabIndex = 1;
            // 
            // PatientNameLbl
            // 
            this.PatientNameLbl.AutoSize = true;
            this.PatientNameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLbl.Location = new System.Drawing.Point(218, 14);
            this.PatientNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientNameLbl.Name = "PatientNameLbl";
            this.PatientNameLbl.Size = new System.Drawing.Size(125, 23);
            this.PatientNameLbl.TabIndex = 7;
            this.PatientNameLbl.Text = "Nume pacient";
            this.PatientNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientGender
            // 
            this.PatientGender.FormattingEnabled = true;
            this.PatientGender.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.PatientGender.Location = new System.Drawing.Point(433, 41);
            this.PatientGender.Name = "PatientGender";
            this.PatientGender.Size = new System.Drawing.Size(205, 30);
            this.PatientGender.TabIndex = 2;
            // 
            // PatientDOB
            // 
            this.PatientDOB.Location = new System.Drawing.Point(660, 41);
            this.PatientDOB.Name = "PatientDOB";
            this.PatientDOB.Size = new System.Drawing.Size(205, 30);
            this.PatientDOB.TabIndex = 3;
            this.PatientDOB.ValueChanged += new System.EventHandler(this.PatientDOB_ValueChanged);
            // 
            // PatientGenderLbl
            // 
            this.PatientGenderLbl.AutoSize = true;
            this.PatientGenderLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientGenderLbl.Location = new System.Drawing.Point(429, 14);
            this.PatientGenderLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientGenderLbl.Name = "PatientGenderLbl";
            this.PatientGenderLbl.Size = new System.Drawing.Size(107, 23);
            this.PatientGenderLbl.TabIndex = 11;
            this.PatientGenderLbl.Text = "Sex pacient";
            this.PatientGenderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientDOBLbl
            // 
            this.PatientDOBLbl.AutoSize = true;
            this.PatientDOBLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientDOBLbl.Location = new System.Drawing.Point(656, 14);
            this.PatientDOBLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientDOBLbl.Name = "PatientDOBLbl";
            this.PatientDOBLbl.Size = new System.Drawing.Size(119, 23);
            this.PatientDOBLbl.TabIndex = 12;
            this.PatientDOBLbl.Text = "Data nasterii";
            this.PatientDOBLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientAddress
            // 
            this.PatientAddress.Location = new System.Drawing.Point(220, 111);
            this.PatientAddress.Margin = new System.Windows.Forms.Padding(4);
            this.PatientAddress.Multiline = true;
            this.PatientAddress.Name = "PatientAddress";
            this.PatientAddress.Size = new System.Drawing.Size(205, 102);
            this.PatientAddress.TabIndex = 4;
            // 
            // PatientAddressLbl
            // 
            this.PatientAddressLbl.AutoSize = true;
            this.PatientAddressLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAddressLbl.Location = new System.Drawing.Point(216, 84);
            this.PatientAddressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientAddressLbl.Name = "PatientAddressLbl";
            this.PatientAddressLbl.Size = new System.Drawing.Size(70, 23);
            this.PatientAddressLbl.TabIndex = 14;
            this.PatientAddressLbl.Text = "Adresa";
            this.PatientAddressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientPhone
            // 
            this.PatientPhone.Location = new System.Drawing.Point(886, 110);
            this.PatientPhone.Margin = new System.Windows.Forms.Padding(4);
            this.PatientPhone.Name = "PatientPhone";
            this.PatientPhone.Size = new System.Drawing.Size(205, 30);
            this.PatientPhone.TabIndex = 7;
            // 
            // PatientPhoneLbl
            // 
            this.PatientPhoneLbl.AutoSize = true;
            this.PatientPhoneLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientPhoneLbl.Location = new System.Drawing.Point(882, 83);
            this.PatientPhoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientPhoneLbl.Name = "PatientPhoneLbl";
            this.PatientPhoneLbl.Size = new System.Drawing.Size(73, 23);
            this.PatientPhoneLbl.TabIndex = 15;
            this.PatientPhoneLbl.Text = "Telefon";
            this.PatientPhoneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientCovidTest
            // 
            this.PatientCovidTest.FormattingEnabled = true;
            this.PatientCovidTest.Items.AddRange(new object[] {
            "Pozitiv",
            "Negativ"});
            this.PatientCovidTest.Location = new System.Drawing.Point(660, 110);
            this.PatientCovidTest.Name = "PatientCovidTest";
            this.PatientCovidTest.Size = new System.Drawing.Size(205, 30);
            this.PatientCovidTest.TabIndex = 6;
            // 
            // PatientCovidTestLbl
            // 
            this.PatientCovidTestLbl.AutoSize = true;
            this.PatientCovidTestLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientCovidTestLbl.Location = new System.Drawing.Point(656, 84);
            this.PatientCovidTestLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientCovidTestLbl.Name = "PatientCovidTestLbl";
            this.PatientCovidTestLbl.Size = new System.Drawing.Size(133, 23);
            this.PatientCovidTestLbl.TabIndex = 18;
            this.PatientCovidTestLbl.Text = "Testat COVID";
            this.PatientCovidTestLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientAllergiesLbl
            // 
            this.PatientAllergiesLbl.AutoSize = true;
            this.PatientAllergiesLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAllergiesLbl.Location = new System.Drawing.Point(429, 84);
            this.PatientAllergiesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientAllergiesLbl.Name = "PatientAllergiesLbl";
            this.PatientAllergiesLbl.Size = new System.Drawing.Size(67, 23);
            this.PatientAllergiesLbl.TabIndex = 20;
            this.PatientAllergiesLbl.Text = "Alergii";
            this.PatientAllergiesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientAllergies
            // 
            this.PatientAllergies.Location = new System.Drawing.Point(433, 111);
            this.PatientAllergies.Margin = new System.Windows.Forms.Padding(4);
            this.PatientAllergies.Multiline = true;
            this.PatientAllergies.Name = "PatientAllergies";
            this.PatientAllergies.Size = new System.Drawing.Size(205, 102);
            this.PatientAllergies.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.ReturnHomeImg);
            this.panel1.Controls.Add(this.ReturnHomeLbl);
            this.panel1.Controls.Add(this.PatientSideImg);
            this.panel1.Controls.Add(this.PatientSideLbl);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 781);
            this.panel1.TabIndex = 22;
            // 
            // ReturnHomeImg
            // 
            this.ReturnHomeImg.Image = ((System.Drawing.Image)(resources.GetObject("ReturnHomeImg.Image")));
            this.ReturnHomeImg.Location = new System.Drawing.Point(27, 715);
            this.ReturnHomeImg.Name = "ReturnHomeImg";
            this.ReturnHomeImg.Size = new System.Drawing.Size(50, 52);
            this.ReturnHomeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReturnHomeImg.TabIndex = 10;
            this.ReturnHomeImg.TabStop = false;
            this.ReturnHomeImg.Click += new System.EventHandler(this.ReturnHomeImg_Click);
            // 
            // ReturnHomeLbl
            // 
            this.ReturnHomeLbl.AutoSize = true;
            this.ReturnHomeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnHomeLbl.Location = new System.Drawing.Point(83, 728);
            this.ReturnHomeLbl.Name = "ReturnHomeLbl";
            this.ReturnHomeLbl.Size = new System.Drawing.Size(61, 23);
            this.ReturnHomeLbl.TabIndex = 11;
            this.ReturnHomeLbl.Text = "Acasa";
            this.ReturnHomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReturnHomeLbl.Click += new System.EventHandler(this.ReturnHomeLbl_Click);
            // 
            // PatientSideImg
            // 
            this.PatientSideImg.Image = ((System.Drawing.Image)(resources.GetObject("PatientSideImg.Image")));
            this.PatientSideImg.Location = new System.Drawing.Point(27, 165);
            this.PatientSideImg.Name = "PatientSideImg";
            this.PatientSideImg.Size = new System.Drawing.Size(50, 51);
            this.PatientSideImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PatientSideImg.TabIndex = 2;
            this.PatientSideImg.TabStop = false;
            // 
            // PatientSideLbl
            // 
            this.PatientSideLbl.AutoSize = true;
            this.PatientSideLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientSideLbl.Location = new System.Drawing.Point(83, 181);
            this.PatientSideLbl.Name = "PatientSideLbl";
            this.PatientSideLbl.Size = new System.Drawing.Size(78, 23);
            this.PatientSideLbl.TabIndex = 3;
            this.PatientSideLbl.Text = "Pacienti";
            this.PatientSideLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(202, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 229);
            this.panel2.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TestsNumber);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(696, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 101);
            this.panel4.TabIndex = 2;
            // 
            // TestsNumber
            // 
            this.TestsNumber.AutoSize = true;
            this.TestsNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestsNumber.Location = new System.Drawing.Point(149, 41);
            this.TestsNumber.Name = "TestsNumber";
            this.TestsNumber.Size = new System.Drawing.Size(97, 23);
            this.TestsNumber.TabIndex = 1;
            this.TestsNumber.Text = "ANALIZE";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PatientsNumber);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(28, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 101);
            this.panel3.TabIndex = 0;
            // 
            // PatientsNumber
            // 
            this.PatientsNumber.AutoSize = true;
            this.PatientsNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsNumber.Location = new System.Drawing.Point(149, 41);
            this.PatientsNumber.Name = "PatientsNumber";
            this.PatientsNumber.Size = new System.Drawing.Size(103, 23);
            this.PatientsNumber.TabIndex = 1;
            this.PatientsNumber.Text = "PACIENTI";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PatientsDGV
            // 
            this.PatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsDGV.Location = new System.Drawing.Point(202, 326);
            this.PatientsDGV.Name = "PatientsDGV";
            this.PatientsDGV.RowHeadersWidth = 51;
            this.PatientsDGV.RowTemplate.Height = 24;
            this.PatientsDGV.Size = new System.Drawing.Size(1015, 228);
            this.PatientsDGV.TabIndex = 11;
            this.PatientsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDGV_CellClick);
            // 
            // AddPatient
            // 
            this.AddPatient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatient.Location = new System.Drawing.Point(345, 257);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Size = new System.Drawing.Size(236, 37);
            this.AddPatient.TabIndex = 10;
            this.AddPatient.Text = "Adaugare pacient";
            this.AddPatient.UseVisualStyleBackColor = true;
            this.AddPatient.Click += new System.EventHandler(this.AddPatient_Click);
            // 
            // EditPatient
            // 
            this.EditPatient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPatient.Location = new System.Drawing.Point(598, 257);
            this.EditPatient.Name = "EditPatient";
            this.EditPatient.Size = new System.Drawing.Size(236, 37);
            this.EditPatient.TabIndex = 11;
            this.EditPatient.Text = "Editare pacient";
            this.EditPatient.UseVisualStyleBackColor = true;
            this.EditPatient.Click += new System.EventHandler(this.EditPatient_Click);
            // 
            // DeletePatient
            // 
            this.DeletePatient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePatient.Location = new System.Drawing.Point(855, 257);
            this.DeletePatient.Name = "DeletePatient";
            this.DeletePatient.Size = new System.Drawing.Size(236, 37);
            this.DeletePatient.TabIndex = 12;
            this.DeletePatient.Text = "Stergere pacient";
            this.DeletePatient.UseVisualStyleBackColor = true;
            this.DeletePatient.Click += new System.EventHandler(this.DeletePatient_Click);
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1158, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 51);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 28;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PatientCheckInDateLbl
            // 
            this.PatientCheckInDateLbl.AutoSize = true;
            this.PatientCheckInDateLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientCheckInDateLbl.Location = new System.Drawing.Point(656, 155);
            this.PatientCheckInDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientCheckInDateLbl.Name = "PatientCheckInDateLbl";
            this.PatientCheckInDateLbl.Size = new System.Drawing.Size(134, 23);
            this.PatientCheckInDateLbl.TabIndex = 30;
            this.PatientCheckInDateLbl.Text = "Data internare";
            this.PatientCheckInDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientCheckInDate
            // 
            this.PatientCheckInDate.Location = new System.Drawing.Point(660, 182);
            this.PatientCheckInDate.Name = "PatientCheckInDate";
            this.PatientCheckInDate.Size = new System.Drawing.Size(205, 30);
            this.PatientCheckInDate.TabIndex = 8;
            this.PatientCheckInDate.ValueChanged += new System.EventHandler(this.PatientCheckInDate_ValueChanged);
            // 
            // PatientCheckOutDateLbl
            // 
            this.PatientCheckOutDateLbl.AutoSize = true;
            this.PatientCheckOutDateLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientCheckOutDateLbl.Location = new System.Drawing.Point(882, 155);
            this.PatientCheckOutDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientCheckOutDateLbl.Name = "PatientCheckOutDateLbl";
            this.PatientCheckOutDateLbl.Size = new System.Drawing.Size(139, 23);
            this.PatientCheckOutDateLbl.TabIndex = 32;
            this.PatientCheckOutDateLbl.Text = "Data externare";
            this.PatientCheckOutDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientCheckOutDate
            // 
            this.PatientCheckOutDate.Location = new System.Drawing.Point(886, 182);
            this.PatientCheckOutDate.Name = "PatientCheckOutDate";
            this.PatientCheckOutDate.Size = new System.Drawing.Size(205, 30);
            this.PatientCheckOutDate.TabIndex = 9;
            this.PatientCheckOutDate.ValueChanged += new System.EventHandler(this.PatientCheckOutDate_ValueChanged);
            // 
            // PatientDaysInHospital
            // 
            this.PatientDaysInHospital.Location = new System.Drawing.Point(1106, 181);
            this.PatientDaysInHospital.Margin = new System.Windows.Forms.Padding(4);
            this.PatientDaysInHospital.Name = "PatientDaysInHospital";
            this.PatientDaysInHospital.Size = new System.Drawing.Size(98, 30);
            this.PatientDaysInHospital.TabIndex = 21;
            // 
            // PatientDaysInHospitalLbl
            // 
            this.PatientDaysInHospitalLbl.AutoSize = true;
            this.PatientDaysInHospitalLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientDaysInHospitalLbl.Location = new System.Drawing.Point(1102, 155);
            this.PatientDaysInHospitalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientDaysInHospitalLbl.Name = "PatientDaysInHospitalLbl";
            this.PatientDaysInHospitalLbl.Size = new System.Drawing.Size(125, 23);
            this.PatientDaysInHospitalLbl.TabIndex = 34;
            this.PatientDaysInHospitalLbl.Text = "Zile internare";
            this.PatientDaysInHospitalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientAgeLbl
            // 
            this.PatientAgeLbl.AutoSize = true;
            this.PatientAgeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAgeLbl.Location = new System.Drawing.Point(882, 14);
            this.PatientAgeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientAgeLbl.Name = "PatientAgeLbl";
            this.PatientAgeLbl.Size = new System.Drawing.Size(131, 23);
            this.PatientAgeLbl.TabIndex = 36;
            this.PatientAgeLbl.Text = "Varsta pacient";
            this.PatientAgeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientAge
            // 
            this.PatientAge.Location = new System.Drawing.Point(886, 40);
            this.PatientAge.Margin = new System.Windows.Forms.Padding(4);
            this.PatientAge.Name = "PatientAge";
            this.PatientAge.Size = new System.Drawing.Size(127, 30);
            this.PatientAge.TabIndex = 20;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 796);
            this.Controls.Add(this.PatientAgeLbl);
            this.Controls.Add(this.PatientAge);
            this.Controls.Add(this.PatientDaysInHospitalLbl);
            this.Controls.Add(this.PatientDaysInHospital);
            this.Controls.Add(this.PatientCheckOutDateLbl);
            this.Controls.Add(this.PatientCheckOutDate);
            this.Controls.Add(this.PatientCheckInDateLbl);
            this.Controls.Add(this.PatientCheckInDate);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DeletePatient);
            this.Controls.Add(this.EditPatient);
            this.Controls.Add(this.AddPatient);
            this.Controls.Add(this.PatientsDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PatientAllergiesLbl);
            this.Controls.Add(this.PatientAllergies);
            this.Controls.Add(this.PatientCovidTestLbl);
            this.Controls.Add(this.PatientCovidTest);
            this.Controls.Add(this.PatientPhone);
            this.Controls.Add(this.PatientPhoneLbl);
            this.Controls.Add(this.PatientAddressLbl);
            this.Controls.Add(this.PatientAddress);
            this.Controls.Add(this.PatientDOBLbl);
            this.Controls.Add(this.PatientGenderLbl);
            this.Controls.Add(this.PatientDOB);
            this.Controls.Add(this.PatientGender);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.PatientNameLbl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnHomeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientSideImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.Label PatientNameLbl;
        private System.Windows.Forms.ComboBox PatientGender;
        private System.Windows.Forms.DateTimePicker PatientDOB;
        private System.Windows.Forms.Label PatientGenderLbl;
        private System.Windows.Forms.Label PatientDOBLbl;
        private System.Windows.Forms.TextBox PatientAddress;
        private System.Windows.Forms.Label PatientAddressLbl;
        private System.Windows.Forms.TextBox PatientPhone;
        private System.Windows.Forms.Label PatientPhoneLbl;
        private System.Windows.Forms.ComboBox PatientCovidTest;
        private System.Windows.Forms.Label PatientCovidTestLbl;
        private System.Windows.Forms.Label PatientAllergiesLbl;
        private System.Windows.Forms.TextBox PatientAllergies;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ReturnHomeImg;
        private System.Windows.Forms.Label ReturnHomeLbl;
        private System.Windows.Forms.PictureBox PatientSideImg;
        private System.Windows.Forms.Label PatientSideLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label TestsNumber;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PatientsNumber;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView PatientsDGV;
        private System.Windows.Forms.Button AddPatient;
        private System.Windows.Forms.Button EditPatient;
        private System.Windows.Forms.Button DeletePatient;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Label PatientCheckInDateLbl;
        private System.Windows.Forms.DateTimePicker PatientCheckInDate;
        private System.Windows.Forms.Label PatientCheckOutDateLbl;
        private System.Windows.Forms.DateTimePicker PatientCheckOutDate;
        private System.Windows.Forms.TextBox PatientDaysInHospital;
        private System.Windows.Forms.Label PatientDaysInHospitalLbl;
        private System.Windows.Forms.Label PatientAgeLbl;
        private System.Windows.Forms.TextBox PatientAge;
    }
}