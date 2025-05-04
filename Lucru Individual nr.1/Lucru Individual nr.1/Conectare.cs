using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucru_Individual_nr._1
{
    internal class Conectare
    {
        SqlConnection connection;

        public Conectare()
        {
            //this.connection = new SqlConnection("Data Source=COZMA\\SQLEXPRESS;Initial Catalog=db_ultra;Integrated Security=True");
            this.connection = new SqlConnection("Server=COZMA\\SQLEXPRESS;Database=db_ultra;Integrated Security=True;");
        }

        public SqlConnection openConnection()
        {
            try
            {
                connection.Open();
            }
            catch(Exception e)
            {
            }

            return connection;
        }

        public SqlConnection closeConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
            }
            return connection;
        }
    }
}
