﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ZD36
{
    internal class database
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data source=Ђђ’…Њ\EKZ3; Initial Catalog=Gallery; integrated security = true ");// подключение к каталогу и бд

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)      
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
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

        internal object FillComboBox(string v1, string v2, ComboBox st_otpr)
        {
            throw new NotImplementedException();
        }
    }
}
