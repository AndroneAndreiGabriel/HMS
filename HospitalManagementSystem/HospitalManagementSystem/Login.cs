using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Login : Form
    {
        public static string Role;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\Andrei\Documents\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
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
                else if (Username.Text == "Administrator" && Password.Text == "Admin")
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
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Doctors where DoctorName='" + Username.Text + "'and DoctorPassword='" + Password.Text + "'", Con);
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
                    Con.Close();
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
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Receptionists where ReceptionistName='" + Username.Text + "'and ReceptionistPassword='" + Password.Text + "'", Con);
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
                    Con.Close();
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
