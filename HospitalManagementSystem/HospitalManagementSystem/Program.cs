using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static SqlConnection CreateOpenConnection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\Andrei\Documents\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();
            return connection;
        }
    }
}
