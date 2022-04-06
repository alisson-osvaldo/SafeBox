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

        public void Gravar(int id, string name, string username, string password, string url, string note, string type)
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
/*
 - Relacionar (Item) com o id do Usuario (register) !!Id do User está salvo em uma variavel no login!!
 - Adicionar o valor do ComboBox no type, tipodanota salva.

*/