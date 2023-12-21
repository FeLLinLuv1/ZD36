using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ZD36
{
    internal class database
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data source=Ђђ’…Њ\SQLEXPRESS; Initial Catalog=ZD36; integrated security = true ");/// подключение к каталогу и бд

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
    }
}
