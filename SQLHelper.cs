using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeoulHacks2020Application
{
    public class SQLHelper
    {
        private static string connectionToSQL = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\SeoulHacks2020Application - Copy\SeoulHacks2020Application\UserInformation.mdf;Integrated Security = True; Connect Timeout = 30";

        private static SqlConnection sqlConnection = new SqlConnection();

        private static SqlCommand sqlCommand = new SqlCommand();

        public SqlConnection SqlConnection { get => sqlConnection; set => sqlConnection = SqlConnection; }

        public SqlCommand SqlCommand { get => sqlCommand; set => sqlCommand = SqlCommand; }

        public string ConnectionSQLString {get => connectionToSQL; set => ConnectionSQLString = connectionToSQL;}

        public void ConnectToSQLDatabase()
        {
            sqlConnection = new SqlConnection(connectionToSQL);
        }
    }
}
