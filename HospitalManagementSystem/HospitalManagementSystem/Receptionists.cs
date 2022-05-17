using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalManagementSystem
{    
    public partial class Receptionists : Form
    {
        int Key = 0;

        public Receptionists()
        {
            InitializeComponent();
            DisplayRec();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\Andrei\Documents\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void Receptionists_Load(object sender, EventArgs e)
        {

        }

        private void DisplayRec()
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
            if (RecepNameTb.Text == "" || RecepPhoneTb.Text == "" || RecepAddressTb.Text == "" || RecepPassTb.Text == "" || RecepCovidTb.Text == "")
            {
                MessageBox.Show("Lipsa informatii");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Receptionists(ReceptionistName, ReceptionistPhone, ReceptionistAddress, ReceptionistPassword, ReceptionistCovidTest)"
                                                                     + "values(@RNM, @RPH, @RAD, @RPS, @RCV)", Con);
                    cmd.Parameters.AddWithValue("@RNM", RecepNameTb.Text);
                    cmd.Parameters.AddWithValue("@RPH", RecepPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RAD", RecepAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RPS", RecepPassTb.Text);
                    cmd.Parameters.AddWithValue("@RCV", RecepCovidTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist adaugat");
                    Con.Close();
                    DisplayRec();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBttn_Click(object sender, EventArgs e)
        {
            /*if (RecepNameTb.Text == "" || RecepPhoneTb.Text == "" || RecepAddressTb.Text == "" || RecepPassTb.Text == "" || RecepCovidTb.Text == "")
            {
                MessageBox.Show("Lipsa informatii");
            }
            else*/
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update Receptionists set ReceptionistName = @RNM," +
                                                                             "ReceptionistPhone = @RPH," +
                                                                             "ReceptionistAddress = @RAD," +
                                                                             "ReceptionistPassword = @RPS," +
                                                                             "ReceptionistCovidTest = @RCV " +
                                                    "where ReceptionistId=@RID", Con);
                    cmd.Parameters.AddWithValue("@RNM", RecepNameTb.Text);
                    cmd.Parameters.AddWithValue("@RPH", RecepPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RAD", RecepAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RPS", RecepPassTb.Text);
                    cmd.Parameters.AddWithValue("@RCV", RecepCovidTb.Text);
                    cmd.Parameters.AddWithValue("@RID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist actualizat!");
                    Con.Close();
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                    MessageBox.Show("Receptionist sters!");
                    Con.Close();
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // todo
        private void ReceptionistDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            
            RecepNameTb.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            RecepPhoneTb.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            RecepAddressTb.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            RecepPassTb.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            RecepCovidTb.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[5].Value.ToString();

            if (RecepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(RecepNameTb.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}
