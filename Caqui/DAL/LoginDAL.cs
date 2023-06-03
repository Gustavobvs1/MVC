using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caqui.DTO;
using MySqlConnector;

namespace Caqui.DAL
{
    internal class LoginDAL
    {
        public bool GetLoginDAL(LoginDTO loginDTO)
        {
            if(loginDTO.Email == "admin@admin.com" && loginDTO.Senha == "1234") { return true; }
            return false;
            /*
            MySqlConnection conn = UtilsDAL.GetConnection();

            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    string query = $"SELECT * FROM usuarios WHERE " +
                                   $"email = '{loginDTO.Email}'" +
                                   $"AND senha = '{loginDTO.Senha}'";

                    MySqlCommand querySelector = new MySqlCommand(query,conn);
                    MySqlDataReader reader = querySelector.ExecuteReader();

                    if (reader.Read()) {
                        conn.Close();
                        return true;
                    }
                }
            }
            catch(Exception ex) 
            {
                conn.Close();
                MessageBox.Show("Erro ao logar..." + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;*/
        }
    }
}
