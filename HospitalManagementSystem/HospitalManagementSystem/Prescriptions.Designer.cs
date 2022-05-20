
namespace HospitalManagementSystem
{
    partial class Prescriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescriptions));
            this.label10 = new System.Windows.Forms.Label();
            this.DoctorId = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DoctorName = new System.Windows.Forms.TextBox();
            this.EditPrescrip = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DeletePrescrip = new System.Windows.Forms.Button();
            this.AddPrescrip = new System.Windows.Forms.Button();
            this.PrescripDGV = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.PatientId = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TestId = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TestName = new System.Windows.Forms.TextBox();
            this.PrescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Medicines = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.PrintPrescrip = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ReturnHome = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.PrescripLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescripDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(217, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 23);
            this.label10.TabIndex = 54;
            this.label10.Text = "ID Doctor";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoctorId
            // 
            this.DoctorId.FormattingEnabled = true;
            this.DoctorId.Location = new System.Drawing.Point(220, 36);
            this.DoctorId.Name = "DoctorId";
            this.DoctorId.Size = new System.Drawing.Size(205, 30);
            this.DoctorId.TabIndex = 1;
            this.DoctorId.SelectionChangeCommitted += new System.EventHandler(this.DoctorId_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(430, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 23);
            this.label9.TabIndex = 50;
            this.label9.Text = "Nume doctor";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoctorName
            // 
            this.DoctorName.Enabled = false;
            this.DoctorName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorName.Location = new System.Drawing.Point(434, 36);
            this.DoctorName.Margin = new System.Windows.Forms.Padding(4);
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Size = new System.Drawing.Size(205, 30);
            this.DoctorName.TabIndex = 2;
            // 
            // EditPrescrip
            // 
            this.EditPrescrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPrescrip.Location = new System.Drawing.Point(599, 332);
            this.EditPrescrip.Name = "EditPrescrip";
            this.EditPrescrip.Size = new System.Drawing.Size(236, 37);
            this.EditPrescrip.TabIndex = 11;
            this.EditPrescrip.Text = "Editare prescriptie";
            this.EditPrescrip.UseVisualStyleBackColor = true;
            this.EditPrescrip.Click += new System.EventHandler(this.EditPrescrip_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(203, 630);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 151);
            this.panel2.TabIndex = 65;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(696, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 101);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "ANALIZE";
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
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Location = new System.Drawing.Point(365, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 101);
            this.panel6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOCTORI";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(94, 95);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(28, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 101);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "PACIENTI";
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
            // DeletePrescrip
            // 
            this.DeletePrescrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePrescrip.Location = new System.Drawing.Point(856, 332);
            this.DeletePrescrip.Name = "DeletePrescrip";
            this.DeletePrescrip.Size = new System.Drawing.Size(236, 37);
            this.DeletePrescrip.TabIndex = 12;
            this.DeletePrescrip.Text = "Stergere prescriptie";
            this.DeletePrescrip.UseVisualStyleBackColor = true;
            this.DeletePrescrip.Click += new System.EventHandler(this.DeletePrescrip_Click);
            // 
            // AddPrescrip
            // 
            this.AddPrescrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPrescrip.Location = new System.Drawing.Point(346, 332);
            this.AddPrescrip.Name = "AddPrescrip";
            this.AddPrescrip.Size = new System.Drawing.Size(236, 37);
            this.AddPrescrip.TabIndex = 10;
            this.AddPrescrip.Text = "Adaugare prescriptie";
            this.AddPrescrip.UseVisualStyleBackColor = true;
            this.AddPrescrip.Click += new System.EventHandler(this.AddPrescrip_Click);
            // 
            // PrescripDGV
            // 
            this.PrescripDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescripDGV.Location = new System.Drawing.Point(221, 377);
            this.PrescripDGV.Name = "PrescripDGV";
            this.PrescripDGV.RowHeadersWidth = 51;
            this.PrescripDGV.RowTemplate.Height = 24;
            this.PrescripDGV.Size = new System.Drawing.Size(997, 234);
            this.PrescripDGV.TabIndex = 13;
            this.PrescripDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrescripDGV_CellContentClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(217, 84);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 23);
            this.label17.TabIndex = 73;
            this.label17.Text = "ID Pacient";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientId
            // 
            this.PatientId.FormattingEnabled = true;
            this.PatientId.Location = new System.Drawing.Point(220, 111);
            this.PatientId.Name = "PatientId";
            this.PatientId.Size = new System.Drawing.Size(205, 30);
            this.PatientId.TabIndex = 3;
            this.PatientId.SelectionChangeCommitted += new System.EventHandler(this.PatientId_SelectionChangeCommitted);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(217, 155);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 23);
            this.label14.TabIndex = 75;
            this.label14.Text = "ID Test laborator";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestId
            // 
            this.TestId.FormattingEnabled = true;
            this.TestId.Location = new System.Drawing.Point(220, 182);
            this.TestId.Name = "TestId";
            this.TestId.Size = new System.Drawing.Size(205, 30);
            this.TestId.TabIndex = 5;
            this.TestId.SelectionChangeCommitted += new System.EventHandler(this.TestId_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(430, 84);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 23);
            this.label12.TabIndex = 76;
            this.label12.Text = "Nume pacient";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientName
            // 
            this.PatientName.Enabled = false;
            this.PatientName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.Location = new System.Drawing.Point(434, 111);
            this.PatientName.Margin = new System.Windows.Forms.Padding(4);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(205, 30);
            this.PatientName.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(430, 155);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 23);
            this.label15.TabIndex = 78;
            this.label15.Text = "Test";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestName
            // 
            this.TestName.Enabled = false;
            this.TestName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestName.Location = new System.Drawing.Point(434, 182);
            this.TestName.Margin = new System.Windows.Forms.Padding(4);
            this.TestName.Name = "TestName";
            this.TestName.Size = new System.Drawing.Size(205, 30);
            this.TestName.TabIndex = 6;
            // 
            // PrescriptionTxt
            // 
            this.PrescriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrescriptionTxt.Location = new System.Drawing.Point(646, 36);
            this.PrescriptionTxt.Name = "PrescriptionTxt";
            this.PrescriptionTxt.Size = new System.Drawing.Size(446, 209);
            this.PrescriptionTxt.TabIndex = 9;
            this.PrescriptionTxt.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(819, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 23);
            this.label11.TabIndex = 81;
            this.label11.Text = "Prescriptie";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(217, 222);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 23);
            this.label13.TabIndex = 82;
            this.label13.Text = "Medicamente";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Medicines
            // 
            this.Medicines.Location = new System.Drawing.Point(221, 249);
            this.Medicines.Margin = new System.Windows.Forms.Padding(4);
            this.Medicines.Multiline = true;
            this.Medicines.Name = "Medicines";
            this.Medicines.Size = new System.Drawing.Size(205, 69);
            this.Medicines.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(430, 222);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 23);
            this.label16.TabIndex = 84;
            this.label16.Text = "Cost";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cost
            // 
            this.Cost.Enabled = false;
            this.Cost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(434, 249);
            this.Cost.Margin = new System.Windows.Forms.Padding(4);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(205, 30);
            this.Cost.TabIndex = 8;
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1155, 36);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 51);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 86;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PrintPrescrip
            // 
            this.PrintPrescrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPrescrip.Location = new System.Drawing.Point(760, 251);
            this.PrintPrescrip.Name = "PrintPrescrip";
            this.PrintPrescrip.Size = new System.Drawing.Size(236, 37);
            this.PrintPrescrip.TabIndex = 87;
            this.PrintPrescrip.Text = "Printare prescriptie";
            this.PrintPrescrip.UseVisualStyleBackColor = true;
            this.PrintPrescrip.Click += new System.EventHandler(this.PrintPrescrip_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ReturnHome
            // 
            this.ReturnHome.AutoSize = true;
            this.ReturnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnHome.Location = new System.Drawing.Point(83, 732);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(61, 23);
            this.ReturnHome.TabIndex = 11;
            this.ReturnHome.Text = "Acasa";
            this.ReturnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHome_Click);
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
            // 
            // PrescripLbl
            // 
            this.PrescripLbl.AutoSize = true;
            this.PrescripLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescripLbl.Location = new System.Drawing.Point(82, 291);
            this.PrescripLbl.Name = "PrescripLbl";
            this.PrescripLbl.Size = new System.Drawing.Size(97, 23);
            this.PrescripLbl.TabIndex = 13;
            this.PrescripLbl.Text = "Prescriptii";
            this.PrescripLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.PrescripLbl);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.ReturnHome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 781);
            this.panel1.TabIndex = 64;
            // 
            // Prescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 796);
            this.Controls.Add(this.PrintPrescrip);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Medicines);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PrescriptionTxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TestName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TestId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.PatientId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DoctorId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DoctorName);
            this.Controls.Add(this.EditPrescrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DeletePrescrip);
            this.Controls.Add(this.AddPrescrip);
            this.Controls.Add(this.PrescripDGV);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Prescriptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescriptions";
            this.Load += new System.EventHandler(this.Prescriptions_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescripDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox DoctorId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DoctorName;
        private System.Windows.Forms.Button EditPrescrip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button DeletePrescrip;
        private System.Windows.Forms.Button AddPrescrip;
        private System.Windows.Forms.DataGridView PrescripDGV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox PatientId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox TestId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TestName;
        private System.Windows.Forms.RichTextBox PrescriptionTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Medicines;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Button PrintPrescrip;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label ReturnHome;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label PrescripLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}