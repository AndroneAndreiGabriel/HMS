using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Homes : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\Andrei\Documents\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");

        public Homes()
        {
            InitializeComponent();

            if (Login.Role == "Receptionist")
            {
                DoctorsLbl.Enabled = false;
                PrescripLbl.Enabled = false;
                LabTestsLbl.Enabled = false;
                ReceptionistsLbl.Enabled = false;
            }
            else if (Login.Role == "Doctor")
            {
                DoctorsLbl.Enabled = false;
                ReceptionistsLbl.Enabled = false;
            }

            CountPatients();
            CountDoctors();
            CountTests();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatientsLbl_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }

        private void DoctorsLbl_Click(object sender, EventArgs e)
        {
            Doctors obj = new Doctors();
            obj.Show();
            this.Hide();
        }

        private void LabTestsLbl_Click(object sender, EventArgs e)
        {
            LabTests obj = new LabTests();
            obj.Show();
            this.Hide();
        }

        private void CountPatients()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Patients", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatientsNumber.Text = dt.Rows[0][0].ToString() + " pacienti";
            Con.Close();
        }

        private void CountDoctors()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Doctors", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DoctorsNumber.Text = dt.Rows[0][0].ToString() + " doctori";
            Con.Close();
        }
        private void CountTests()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Tests", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TestsNumber.Text = dt.Rows[0][0].ToString() + " teste";
            Con.Close();
        }

        private void ReceptionistsLbl_Click(object sender, EventArgs e)
        {
            Receptionists obj = new Receptionists();
            obj.Show();
            this.Hide();
        }

        private void PrescripLbl_Click(object sender, EventArgs e)
        {
            Prescriptions obj = new Prescriptions();
            obj.Show();
            this.Hide();
        }
    }
}
