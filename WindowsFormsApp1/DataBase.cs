using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = MSI\SQLEXPRESS; initial Catalog = test; Integrated Security = True");


        public void openConnection()
        { 
        if(sqlConnection.State == System.Data.ConnectionState.Closed)
            sqlConnection.Open();
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {

                sqlConnection.Close();


            }
        }
            public SqlConnection getConnection()

            {

                return sqlConnection;

            }

    }
}

