using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Prescriptions : Form
    {
        int Key = 0;
        public Prescriptions()
        {
            InitializeComponent();
            DisplayPrescriptions();
            GetDoctorId();
            GetPatientId();
            GetTestId();
            Clear();

            PrescripDGV.ReadOnly = true;
            PrescripDGV.AllowUserToAddRows = false;
        }

        private void Prescriptions_Load(object sender, EventArgs e)
        {

        }

        private void DisplayPrescriptions()
        {
            using (var connection = Program.CreateOpenConnection())
            {
                string Query = "select * from Prescriptions";
                SqlDataAdapter sda = new SqlDataAdapter(Query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                PrescripDGV.DataSource = ds.Tables[0];
            }
        }

        private void GetDoctorId()
        {
            using (var connection = Program.CreateOpenConnection())
            {
                SqlCommand cmd = new SqlCommand("select DoctorId from Doctors", connection);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("DoctorId", typeof(int));
                dataTable.Load(reader);

                DoctorId.ValueMember = "DoctorId";
                DoctorId.DataSource = dataTable;
            }
        }
        private void GetDoctorName()
        {
            using (var connection = Program.CreateOpenConnection())
            {
                string Query = "select * from Doctors where DoctorId=" + DoctorId.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(Query, connection);
                DataTable dataTable = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dataTable);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    DoctorName.Text = dataRow["DoctorName"].ToString();
                }
            }
        }

        private void DoctorId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDoctorName();
        }

        private void GetPatientId()
        {
            using (var connection = Program.CreateOpenConnection())
            {
                SqlCommand cmd = new SqlCommand("select PatientId from Patients", connection);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("PatientId", typeof(int));
                dataTable.Load(reader);

                PatientId.ValueMember = "PatientId";
                PatientId.DataSource = dataTable;
            }
        }

        private void GetPatientName()
        {
            using (var connection = Program.CreateOpenConnection())
            {
                string Query = "select * from Patients where PatientId=" + PatientId.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(Query, connection);
                DataTable dataTable = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dataTable);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PatientName.Text = dataRow["PatientName"].ToString();
                }
            }
        }

        private void GetTestId()
        {
            using (var connection = Program.CreateOpenConnection())
            {
                SqlCommand cmd = new SqlCommand("select TestId from Tests", connection);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("TestId", typeof(int));
                dataTable.Load(reader);

                TestId.ValueMember = "TestId";
                TestId.DataSource = dataTable;
            }
        }

        private void GetTestName()
        {
            using (var connection = Program.CreateOpenConnection())
            {
                string Query = "select * from Tests where TestId=" + TestId.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(Query, connection);
                DataTable dataTable = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dataTable);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TestName.Text = dataRow["TestName"].ToString();
                    Cost.Text = dataRow["TestCost"].ToString();
                }
            }
        }

        private void Clear()
        {
            DoctorId.SelectedIndex = -1;
            PatientId.SelectedIndex = -1;
            TestId.SelectedIndex = -1;
            DoctorName.Text = "";
            PatientName.Text = "";
            TestName.Text = "";
            Cost.Text = "";
            Medicines.Text = "";
            Key = 0;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatientId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatientName();
        }

        private void TestId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTestName();
        }

        private void AddPrescrip_Click(object sender, EventArgs e)
        {
            if (DoctorName.Text == "" ||
                PatientName.Text == "" ||
                TestName.Text == "")
            {
                MessageBox.Show("Lipsa informatii.");
            }
            else
            {
                try
                {
                    using (var connection = Program.CreateOpenConnection())
                    {
                        SqlCommand cmd = new SqlCommand("insert into Prescriptions(DoctorId, DoctorName, PatientId, PatientName, LabTestId, LabTestName, Medicines, Cost)"
                                                                     + "values(@DID, @DNM, @PID, @PNM, @TID, @TNM, @MED, @CST)", connection);
                        cmd.Parameters.AddWithValue("@DID", DoctorId.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@DNM", DoctorName.Text);
                        cmd.Parameters.AddWithValue("@PID", PatientId.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@PNM", PatientName.Text);
                        cmd.Parameters.AddWithValue("@TID", TestId.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@TNM", TestName.Text);
                        cmd.Parameters.AddWithValue("@MED", Medicines.Text);
                        cmd.Parameters.AddWithValue("@CST", Cost.Text);
                        cmd.Parameters.AddWithValue("@PRID", Key);
                        cmd.ExecuteNonQuery();
                    }

                    DisplayPrescriptions();
                    Clear();
                    MessageBox.Show("Prescriptie modificata");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditPrescrip_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = Program.CreateOpenConnection())
                {
                    SqlCommand cmd = new SqlCommand("update Prescriptions set DoctorId = @DID, " +
                                                                         "DoctorName = @DNM, " +
                                                                         "PatientId = @PID, " +
                                                                         "PatientName = @PNM, " +
                                                                         "LabTestId = @TID, " +
                                                                         "LabTestName = @TNM, " +
                                                                         "Medicines = @MED, " +
                                                                         "Cost = @CST " +
                                                                  " where PrescriptionId = @PRID", connection);
                    cmd.Parameters.AddWithValue("@DID", DoctorId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DNM", DoctorName.Text);
                    cmd.Parameters.AddWithValue("@PID", PatientId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PNM", PatientName.Text);
                    cmd.Parameters.AddWithValue("@TID", TestId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TNM", TestName.Text);
                    cmd.Parameters.AddWithValue("@MED", Medicines.Text);
                    cmd.Parameters.AddWithValue("@CST", Cost.Text);
                    cmd.Parameters.AddWithValue("@PRID", Key);
                    cmd.ExecuteNonQuery();
                }

                DisplayPrescriptions();
                Clear();
                MessageBox.Show("Prescriptie modificata");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeletePrescrip_Click(object sender, EventArgs e)
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
                        SqlCommand cmd = new SqlCommand("delete from Prescriptions where PrescriptionId=@PRID", connection);
                        cmd.Parameters.AddWithValue("@PRID", Key);
                        cmd.ExecuteNonQuery();
                    }

                    DisplayPrescriptions();
                    Clear();
                    MessageBox.Show("Prescriptie stearsa!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void PrescripDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                Key = Convert.ToInt32(PrescripDGV.Rows[e.RowIndex].Cells[0].Value);

                DoctorId.Text = PrescripDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                DoctorName.Text = PrescripDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                PatientId.Text = PrescripDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                PatientName.Text = PrescripDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                TestId.Text = PrescripDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                TestName.Text = PrescripDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
                Medicines.Text = PrescripDGV.Rows[e.RowIndex].Cells[7].Value.ToString();
                Cost.Text = PrescripDGV.Rows[e.RowIndex].Cells[8].Value.ToString();

                PrescriptionTxt.Text = "                                 \n\n" +
                "******************PRESCRIPTIE******************" + "\n\n\n" +
                "Eliberata la: " + DateTime.Today + "\n\n\n\n" +
                "Doctor: " + PrescripDGV.Rows[e.RowIndex].Cells[2].Value.ToString() + "\n\n\n" +
                "Patient: " + PrescripDGV.Rows[e.RowIndex].Cells[4].Value.ToString() + "\n\n\n" +
                "Test: " + PrescripDGV.Rows[e.RowIndex].Cells[6].Value.ToString() + "\n\n\n" +
                "Medicamente: " + PrescripDGV.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void PrintPrescrip_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(PrescriptionTxt.Text + "\n", new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new Point(95, 80));
            e.Graphics.DrawString("\n\t" + "Semnatura si parafa", new Font("Times New Roman", 15, FontStyle.Regular), Brushes.Red, new Point(100, 800));
        }

        private void ReturnHomeLbl_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Hide();
        }

        private void ReturnHomeImg_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Hide();
        }
    }
       
}
