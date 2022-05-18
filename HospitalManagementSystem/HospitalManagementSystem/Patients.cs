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
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\Andrei\Documents\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Patients()
        {
            InitializeComponent();
            DisplayPatients();
        }
       
        private void Patients_Load(object sender, EventArgs e)
        {

        }

        private void DisplayPatients()
        {
            Con.Open();
            string Query = "select * from Patients";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientsDGV.DataSource = ds.Tables[0];
            Con.Close();
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
                PatientCovidTest.SelectedIndex == -1)
            {
                MessageBox.Show("Lipsa informatii. Toate campurile sunt obligatorii!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Patients(PatientName, PatientGender, PatientDOB, PatientPhone, PatientAddress, PatientAllergies, PatientCovidTest)"
                                                                     + "values(@PNM, @PGN, @PDB, @PPH, @PAD, @PAL, @PCV)", Con);
                    cmd.Parameters.AddWithValue("@PNM", PatientName.Text);
                    cmd.Parameters.AddWithValue("@PGN", PatientGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PDB", PatientDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PPH", PatientPhone.Text);
                    cmd.Parameters.AddWithValue("@PAD", PatientAddress.Text);
                    cmd.Parameters.AddWithValue("@PAL", PatientAllergies.Text);
                    cmd.Parameters.AddWithValue("@PCV", PatientCovidTest.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    Con.Close();

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
                Con.Open();
                SqlCommand cmd = new SqlCommand("update Patients set PatientName = @PNM," +
                                                                    "PatientGender = @PGN," +
                                                                    "PatientDOB = @PDB," +
                                                                    "PatientPhone = @PPH," +
                                                                    "PatientAddress = @PAD," +
                                                                    "PatientAllergies = @PAL," +
                                                                    "PatientCovidTest = @PCV" +
                                                                    " where PatientId = @PID", Con);
                cmd.Parameters.AddWithValue("@PNM", PatientName.Text);
                cmd.Parameters.AddWithValue("@PGN", PatientGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PDB", PatientDOB.Value.Date);
                cmd.Parameters.AddWithValue("@PPH", PatientPhone.Text);
                cmd.Parameters.AddWithValue("@PAD", PatientAddress.Text);
                cmd.Parameters.AddWithValue("@PAL", PatientAllergies.Text);
                cmd.Parameters.AddWithValue("@PCV", PatientCovidTest.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PID", Key);
                cmd.ExecuteNonQuery();
                Con.Close();

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
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Patients where PatientId=@PID", Con);
                    cmd.Parameters.AddWithValue("@PID", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();

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

        private void PatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            }
        }
    }
}
