using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caqui.DAL
{
    internal class UtilsDAL
    {
        public static MySqlConnection GetConnection()
        {
            //Criar um obj builder com os dados da conexão
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "cad_usuarios",
                UserID = "root",
                Password =  ""
            };

            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            conn.Open();

            return conn;
        }
    }
}
