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
    public class Item
    {
        private string connectionstring;
        private static string connectionstringTeste;

        public Item()
        {
            connectionstring = ConfigurationManager.AppSettings["SqlConnection"];
            connectionstringTeste = ConfigurationManager.AppSettings["SqlConnection"];
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

        public DataTable Todos()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                //string queryString = "SELECT * FROM items WHERE type ='" + type + "' ";
                string queryString = "SELECT * FROM items ";
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
        /*
        public static DataTable Teste(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionstringTeste))
            {
                string queryString = "SELECT * FROM items WHERE id ='" + id + "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(); //Esse cara vai pegar nossa requisição(registro) no bd
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }
        */

    }
}
