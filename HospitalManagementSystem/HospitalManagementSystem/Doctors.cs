using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Doctors : Form
    {

        private int     Key = 0;        
        public Doctors()
        {
            InitializeComponent();
            DisplayDoctors();

            CountPatients();
            CountTests();
            DoctorsDGV.ReadOnly = true;
            DoctorsDGV.AllowUserToAddRows = false;
        }
        private void Doctors_Load(object sender, EventArgs e)
        {

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

        private void AddDoctor_Click(object sender, EventArgs e)
        {
            if (DoctorName.Text == "" ||
                DoctorSpec.SelectedIndex == -1 ||
                DoctorDOB.Text == "" ||
                DoctorPhone.Text == "" ||
                DoctorAddress.Text == "" ||
                DoctorExp.Text == "" ||
                DoctorCovidTest.SelectedIndex == -1 ||
                DoctorPassword.Text == "")
            {
                MessageBox.Show("Lipsa informatii. Toate campurile sunt obligatorii!");
            }
            else
            {
                try
                {
                    using (var connection = Program.CreateOpenConnection())
                    {
                        SqlCommand cmd = new SqlCommand("insert into Doctors(DoctorName, DoctorSpecialization, DoctorDOB, DoctorPhone, DoctorAddress, DoctorExperience, DoctorCovidTest, DoctorPassword)"
                                                                     + "values(@DNM, @DSP, @DDB, @DPH, @DAD, @DEX, @DCV, @DPS)", connection);
                        cmd.Parameters.AddWithValue("@DNM", DoctorName.Text);
                        cmd.Parameters.AddWithValue("@DSP", DoctorSpec.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DDB", DoctorDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@DPH", DoctorPhone.Text);
                        cmd.Parameters.AddWithValue("@DAD", DoctorAddress.Text);
                        cmd.Parameters.AddWithValue("@DEX", DoctorExp.Text);
                        cmd.Parameters.AddWithValue("@DCV", DoctorCovidTest.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DPS", DoctorPassword.Text);
                        cmd.ExecuteNonQuery();
                    }

                    DisplayDoctors();
                    Clear();
                    MessageBox.Show("Doctor adaugat");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void EditDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = Program.CreateOpenConnection())
                {
                    SqlCommand cmd = new SqlCommand("update Doctors set DoctorName = @DNM," +
                                                                   "DoctorSpecialization = @DSP," +
                                                                   "DoctorDOB = @DDB," +
                                                                   "DoctorPhone = @DPH," +
                                                                   "DoctorAddress = @DAD," +
                                                                   "DoctorExperience = @DEX," +
                                                                   "DoctorCovidTest = @DCV," +
                                                                   "DoctorPassword = @DPS" +
                                                                   " where DoctorId = @DID", connection);
                    cmd.Parameters.AddWithValue("@DNM", DoctorName.Text);
                    cmd.Parameters.AddWithValue("@DSP", DoctorSpec.Text);
                    cmd.Parameters.AddWithValue("@DDB", DoctorDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DPH", DoctorPhone.Text);
                    cmd.Parameters.AddWithValue("@DAD", DoctorAddress.Text);
                    cmd.Parameters.AddWithValue("@DEX", DoctorExp.Text);
                    cmd.Parameters.AddWithValue("@DCV", DoctorCovidTest.Text);
                    cmd.Parameters.AddWithValue("@DPS", DoctorPassword.Text);
                    cmd.Parameters.AddWithValue("@DID", Key);
                    cmd.ExecuteNonQuery();
                }

                DisplayDoctors();
                Clear();
                MessageBox.Show("Doctor actualizat!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteDoctor_Click(object sender, EventArgs e)
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
                        SqlCommand cmd = new SqlCommand("delete from Doctors where DoctorId=@DID", connection);
                        cmd.Parameters.AddWithValue("@DID", Key);
                        cmd.ExecuteNonQuery();
                    }

                    DisplayDoctors();
                    Clear();
                    MessageBox.Show("Doctor sters!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DisplayDoctors()
        {
            using (var connection = Program.CreateOpenConnection())
            {
                string Query = "select * from Doctors";
                SqlDataAdapter sda = new SqlDataAdapter(Query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DoctorsDGV.DataSource = ds.Tables[0];
            }
        }

        private void Clear()
        {
            DoctorName.Text = "";
            DoctorSpec.Text = "";
            DoctorDOB.Text = "";
            DoctorPhone.Text = "";
            DoctorAddress.Text = "";
            DoctorExp.Text = "";
            DoctorCovidTest.Text = "";
            DoctorPassword.Text = "";
            Key = 0;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnHome_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Hide();
        }

        private void DoctorsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                Key = Convert.ToInt32(DoctorsDGV.Rows[e.RowIndex].Cells[0].Value);

                DoctorName.Text = DoctorsDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                DoctorSpec.Text = DoctorsDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                DoctorDOB.Text = DoctorsDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                DoctorPhone.Text = DoctorsDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                DoctorAddress.Text = DoctorsDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                DoctorExp.Text = DoctorsDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
                DoctorCovidTest.Text = DoctorsDGV.Rows[e.RowIndex].Cells[7].Value.ToString();
                DoctorPassword.Text = DoctorsDGV.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Hide();
        }
    }
}
