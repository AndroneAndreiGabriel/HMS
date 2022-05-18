﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Doctors : Form
    {

        private int     Key = 0;
        SqlConnection   Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\Andrei\Documents\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Doctors()
        {
            InitializeComponent();
            DisplayDoctors();
        }
        private void Doctors_Load(object sender, EventArgs e)
        {

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
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Doctors(DoctorName, DoctorSpecialization, DoctorDOB, DoctorPhone, DoctorAddress, DoctorExperience, DoctorCovidTest, DoctorPassword)"
                                                                     + "values(@DNM, @DSP, @DDB, @DPH, @DAD, @DEX, @DCV, @DPS)", Con);
                    cmd.Parameters.AddWithValue("@DNM", DoctorName.Text);
                    cmd.Parameters.AddWithValue("@DSP", DoctorSpec.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DDB", DoctorDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DPH", DoctorPhone.Text);
                    cmd.Parameters.AddWithValue("@DAD", DoctorAddress.Text);
                    cmd.Parameters.AddWithValue("@DEX", DoctorExp.Text);
                    cmd.Parameters.AddWithValue("@DCV", DoctorCovidTest.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DPS", DoctorPassword.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();

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
                Con.Open();
                SqlCommand cmd = new SqlCommand("update Doctors set DoctorName = @DNM," +
                                                                   "DoctorSpecialization = @DSP," +
                                                                   "DoctorDOB = @DDB," +
                                                                   "DoctorPhone = @DPH," +
                                                                   "DoctorAddress = @DAD," +
                                                                   "DoctorExperience = @DEX," +
                                                                   "DoctorCovidTest = @DCV," +
                                                                   "DoctorPassword = @DPS" +
                                                                   " where DoctorId = @DID", Con);
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
                Con.Close();

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
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Doctors where DoctorId=@DID", Con);
                    cmd.Parameters.AddWithValue("@DID", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();

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

        private void DoctorsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void DisplayDoctors()
        {
            Con.Open();
            string Query = "select * from Doctors";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DoctorsDGV.DataSource = ds.Tables[0];
            Con.Close();
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
    }
}
