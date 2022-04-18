using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        private static string connectionstringStatic;

        public Item()
        {
            connectionstring = ConfigurationManager.AppSettings["SqlConnection"];
            connectionstringStatic = ConfigurationManager.AppSettings["SqlConnection"];
        }

        public void Gravar(int idUser, string name, string username, string password, string url, string note, string type)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    string queryString = "INSERT INTO items(iduser, name, username, password, url, note, type) VALUES('" + idUser + "', '" + name + "', '" + username + "', '" + password + "', '" + url + "', '" + note + "', '" + type + "')";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Item cadastro com sucesso");
                }
            }catch (Exception ex) {
                MessageBox.Show("Error: " + ex);
            }
        }

        public DataTable SearchItemType(string type)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string queryString = "SELECT * FROM items WHERE type = '" + type + "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(); //Esse cara vai pegar nossa requisição(registro) no bd
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public DataTable SearchItemById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string queryString = "SELECT * FROM items WHERE id ='" + id + "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(); 
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }
       
        public static void UpdateItem(int Id, string Name, string UserName, string Password, string URL, string Note)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstringStatic))
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE items SET name = @name, username = @username, password = @password, url = @url, note = @note WHERE id = @id";

                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@username", UserName);
                    command.Parameters.AddWithValue("@password", Password);
                    command.Parameters.AddWithValue("@url", URL);
                    command.Parameters.AddWithValue("@note", Note);
                    command.Parameters.AddWithValue("@id", Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Item Alterado com sucesso");
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void DeleteItem(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionstringStatic))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM items WHERE id = @id";

                command.Parameters.AddWithValue("@id", Id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Item Deletado com sucesso");
            }
        }


    }
}
