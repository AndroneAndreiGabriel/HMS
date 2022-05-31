
namespace HospitalManagementSystem
{
    partial class LabTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabTests));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabTestsImg = new System.Windows.Forms.PictureBox();
            this.LabTestsLbl = new System.Windows.Forms.Label();
            this.ReturnHomeImg = new System.Windows.Forms.PictureBox();
            this.ReturnHomeLbl = new System.Windows.Forms.Label();
            this.TestName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TestCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TestsDGV = new System.Windows.Forms.DataGridView();
            this.AddTest = new System.Windows.Forms.Button();
            this.DeleteTest = new System.Windows.Forms.Button();
            this.EditTest = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabTestsImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnHomeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.LabTestsImg);
            this.panel1.Controls.Add(this.LabTestsLbl);
            this.panel1.Controls.Add(this.ReturnHomeImg);
            this.panel1.Controls.Add(this.ReturnHomeLbl);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 781);
            this.panel1.TabIndex = 43;
            // 
            // LabTestsImg
            // 
            this.LabTestsImg.Image = ((System.Drawing.Image)(resources.GetObject("LabTestsImg.Image")));
            this.LabTestsImg.Location = new System.Drawing.Point(33, 289);
            this.LabTestsImg.Name = "LabTestsImg";
            this.LabTestsImg.Size = new System.Drawing.Size(50, 51);
            this.LabTestsImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LabTestsImg.TabIndex = 53;
            this.LabTestsImg.TabStop = false;
            // 
            // LabTestsLbl
            // 
            this.LabTestsLbl.AutoSize = true;
            this.LabTestsLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTestsLbl.Location = new System.Drawing.Point(89, 305);
            this.LabTestsLbl.Name = "LabTestsLbl";
            this.LabTestsLbl.Size = new System.Drawing.Size(74, 23);
            this.LabTestsLbl.TabIndex = 54;
            this.LabTestsLbl.Text = "Analize";
            this.LabTestsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ReturnHomeLbl.Location = new System.Drawing.Point(83, 729);
            this.ReturnHomeLbl.Name = "ReturnHomeLbl";
            this.ReturnHomeLbl.Size = new System.Drawing.Size(61, 23);
            this.ReturnHomeLbl.TabIndex = 11;
            this.ReturnHomeLbl.Text = "Acasa";
            this.ReturnHomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReturnHomeLbl.Click += new System.EventHandler(this.ReturnHomeLbl_Click);
            // 
            // TestName
            // 
            this.TestName.Location = new System.Drawing.Point(329, 206);
            this.TestName.Margin = new System.Windows.Forms.Padding(4);
            this.TestName.Name = "TestName";
            this.TestName.Size = new System.Drawing.Size(205, 30);
            this.TestName.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(325, 179);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 23);
            this.label9.TabIndex = 44;
            this.label9.Text = "Denumire test";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestCost
            // 
            this.TestCost.Location = new System.Drawing.Point(581, 206);
            this.TestCost.Margin = new System.Windows.Forms.Padding(4);
            this.TestCost.Name = "TestCost";
            this.TestCost.Size = new System.Drawing.Size(205, 30);
            this.TestCost.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Pret";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestsDGV
            // 
            this.TestsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestsDGV.Location = new System.Drawing.Point(204, 386);
            this.TestsDGV.Name = "TestsDGV";
            this.TestsDGV.RowHeadersWidth = 51;
            this.TestsDGV.RowTemplate.Height = 24;
            this.TestsDGV.Size = new System.Drawing.Size(1012, 396);
            this.TestsDGV.TabIndex = 48;
            this.TestsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TestsDGV_CellContentClick);
            // 
            // AddTest
            // 
            this.AddTest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTest.Location = new System.Drawing.Point(329, 330);
            this.AddTest.Name = "AddTest";
            this.AddTest.Size = new System.Drawing.Size(236, 37);
            this.AddTest.TabIndex = 49;
            this.AddTest.Text = "Adaugare";
            this.AddTest.UseVisualStyleBackColor = true;
            this.AddTest.Click += new System.EventHandler(this.AddTest_Click);
            // 
            // DeleteTest
            // 
            this.DeleteTest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTest.Location = new System.Drawing.Point(836, 330);
            this.DeleteTest.Name = "DeleteTest";
            this.DeleteTest.Size = new System.Drawing.Size(236, 37);
            this.DeleteTest.TabIndex = 51;
            this.DeleteTest.Text = "Stergere";
            this.DeleteTest.UseVisualStyleBackColor = true;
            this.DeleteTest.Click += new System.EventHandler(this.DeleteTest_Click);
            // 
            // EditTest
            // 
            this.EditTest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTest.Location = new System.Drawing.Point(581, 330);
            this.EditTest.Name = "EditTest";
            this.EditTest.Size = new System.Drawing.Size(236, 37);
            this.EditTest.TabIndex = 50;
            this.EditTest.Text = "Editare";
            this.EditTest.UseVisualStyleBackColor = true;
            this.EditTest.Click += new System.EventHandler(this.EditTest_Click);
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1166, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 51);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 52;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LabTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 796);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DeleteTest);
            this.Controls.Add(this.EditTest);
            this.Controls.Add(this.AddTest);
            this.Controls.Add(this.TestsDGV);
            this.Controls.Add(this.TestCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LabTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabTests";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabTestsImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnHomeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ReturnHomeImg;
        private System.Windows.Forms.Label ReturnHomeLbl;
        private System.Windows.Forms.TextBox TestName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TestCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TestsDGV;
        private System.Windows.Forms.Button AddTest;
        private System.Windows.Forms.Button DeleteTest;
        private System.Windows.Forms.Button EditTest;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox LabTestsImg;
        private System.Windows.Forms.Label LabTestsLbl;
    }
}