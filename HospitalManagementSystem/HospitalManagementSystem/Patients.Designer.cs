﻿
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
            this.label9 = new System.Windows.Forms.Label();
            this.PatientGender = new System.Windows.Forms.ComboBox();
            this.PatientDOB = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PatientAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PatientPhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PatientCovidTest = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PatientAllergies = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.ReturnHome = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.PatientCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.PatientCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.PatientDaysInHospital = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(218, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nume pacient";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(429, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Sex pacient";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(656, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "Data nasterii";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientAddress
            // 
            this.PatientAddress.Location = new System.Drawing.Point(220, 111);
            this.PatientAddress.Margin = new System.Windows.Forms.Padding(4);
            this.PatientAddress.Multiline = true;
            this.PatientAddress.Name = "PatientAddress";
            this.PatientAddress.Size = new System.Drawing.Size(205, 102);
            this.PatientAddress.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(216, 84);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Adresa";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientPhone
            // 
            this.PatientPhone.Location = new System.Drawing.Point(886, 41);
            this.PatientPhone.Margin = new System.Windows.Forms.Padding(4);
            this.PatientPhone.Name = "PatientPhone";
            this.PatientPhone.Size = new System.Drawing.Size(205, 30);
            this.PatientPhone.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(882, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "Telefon";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.PatientCovidTest.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(656, 84);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 23);
            this.label14.TabIndex = 18;
            this.label14.Text = "Testat COVID";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(429, 84);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "Alergii";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientAllergies
            // 
            this.PatientAllergies.Location = new System.Drawing.Point(433, 111);
            this.PatientAllergies.Margin = new System.Windows.Forms.Padding(4);
            this.PatientAllergies.Multiline = true;
            this.PatientAllergies.Name = "PatientAllergies";
            this.PatientAllergies.Size = new System.Drawing.Size(205, 102);
            this.PatientAllergies.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.ReturnHome);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 781);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(27, 715);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 52);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // ReturnHome
            // 
            this.ReturnHome.AutoSize = true;
            this.ReturnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnHome.Location = new System.Drawing.Point(83, 728);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(61, 23);
            this.ReturnHome.TabIndex = 11;
            this.ReturnHome.Text = "Acasa";
            this.ReturnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHome_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(27, 165);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pacienti";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.AddPatient.TabIndex = 8;
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
            this.EditPatient.TabIndex = 9;
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
            this.DeletePatient.TabIndex = 10;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Data internare";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientCheckInDate
            // 
            this.PatientCheckInDate.Location = new System.Drawing.Point(660, 182);
            this.PatientCheckInDate.Name = "PatientCheckInDate";
            this.PatientCheckInDate.Size = new System.Drawing.Size(205, 30);
            this.PatientCheckInDate.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(882, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Data externare";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientCheckOutDate
            // 
            this.PatientCheckOutDate.Location = new System.Drawing.Point(886, 182);
            this.PatientCheckOutDate.Name = "PatientCheckOutDate";
            this.PatientCheckOutDate.Size = new System.Drawing.Size(205, 30);
            this.PatientCheckOutDate.TabIndex = 31;
            // 
            // PatientDaysInHospital
            // 
            this.PatientDaysInHospital.Location = new System.Drawing.Point(1106, 181);
            this.PatientDaysInHospital.Margin = new System.Windows.Forms.Padding(4);
            this.PatientDaysInHospital.Name = "PatientDaysInHospital";
            this.PatientDaysInHospital.Size = new System.Drawing.Size(98, 30);
            this.PatientDaysInHospital.TabIndex = 33;
            this.PatientDaysInHospital.TextChanged += new System.EventHandler(this.PatientDaysInHospital_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1102, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Zile internare";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 796);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PatientDaysInHospital);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatientCheckOutDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientCheckInDate);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DeletePatient);
            this.Controls.Add(this.EditPatient);
            this.Controls.Add(this.AddPatient);
            this.Controls.Add(this.PatientsDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PatientAllergies);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PatientCovidTest);
            this.Controls.Add(this.PatientPhone);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PatientAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PatientDOB);
            this.Controls.Add(this.PatientGender);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox PatientGender;
        private System.Windows.Forms.DateTimePicker PatientDOB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PatientAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PatientPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox PatientCovidTest;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PatientAllergies;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label ReturnHome;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker PatientCheckInDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker PatientCheckOutDate;
        private System.Windows.Forms.TextBox PatientDaysInHospital;
        private System.Windows.Forms.Label label3;
    }
}