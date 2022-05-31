
namespace HospitalManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UserTypeLbl = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Authentication = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEM GESTIUNE SPITAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 83);
            this.panel1.TabIndex = 1;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.Location = new System.Drawing.Point(46, 237);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(117, 23);
            this.UsernameLbl.TabIndex = 2;
            this.UsernameLbl.Text = "ID Utilizator";
            this.UsernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserType
            // 
            this.UserType.FormattingEnabled = true;
            this.UserType.Items.AddRange(new object[] {
            "Administrator",
            "Doctor",
            "Receptionist"});
            this.UserType.Location = new System.Drawing.Point(215, 169);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(205, 30);
            this.UserType.TabIndex = 3;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(46, 297);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(65, 23);
            this.PasswordLbl.TabIndex = 4;
            this.PasswordLbl.Text = "Parola";
            this.PasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTypeLbl
            // 
            this.UserTypeLbl.AutoSize = true;
            this.UserTypeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeLbl.Location = new System.Drawing.Point(46, 176);
            this.UserTypeLbl.Name = "UserTypeLbl";
            this.UserTypeLbl.Size = new System.Drawing.Size(120, 23);
            this.UserTypeLbl.TabIndex = 5;
            this.UserTypeLbl.Text = "Tip utilizator";
            this.UserTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(215, 230);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(205, 30);
            this.Username.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(215, 290);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(205, 30);
            this.Password.TabIndex = 7;
            // 
            // Authentication
            // 
            this.Authentication.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authentication.Location = new System.Drawing.Point(130, 374);
            this.Authentication.Name = "Authentication";
            this.Authentication.Size = new System.Drawing.Size(236, 37);
            this.Authentication.TabIndex = 8;
            this.Authentication.Text = "Autentificare";
            this.Authentication.UseVisualStyleBackColor = true;
            this.Authentication.Click += new System.EventHandler(this.Authentication_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(130, 417);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(236, 37);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Resetare";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(224, 469);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 51);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 13;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 541);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Authentication);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.UserTypeLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fereastra de autentificare";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label UserTypeLbl;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Authentication;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.PictureBox Exit;
    }
}

