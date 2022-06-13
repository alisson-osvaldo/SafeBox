﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class Item
    {
        public int IdUser { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string URL { get; set; }
        public string Note { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

        public int Gravar()
        {
            int idReturn = new Database.Item().Gravar(this.IdUser, this.Name, this.UserName, this.Password, this.URL, this.Note, this.Type);
            return idReturn;
        }

        
        public static List<Item> Todos(int idUser)
        {
            var list = new List<Item>();
            var table = new Database.Item().Todos(idUser);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    list.Add(new Item()
                    {
                        Id = int.Parse(row["Id"].ToString()),
                        Name = row["Name"].ToString(),
                        UserName = row["username"].ToString(),
                        Password = row["password"].ToString(),
                        URL = row["url"].ToString(),
                        Note = row["note"].ToString(),
                        Type = row["type"].ToString(),
                    });
                }
            }
            return list;
        }

        public static List<Item> SearchItemLoginType(string type, int idUser)
        {
            var list = new List<Item>();
            var table = new Database.Item().SearchItemType(type, idUser);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    list.Add(new Item()
                    {
                        Id = int.Parse(row["Id"].ToString()),
                        Name = row["Name"].ToString(),
                        UserName = row["username"].ToString(),
                        Password = row["password"].ToString(),
                        URL = row["url"].ToString(),
                        Note = row["note"].ToString(),
                    });
                }
            }
            return list;
        }

        public static List<Item> SearchItemNoteType(string type, int idUser)
        {
            var list = new List<Item>();
            var table = new Database.Item().SearchItemType(type, idUser);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    list.Add(new Item()
                    {
                        Id = int.Parse(row["Id"].ToString()),
                        Name = row["Name"].ToString(),
                        URL = row["url"].ToString(),
                        Note = row["note"].ToString(),
                    });
                }
            }
            return list;
        }

        public static List<Item> SearchItemById(int id)
        {
            var list = new List<Item>();
            var tabela = new Database.Item().SearchItemById(id);
            if (tabela.Rows.Count > 0)
            {
                foreach (DataRow row in tabela.Rows)
                {
                    list.Add(new Item()
                    {
                        Id       = int.Parse(row["Id"].ToString()),
                        Name     = row["name"].ToString(),
                        UserName = row["username"].ToString(),
                        Password = row["password"].ToString(),   
                        URL      = row["url"].ToString(),
                        Note     = row["note"].ToString()
                    });
                }
            }
            return list;
        }

        public static List<Item> ListAll()
        {
            var list = new List<Item>();
            var tabela = new Database.Item().All();
            if (tabela.Rows.Count > 0)
            {
                foreach (DataRow row in tabela.Rows)
                {
                    list.Add(new Item()
                    {
                        Id = int.Parse(row["Id"].ToString()),
                        Name = row["name"].ToString(),
                        UserName = row["username"].ToString(),
                        Password = row["password"].ToString(),
                        URL = row["url"].ToString(),
                        Note = row["note"].ToString()
                    });
                }
            }
            return list;
        }

        public static void SearchItemByNameAll(string name)
        {

            //Console.WriteLine("\nFind: Part where name contains \"seat\": {0}",
            //parts.Find(x => x.PartName.Contains("seat")));

            Console.WriteLine("\nFind: Parte onde o nome contém " + name + ": {0}",
             ListAll().Find(search =>  search.Name.Contains(name))); //quando buscar esse nome retornar id 

            var All = ListAll();
            Console.WriteLine(All);
            Console.WriteLine();
        }


    }
}
