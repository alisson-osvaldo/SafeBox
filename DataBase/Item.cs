using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public class Item
    {
        private string connectionstring;

        public Item()
        {
            connectionstring = ConfigurationManager.AppSettings["SqlConnection"];
        }

        public void Gravar(int id, string name, string username, string password, string url, string note)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    string queryString = "INSERT INTO items(id, name, username, password, url, note) VALUES('" + id + "', '" + name + "', '" + username + "', '" + password + "', '" + url + "', '" + note + "')";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Item cadastro com sucesso");
                }
            }catch (Exception ex) {
                MessageBox.Show("Error: " + ex);
            }
        }


    }
}
