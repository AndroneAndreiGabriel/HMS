using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class LabTests : Form
    {
        private int Key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\Andrei\Documents\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");

        public LabTests()
        {
            InitializeComponent();
            DisplayTests();
        }

        private void DisplayTests()
        {
            Con.Open();
            string Query = "select * from Tests";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TestsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Clear()
        {
            TestName.Text = "";
            TestCost.Text = "";
            Key = 0;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TestsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                Key = Convert.ToInt32(TestsDGV.Rows[e.RowIndex].Cells[0].Value);

                TestName.Text = TestsDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                TestCost.Text = TestsDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void AddTest_Click(object sender, EventArgs e)
        {
            if (TestName.Text == "" ||
                TestCost.Text == "")
            {
                MessageBox.Show("Lipsa informatii. Toate campurile sunt obligatorii!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Tests(TestName, TestCost) values(@TNM, @TPR)", Con);
                    cmd.Parameters.AddWithValue("@TNM", TestName.Text);
                    cmd.Parameters.AddWithValue("@TPR", TestCost.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    DisplayTests();
                    Clear();
                    MessageBox.Show("Test adaugat");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditTest_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update Tests set TestName = @TNM, TestCost = @TPR where TestId = @TID", Con);
                cmd.Parameters.AddWithValue("@TNM", TestName.Text);
                cmd.Parameters.AddWithValue("@TPR", TestCost.Text);
                cmd.Parameters.AddWithValue("@TID", Key);
                cmd.ExecuteNonQuery();
                Con.Close();

                DisplayTests();
                Clear();
                MessageBox.Show("Test modificat");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteTest_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("delete from Tests where TestId=@TID", Con);
                    cmd.Parameters.AddWithValue("@TID", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    DisplayTests();
                    Clear();
                    MessageBox.Show("Test sters!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
