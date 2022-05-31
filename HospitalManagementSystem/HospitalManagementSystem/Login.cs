using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Login : Form
    {
        public static string Role;

        public Login()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            UserType.Text = "";
            Username.Text = "";
            Password.Text = "";
        }

        private void Authentication_Click(object sender, EventArgs e)
        {
            if (UserType.SelectedIndex == -1)
            {
                MessageBox.Show("Selectati tipul utilizatorului");
            }
            else if (UserType.SelectedIndex == 0)
            {
                if (Username.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Introduceti userul si parola pentru administrator");
                }
                else if (Username.Text == "Administrator" && Password.Text == "Administrator")
                {
                    Role = Username.Text;
                    Homes Object = new Homes();
                    Object.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credentiale gresite");
                }
            }
            else if (UserType.SelectedIndex == 1)
            {
                if (Username.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Introduceti userul si parola pentru doctor");
                }
                else
                {
                    using (var connection = Program.CreateOpenConnection())
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Doctors where DoctorName='" + Username.Text + "'and DoctorPassword='" + Password.Text + "'", connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            Role = "Doctor";
                            Homes Obj = new Homes();
                            Obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Credentiale gresite!");
                        }
                    }
                }
            }
            else
            {
                if (Username.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Introduceti userul si parola pentru receptionist");
                }
                else
                {
                        using (var connection = Program.CreateOpenConnection())
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Receptionists where ReceptionistName='" + Username.Text + "'and ReceptionistPassword='" + Password.Text + "'", connection);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                Role = "Receptionist";
                                Homes Obj = new Homes();
                                Obj.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Credentiale gresite!");
                            }
                        }
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
