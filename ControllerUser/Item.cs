using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Item
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string URL { get; set; }
        public string Note { get; set; }
        public string Type { get; set; }

        public void Gravar()
        {
            new Database.Item().Gravar(this.IdUser, this.Name, this.UserName, this.Password, this.URL, this.Note, this.Type);
        }

        //Lista de todos
        /*
        public static List<User> Todos()
        {
            var list = new List<User>();
            var table = new Database.Item().Todos();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    list.Add(new Item()
                    {
                        UserName = row["username"].ToString(),
                    });
                }
            }
            return list;
        }
        */


    }
}
