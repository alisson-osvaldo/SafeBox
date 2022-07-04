using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;


namespace Database
{
    public class User
    {
        private const string connectionstring = "Data Source= D:\\Save Projects\\Estudo CSharp POO\\SafeBox\\SafeBox\\bin\\Debug\\SQLite\\bd_SafeBox.db";       
        
        public void Gravar(string username, string password)
        {        
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionstring))
                {
                    string queryString = "INSERT INTO tb_users(username, password) VALUES('" + username + "', '" + password + "')";
                    SQLiteCommand command = new SQLiteCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Cadastro feito com sucesso\nAgora é só entrar utilizando sua senha.");                  
                }               
            }
            catch (SqlException)
            {
                MessageBox.Show("Nome de usuário já cadastrado! tente outro. ");
            }
        }

        //Validação Login
        public bool Login(string username,string password)
        {         
            using (SQLiteConnection connection = new SQLiteConnection(connectionstring))
            {
                string queryString = "SELECT * FROM tb_users WHERE username = '" + username + "' AND password = '" + password + "' ";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(queryString, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                foreach (DataRow tb in table.Rows)
                {
                    string idUser = tb["id"].ToString();
                }

                if (table.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }           
        }

        public static void UpdateUser(int Id, string newUserName, string newPassword)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionstring))
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE tb_users SET username = @username, password = @newPassword WHERE id = @id ";

                    command.Parameters.AddWithValue("@username", newUserName);
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@id", Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
            
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Validar senha atual
        public static bool validationPassword( int id, string password )
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionstring))
            {
                string queryString = "SELECT * FROM tb_users WHERE id = '" + id + "' AND password = '" + password + "' ";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(queryString, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                if (table.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
                
        }
        
        //Validar nova senha
        public bool validationNewPassword()
        {
            return true;
        }

        public static void DeleteUser(int Id)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionstring))
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM tb_users WHERE id = @id";

                    command.Parameters.AddWithValue("@id", Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Conta Deletada com sucesso");
                }
                Item.DeleteItemIdRegister(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }         
        }

        public DataTable Todos()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionstring))
                {
                    string queryString = "SELECT * FROM tb_users";
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            
        }

        

    }
}
