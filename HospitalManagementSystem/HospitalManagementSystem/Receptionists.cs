using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalManagementSystem
{
    public partial class Receptionists : Form
    {
        private int Key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\Andrei\Documents\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Receptionists()
        {
            InitializeComponent();
            DisplayRecep();
        }

        private void Receptionists_Load(object sender, EventArgs e)
        {

        }

        private void DisplayRecep()
        {
            Con.Open();
            string Query = "select * from Receptionists";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReceptionistDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void AddBttn_Click(object sender, EventArgs e)
        {
            if (RecepName.Text == "" || RecepPhone.Text == "" || RecepAddress.Text == "" || RecepPassword.Text == "" || RecepCovidTest.SelectedIndex == -1)
            {
                MessageBox.Show("Lipsa informatii");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Receptionists(ReceptionistName, ReceptionistPhone, ReceptionistPassword, ReceptionistCovidTest, ReceptionistAddress)"
                                                                     + "values(@RNM, @RPH, @RPS, @RCV, @RAD)", Con);
                    cmd.Parameters.AddWithValue("@RNM", RecepName.Text);
                    cmd.Parameters.AddWithValue("@RPH", RecepPhone.Text);
                    cmd.Parameters.AddWithValue("@RPS", RecepPassword.Text);
                    cmd.Parameters.AddWithValue("@RCV", RecepCovidTest.Text);
                    cmd.Parameters.AddWithValue("@RAD", RecepAddress.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    DisplayRecep();
                    Clear();
                    MessageBox.Show("Receptionist adaugat");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update Receptionists set ReceptionistName = @RNM," +
                                                                            "ReceptionistPhone = @RPH," +
                                                                            "ReceptionistPassword = @RPS," +
                                                                            "ReceptionistCovidTest = @RCV," +
                                                                            "ReceptionistAddress = @RAD" +
                                                                            " where ReceptionistId = @RID", Con);
                cmd.Parameters.AddWithValue("@RNM", RecepName.Text);
                cmd.Parameters.AddWithValue("@RPH", RecepPhone.Text);
                cmd.Parameters.AddWithValue("@RPS", RecepPassword.Text);
                cmd.Parameters.AddWithValue("@RCV", RecepCovidTest.Text);
                cmd.Parameters.AddWithValue("@RAD", RecepAddress.Text);
                cmd.Parameters.AddWithValue("@RID", Key);
                cmd.ExecuteNonQuery();
                Con.Close();

                DisplayRecep();
                Clear();
                MessageBox.Show("Receptionist actualizat!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteBttn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("delete from Receptionists where ReceptionistId=@RID", Con);
                    cmd.Parameters.AddWithValue("@RID", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    DisplayRecep();
                    Clear();
                    MessageBox.Show("Receptionist sters!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ReceptionistDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                Key = Convert.ToInt32(ReceptionistDGV.Rows[e.RowIndex].Cells[0].Value);

                RecepName.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                RecepPhone.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                RecepPassword.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                RecepCovidTest.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                RecepAddress.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void Clear()
        {
            RecepName.Text = "";
            RecepPhone.Text = "";
            RecepPassword.Text = "";
            RecepCovidTest.Text = "";
            RecepAddress.Text = "";
            Key = 0;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
