using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        public int Gravar(int idUser, string name, string username, string password, string url, string note, string type)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    string queryString = "INSERT INTO items(iduser, name, username, password, url, note, type) " +
                        "VALUES('" + idUser + "', '" + name + "', '" + username + "', '" + password + "', '" + url + "', '" + note + "', '" + type + "') ";

                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();  
                    connection.Close();
                    MessageBox.Show("Item cadastro com sucesso");


                    int idReturn = returnMaxId(0);
                    return idReturn;
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return -1;
            }
        }

        public static int returnMaxId(int result)
        {
            using (SqlConnection connection = new SqlConnection(connectionstringStatic))
            {
                string queryString = "SELECT IDENT_CURRENT('dbo.items');";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read() & !reader.IsDBNull(0))
                {
                    return result = Convert.ToInt32(reader[0]);
                }              
            }
            return result;
        }

        public DataTable All()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string queryString = "SELECT * FROM items";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public DataTable Todos(int idUser)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string queryString = "SELECT * FROM items WHERE iduser = '"+ idUser +"' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(); //Esse cara vai pegar nossa requisição(registro) no bd
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public DataTable SearchItemType(string type, int idUser)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string queryString = "SELECT * FROM items WHERE type = '" + type + "' AND  iduser = '" + idUser + "' ";
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
        // Search---------------------------------------------------------------------------------------------------------
        public DataTable SearchList(string name, string type, int idUser)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {               
                string queryString = "SELECT * FROM items WHERE iduser = '" + idUser + "' AND type = '" + type +"' AND name LIKE '%"+ name +"%' "; 
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public DataTable SearchListAll(string name, int idUser)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string queryString = "SELECT * FROM items WHERE iduser = '" + idUser + "' AND name LIKE '%" + name + "%' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        //-----------------------------------------------------------------------------------------------------------------
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
            }
            catch (Exception ex)
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

        public static void DeleteItemIdRegister(int IdUser)
        {
            using (SqlConnection connection = new SqlConnection(connectionstringStatic))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM items WHERE iduser = @iduser";

                command.Parameters.AddWithValue("@iduser", IdUser);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }


    }
}
