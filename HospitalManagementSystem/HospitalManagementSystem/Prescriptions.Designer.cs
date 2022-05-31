
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
            this.DoctorIdLbl = new System.Windows.Forms.Label();
            this.DoctorId = new System.Windows.Forms.ComboBox();
            this.DoctorNameLbl = new System.Windows.Forms.Label();
            this.DoctorName = new System.Windows.Forms.TextBox();
            this.EditPrescrip = new System.Windows.Forms.Button();
            this.DeletePrescrip = new System.Windows.Forms.Button();
            this.AddPrescrip = new System.Windows.Forms.Button();
            this.PrescripDGV = new System.Windows.Forms.DataGridView();
            this.PatientIdLbl = new System.Windows.Forms.Label();
            this.PatientId = new System.Windows.Forms.ComboBox();
            this.TestIdLbl = new System.Windows.Forms.Label();
            this.TestId = new System.Windows.Forms.ComboBox();
            this.PatientNameLbl = new System.Windows.Forms.Label();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.TestNameLbl = new System.Windows.Forms.Label();
            this.TestName = new System.Windows.Forms.TextBox();
            this.PrescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.PrescriptionTxtLbl = new System.Windows.Forms.Label();
            this.MedicinesLbl = new System.Windows.Forms.Label();
            this.Medicines = new System.Windows.Forms.TextBox();
            this.CostLbl = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.PrintPrescrip = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ReturnHomeLbl = new System.Windows.Forms.Label();
            this.ReturnHomeImg = new System.Windows.Forms.PictureBox();
            this.PrescripLbl = new System.Windows.Forms.Label();
            this.PrescripImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PrescripDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnHomeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescripImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoctorIdLbl
            // 
            this.DoctorIdLbl.AutoSize = true;
            this.DoctorIdLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorIdLbl.Location = new System.Drawing.Point(217, 9);
            this.DoctorIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoctorIdLbl.Name = "DoctorIdLbl";
            this.DoctorIdLbl.Size = new System.Drawing.Size(94, 23);
            this.DoctorIdLbl.TabIndex = 54;
            this.DoctorIdLbl.Text = "ID Doctor";
            this.DoctorIdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // DoctorNameLbl
            // 
            this.DoctorNameLbl.AutoSize = true;
            this.DoctorNameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameLbl.Location = new System.Drawing.Point(430, 9);
            this.DoctorNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoctorNameLbl.Name = "DoctorNameLbl";
            this.DoctorNameLbl.Size = new System.Drawing.Size(118, 23);
            this.DoctorNameLbl.TabIndex = 50;
            this.DoctorNameLbl.Text = "Nume doctor";
            this.DoctorNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.PrescripDGV.Location = new System.Drawing.Point(203, 377);
            this.PrescripDGV.Name = "PrescripDGV";
            this.PrescripDGV.RowHeadersWidth = 51;
            this.PrescripDGV.RowTemplate.Height = 24;
            this.PrescripDGV.Size = new System.Drawing.Size(1015, 404);
            this.PrescripDGV.TabIndex = 13;
            this.PrescripDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrescripDGV_CellClick);
            // 
            // PatientIdLbl
            // 
            this.PatientIdLbl.AutoSize = true;
            this.PatientIdLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIdLbl.Location = new System.Drawing.Point(217, 84);
            this.PatientIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientIdLbl.Name = "PatientIdLbl";
            this.PatientIdLbl.Size = new System.Drawing.Size(99, 23);
            this.PatientIdLbl.TabIndex = 73;
            this.PatientIdLbl.Text = "ID Pacient";
            this.PatientIdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // TestIdLbl
            // 
            this.TestIdLbl.AutoSize = true;
            this.TestIdLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestIdLbl.Location = new System.Drawing.Point(217, 155);
            this.TestIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TestIdLbl.Name = "TestIdLbl";
            this.TestIdLbl.Size = new System.Drawing.Size(155, 23);
            this.TestIdLbl.TabIndex = 75;
            this.TestIdLbl.Text = "ID Test laborator";
            this.TestIdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // PatientNameLbl
            // 
            this.PatientNameLbl.AutoSize = true;
            this.PatientNameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLbl.Location = new System.Drawing.Point(430, 84);
            this.PatientNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientNameLbl.Name = "PatientNameLbl";
            this.PatientNameLbl.Size = new System.Drawing.Size(125, 23);
            this.PatientNameLbl.TabIndex = 76;
            this.PatientNameLbl.Text = "Nume pacient";
            this.PatientNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // TestNameLbl
            // 
            this.TestNameLbl.AutoSize = true;
            this.TestNameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNameLbl.Location = new System.Drawing.Point(430, 155);
            this.TestNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TestNameLbl.Name = "TestNameLbl";
            this.TestNameLbl.Size = new System.Drawing.Size(46, 23);
            this.TestNameLbl.TabIndex = 78;
            this.TestNameLbl.Text = "Test";
            this.TestNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // PrescriptionTxtLbl
            // 
            this.PrescriptionTxtLbl.AutoSize = true;
            this.PrescriptionTxtLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionTxtLbl.Location = new System.Drawing.Point(819, 9);
            this.PrescriptionTxtLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrescriptionTxtLbl.Name = "PrescriptionTxtLbl";
            this.PrescriptionTxtLbl.Size = new System.Drawing.Size(102, 23);
            this.PrescriptionTxtLbl.TabIndex = 81;
            this.PrescriptionTxtLbl.Text = "Prescriptie";
            this.PrescriptionTxtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedicinesLbl
            // 
            this.MedicinesLbl.AutoSize = true;
            this.MedicinesLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicinesLbl.Location = new System.Drawing.Point(217, 222);
            this.MedicinesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedicinesLbl.Name = "MedicinesLbl";
            this.MedicinesLbl.Size = new System.Drawing.Size(124, 23);
            this.MedicinesLbl.TabIndex = 82;
            this.MedicinesLbl.Text = "Medicamente";
            this.MedicinesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLbl.Location = new System.Drawing.Point(430, 222);
            this.CostLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(49, 23);
            this.CostLbl.TabIndex = 84;
            this.CostLbl.Text = "Cost";
            this.CostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // ReturnHomeLbl
            // 
            this.ReturnHomeLbl.AutoSize = true;
            this.ReturnHomeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnHomeLbl.Location = new System.Drawing.Point(83, 729);
            this.ReturnHomeLbl.Name = "ReturnHomeLbl";
            this.ReturnHomeLbl.Size = new System.Drawing.Size(61, 23);
            this.ReturnHomeLbl.TabIndex = 11;
            this.ReturnHomeLbl.Text = "Acasa";
            this.ReturnHomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReturnHomeLbl.Click += new System.EventHandler(this.ReturnHomeLbl_Click);
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
            // PrescripImg
            // 
            this.PrescripImg.Image = ((System.Drawing.Image)(resources.GetObject("PrescripImg.Image")));
            this.PrescripImg.Location = new System.Drawing.Point(26, 275);
            this.PrescripImg.Name = "PrescripImg";
            this.PrescripImg.Size = new System.Drawing.Size(50, 51);
            this.PrescripImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrescripImg.TabIndex = 12;
            this.PrescripImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.PrescripImg);
            this.panel1.Controls.Add(this.PrescripLbl);
            this.panel1.Controls.Add(this.ReturnHomeImg);
            this.panel1.Controls.Add(this.ReturnHomeLbl);
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
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.MedicinesLbl);
            this.Controls.Add(this.Medicines);
            this.Controls.Add(this.PrescriptionTxtLbl);
            this.Controls.Add(this.PrescriptionTxt);
            this.Controls.Add(this.TestNameLbl);
            this.Controls.Add(this.TestName);
            this.Controls.Add(this.PatientNameLbl);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.TestIdLbl);
            this.Controls.Add(this.TestId);
            this.Controls.Add(this.PatientIdLbl);
            this.Controls.Add(this.PatientId);
            this.Controls.Add(this.DoctorIdLbl);
            this.Controls.Add(this.DoctorId);
            this.Controls.Add(this.DoctorNameLbl);
            this.Controls.Add(this.DoctorName);
            this.Controls.Add(this.EditPrescrip);
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
            ((System.ComponentModel.ISupportInitialize)(this.PrescripDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnHomeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescripImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DoctorIdLbl;
        private System.Windows.Forms.ComboBox DoctorId;
        private System.Windows.Forms.Label DoctorNameLbl;
        private System.Windows.Forms.TextBox DoctorName;
        private System.Windows.Forms.Button EditPrescrip;
        private System.Windows.Forms.Button DeletePrescrip;
        private System.Windows.Forms.Button AddPrescrip;
        private System.Windows.Forms.DataGridView PrescripDGV;
        private System.Windows.Forms.Label PatientIdLbl;
        private System.Windows.Forms.ComboBox PatientId;
        private System.Windows.Forms.Label TestIdLbl;
        private System.Windows.Forms.ComboBox TestId;
        private System.Windows.Forms.Label PatientNameLbl;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.Label TestNameLbl;
        private System.Windows.Forms.TextBox TestName;
        private System.Windows.Forms.RichTextBox PrescriptionTxt;
        private System.Windows.Forms.Label PrescriptionTxtLbl;
        private System.Windows.Forms.Label MedicinesLbl;
        private System.Windows.Forms.TextBox Medicines;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Button PrintPrescrip;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label ReturnHomeLbl;
        private System.Windows.Forms.PictureBox ReturnHomeImg;
        private System.Windows.Forms.Label PrescripLbl;
        private System.Windows.Forms.PictureBox PrescripImg;
        private System.Windows.Forms.Panel panel1;
    }
}