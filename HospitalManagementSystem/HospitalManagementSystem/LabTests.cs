using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class LabTests : Form
    {
        private int Key = 0;

        public LabTests()
        {
            InitializeComponent();
            DisplayTests();

            TestsDGV.ReadOnly = true;
            TestsDGV.AllowUserToAddRows = false;
        }

        private void DisplayTests()
        {
            using (var connection = Program.CreateOpenConnection())
            {
                string Query = "select * from Tests";
                SqlDataAdapter sda = new SqlDataAdapter(Query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                TestsDGV.DataSource = ds.Tables[0];
            }
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
                    using (var connection = Program.CreateOpenConnection())
                    {
                        SqlCommand cmd = new SqlCommand("insert into Tests(TestName, TestCost) values(@TNM, @TPR)", connection);
                        cmd.Parameters.AddWithValue("@TNM", TestName.Text);
                        cmd.Parameters.AddWithValue("@TPR", TestCost.Text);
                        cmd.ExecuteNonQuery();
                    }

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
                using (var connection = Program.CreateOpenConnection())
                {
                    SqlCommand cmd = new SqlCommand("update Tests set TestName = @TNM, TestCost = @TPR where TestId = @TID", connection);
                    cmd.Parameters.AddWithValue("@TNM", TestName.Text);
                    cmd.Parameters.AddWithValue("@TPR", TestCost.Text);
                    cmd.Parameters.AddWithValue("@TID", Key);
                    cmd.ExecuteNonQuery();
                }

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
                    using (var connection = Program.CreateOpenConnection())
                    {
                        SqlCommand cmd = new SqlCommand("delete from Tests where TestId=@TID", connection);
                        cmd.Parameters.AddWithValue("@TID", Key);
                        cmd.ExecuteNonQuery();
                    }

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

        private void TestsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
