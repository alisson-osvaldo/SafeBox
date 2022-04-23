﻿using System;
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
        private static  string connectionstring;
        //private static string connectionstringStatic;

        public User()
        {
            connectionstring = ConfigurationManager.AppSettings["SqlConnection"];
        }

        
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

        //Validação Login
        public bool Login(string username,string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string queryString = "SELECT * FROM registers WHERE username = '" + username + "' AND password = '" + password + "' ";

                SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

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

                //var result = command.ExecuteScalar(); //verifica apenas 1 coluna

            }
        }

        public static void UpdateUser(int Id, string Password, string newUserName, string newPassword)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE registers SET username = @username, password = @newPassword WHERE id = @id and password = @password";

                    command.Parameters.AddWithValue("@username", newUserName);
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@password", Password);
                    command.Parameters.AddWithValue("@id", Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Conta Alterado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void DeleteUser(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM registers WHERE id = @id";

                command.Parameters.AddWithValue("@id", Id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Conta Deletada com sucesso");
            }
        }

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
