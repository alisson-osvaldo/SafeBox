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
    public class User
    {
        private string connectionstring;

        public User()
        {
            connectionstring = ConfigurationManager.AppSettings["SqlConnection"];
        }

        //Ok
        public void Gravar(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    string queryString = "INSERT INTO registers(username, password) VALUES('" + username + "', '" + password + "')";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cadastro feito com sucesso");
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Nome de usuário já cadastrado! tente outro. ");
            }
        }

        // não funcional
        public bool Login(string username,string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string queryString = "SELECT * FROM registers WHERE username = '" + username + "' AND password = '" + password + "' ";

                SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                //var result = command.ExecuteScalar(); //verifica apenas 1 coluna
               
            }
        }

        //Ok
        public DataTable Todos()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string queryString = "SELECT * FROM registers";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(); //Esse cara vai pegar nossa requisição(registro) no bd
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

    }
}
