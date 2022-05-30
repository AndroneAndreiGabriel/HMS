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
    public partial class Patients : Form
    {
        private int Key = 0;
        public Patients()
        {
            InitializeComponent();
            DisplayPatients();

            CountPatients();
            CountTests();

            PatientsDGV.ReadOnly = true;
            PatientsDGV.AllowUserToAddRows = false;
            PatientDaysInHospital.ReadOnly = true;
        }
       
        private void Patients_Load(object sender, EventArgs e)
        {

        }

        private void DisplayPatients()
        {
            using (var connection = Program.CreateOpenConnection())
            {
                string Query = "select * from Patients";
                SqlDataAdapter sda = new SqlDataAdapter(Query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                PatientsDGV.DataSource = ds.Tables[0];
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear()
        {
            PatientName.Text = "";
            PatientGender.Text = "";
            PatientDOB.Text = "";
            PatientPhone.Text = "";
            PatientAddress.Text = "";
            PatientAllergies.Text = "";
            PatientCovidTest.Text = "";
            PatientCheckInDate.Text = "";
            PatientCheckOutDate.Text = "";
            PatientDaysInHospital.Text = "";
            Key = 0;
        }

        private void AddPatient_Click(object sender, EventArgs e)
        {
            if (PatientName.Text == "" ||
                PatientGender.SelectedIndex == -1 ||
                PatientDOB.Text == "" ||
                PatientPhone.Text == "" ||
                PatientAddress.Text == "" ||
                PatientAllergies.Text == "" ||
                PatientCovidTest.SelectedIndex == -1 ||
                PatientCheckInDate.Text == "" ||
                PatientCheckOutDate.Text == "")
            {
                MessageBox.Show("Lipsa informatii. Toate campurile sunt obligatorii!");
            }
            else
            {
                try
                {
                    using (var connection = Program.CreateOpenConnection())
                    {
                        SqlCommand cmd = new SqlCommand("insert into Patients(PatientName, PatientGender, PatientDOB, PatientPhone, PatientAddress, PatientAllergies, PatientCovidTest, CheckInDate, CheckOutDate, DaysInHospital)"
                                                                     + "values(@PNM, @PGN, @PDB, @PPH, @PAD, @PAL, @PCV, @CID, @COD, @DIH)", connection);
                        cmd.Parameters.AddWithValue("@PNM", PatientName.Text);
                        cmd.Parameters.AddWithValue("@PGN", PatientGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PDB", PatientDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@PPH", PatientPhone.Text);
                        cmd.Parameters.AddWithValue("@PAD", PatientAddress.Text);
                        cmd.Parameters.AddWithValue("@PAL", PatientAllergies.Text);
                        cmd.Parameters.AddWithValue("@PCV", PatientCovidTest.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@CID", PatientCheckInDate.Value.Date);
                        cmd.Parameters.AddWithValue("@COD", PatientCheckOutDate.Value.Date);

                        var differenceOfDate = PatientCheckOutDate.Value.Date - PatientCheckInDate.Value.Date;

                        cmd.Parameters.AddWithValue("@DIH", differenceOfDate.Days);
                        cmd.ExecuteNonQuery();
                    }

                    DisplayPatients();
                    Clear();
                    MessageBox.Show("Pacient adaugat");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditPatient_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = Program.CreateOpenConnection())
                {
                    SqlCommand cmd = new SqlCommand("update Patients set PatientName = @PNM," +
                                                                    "PatientGender = @PGN," +
                                                                    "PatientDOB = @PDB," +
                                                                    "PatientPhone = @PPH," +
                                                                    "PatientAddress = @PAD," +
                                                                    "PatientAllergies = @PAL," +
                                                                    "PatientCovidTest = @PCV," +
                                                                    "PatientCheckInDate = @CID," +
                                                                    "PatientCheckOutDate = @COD," +
                                                                    "PatientDaysInHospital = @DIH" +
                                                                    " where PatientId = @PID", connection);
                    cmd.Parameters.AddWithValue("@PNM", PatientName.Text);
                    cmd.Parameters.AddWithValue("@PGN", PatientGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PDB", PatientDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PPH", PatientPhone.Text);
                    cmd.Parameters.AddWithValue("@PAD", PatientAddress.Text);
                    cmd.Parameters.AddWithValue("@PAL", PatientAllergies.Text);
                    cmd.Parameters.AddWithValue("@PCV", PatientCovidTest.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CID", PatientCheckInDate.Value.Date);
                    cmd.Parameters.AddWithValue("@COD", PatientCheckOutDate.Value.Date);

                    var differenceOfDate = PatientCheckOutDate.Value.Date - PatientCheckInDate.Value.Date;

                    cmd.Parameters.AddWithValue("@DIH", differenceOfDate.Days);
                    cmd.Parameters.AddWithValue("@PID", Key);
                    cmd.ExecuteNonQuery();
                }

                DisplayPatients();
                Clear();
                MessageBox.Show("Pacient actualizat!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeletePatient_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Selectati o inregistrare");
            }
            else
            {
                try
                {
                    using (var connection = Program.CreateOpenConnection())
                    {
                        SqlCommand cmd = new SqlCommand("delete from Patients where PatientId=@PID", connection);
                        cmd.Parameters.AddWithValue("@PID", Key);
                        cmd.ExecuteNonQuery();
                    }

                    DisplayPatients();
                    Clear();
                    MessageBox.Show("Pacient sters!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PatientsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                Key = Convert.ToInt32(PatientsDGV.Rows[e.RowIndex].Cells[0].Value);

                PatientName.Text = PatientsDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                PatientGender.Text = PatientsDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                PatientDOB.Text = PatientsDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                PatientPhone.Text = PatientsDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                PatientAddress.Text = PatientsDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                PatientAllergies.Text = PatientsDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
                PatientCovidTest.Text = PatientsDGV.Rows[e.RowIndex].Cells[7].Value.ToString();
                PatientCheckInDate.Text = PatientsDGV.Rows[e.RowIndex].Cells[8].Value.ToString();
                PatientCheckOutDate.Text = PatientsDGV.Rows[e.RowIndex].Cells[9].Value.ToString();
                PatientDaysInHospital.Text = PatientsDGV.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
        }

        private void ReturnHome_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Hide();
        }

        private void CountPatients()
        {
            using (var connection = Program.CreateOpenConnection())
            {
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Patients", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                PatientsNumber.Text = dt.Rows[0][0].ToString() + " pacienti";
            }
        }

        private void CountTests()
        {
            using (var connection = Program.CreateOpenConnection())
            {
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Tests", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TestsNumber.Text = dt.Rows[0][0].ToString() + " teste";
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Hide();
        }

        private void PatientDaysInHospital_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
