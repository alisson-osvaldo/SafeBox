using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Database
{
    public class Item
    {
        private string connectionstring;
        private static string connectionstringStatic;

        private const string ConnectionString = "Data Source= D:\\Save Projects\\Estudo CSharp POO\\SafeBox\\SafeBox\\bin\\Debug\\SQLite\\bd_SafeBox.db";

        public Item()
        {
            connectionstring = ConfigurationManager.AppSettings["SqlConnection"];
            connectionstringStatic = ConfigurationManager.AppSettings["SqlConnection"];
        }

        public int Gravar(int idUser, string name, string username, string password, string url, string note, string type)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    string queryString = "INSERT INTO tb_items(iduser, name, username, password, url, note, type) " +
                        "VALUES('" + idUser + "', '" + name + "', '" + username + "', '" + password + "', '" + url + "', '" + note + "', '" + type + "') ";

                    SQLiteCommand command = new SQLiteCommand(queryString, connection);
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
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString)) //Aqui era static
            {
                string queryString = "SELECT MAX(id) FROM tb_items;";

                SQLiteCommand command = new SQLiteCommand(queryString, connection);
                command.Connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.Read() & !reader.IsDBNull(0))
                {
                    return result = Convert.ToInt32(reader[0]);
                }

                connection.Close();
            }
            return result;
        }

        public DataTable All()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                string queryString = "SELECT * FROM tb_items";
                SQLiteCommand command = new SQLiteCommand(queryString, connection);
                command.Connection.Open();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                connection.Close();

                return table;
            }
        }

        public DataTable Todos(int idUser)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                string queryString = "SELECT * FROM tb_items WHERE iduser = '"+ idUser +"' ";
                SQLiteCommand command = new SQLiteCommand(queryString, connection);
                command.Connection.Open();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(); //Esse cara vai pegar nossa requisição(registro) no bd
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                connection.Close();

                return table;
            }
        }

        public DataTable SearchItemType(string type, int idUser)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                string queryString = "SELECT * FROM tb_items WHERE type = '" + type + "' AND  iduser = '" + idUser + "' ";
                SQLiteCommand command = new SQLiteCommand(queryString, connection);
                command.Connection.Open();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(); //Esse cara vai pegar nossa requisição(registro) no bd
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                connection.Close();

                return table;
            }
        }

        public DataTable SearchItemById(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                string queryString = "SELECT * FROM tb_items WHERE id ='" + id + "' ";
                SQLiteCommand command = new SQLiteCommand(queryString, connection);
                command.Connection.Open();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                connection.Close();

                return table;
            }
        }
        // Search---------------------------------------------------------------------------------------------------------
        public DataTable SearchList(string name, string type, int idUser)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {               
                string queryString = "SELECT * FROM tb_items WHERE iduser = '" + idUser + "' AND type = '" + type +"' AND name LIKE '%"+ name +"%' ";
                SQLiteCommand command = new SQLiteCommand(queryString, connection);
                command.Connection.Open();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                connection.Close();

                return table;
            }
        }

        public DataTable SearchListAll(string name, int idUser)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                string queryString = "SELECT * FROM tb_items WHERE iduser = '" + idUser + "' AND name LIKE '%" + name + "%' ";
                SQLiteCommand command = new SQLiteCommand(queryString, connection);
                command.Connection.Open();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                connection.Close();

                return table;
            }
        }

        //-----------------------------------------------------------------------------------------------------------------
        public static void UpdateItem(int Id, string Name, string UserName, string Password, string URL, string note)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE tb_items SET name = @name, username = @username, password = @password, url = @url, note = @note WHERE id = @id";

                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@username", UserName);
                    command.Parameters.AddWithValue("@password", Password);
                    command.Parameters.AddWithValue("@url", URL);
                    command.Parameters.AddWithValue("@note", note);
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
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM tb_items WHERE id = @id";

                command.Parameters.AddWithValue("@id", Id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Item Deletado com sucesso");
            }
        }

        public static void DeleteItemIdRegister(int IdUser)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM tb_items WHERE iduser = @iduser";

                command.Parameters.AddWithValue("@iduser", IdUser);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }


    }
}
