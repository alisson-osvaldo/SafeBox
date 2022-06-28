using System;
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

        //Lista todos 
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


        

        //Essa cara vai ser usado apenas pelo Searche ???
        public static List<Item> ListAll()
        {
            var list = new List<Item>();
            var tabela = new Database.Item().All();
            if (tabela.Rows.Count > 0)
            {
                //Foreach para add
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

                //Foreach para filtrar por name (Modelo 1)
                /*var All = ListAll();

                foreach (var item in All)
                {
                    if (item.Name.Contains())
                    {
                        var idItem = item.Id;
                        SearchItemById(item.Id);
                        Console.WriteLine(item.Id);
                    }

                }*/

            }
            return list;
        }

        // Search---------------------------------------------------------------------------------

        public static List<Item> SearchList(string name, string type, int idUser)
        {
            var list = new List<Item>();
            var tabela = new Database.Item().SearchList(name, type, idUser);
            if (tabela.Rows.Count > 0)
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
            return list;
        }

        public static List<Item> SearchListAll(string name, int idUser)
        {
            var list = new List<Item>();
            var tabela = new Database.Item().SearchListAll(name, idUser);
            if (tabela.Rows.Count > 0)
                foreach (DataRow row in tabela.Rows)
                {
                    list.Add(new Item()
                    {
                        Id = int.Parse(row["Id"].ToString()),
                        Name = row["name"].ToString(),
                        UserName = row["username"].ToString(),
                        Password = row["password"].ToString(),
                        URL = row["url"].ToString(),
                        Note = row["note"].ToString(),
                        Type = row["type"].ToString()
                    });
                }
            return list;
        }

        //-----------------------------------------------------------------------------------------


        //Modelo de busca apartir de uma LIST aqui (Modelo 1)
        /*public static void SearchItemByNameAll(string name)
        {
            Console.WriteLine("\nFind: Parte onde o nome contém " + name + ": {0}",
            ListAll().Find(search => search.Name.Contains(name))); //quando buscar esse nome retornar id 
            //int t = ListAll().Find);


            var All = ListAll();

            foreach (var item in All)
            {
                if (item.Name.Contains(name))
                {
                    var idItem = item.Id;
                    SearchItemById(item.Id);
                    Console.WriteLine(item.Id);
                }
        
            }

         }*/



    }
}
