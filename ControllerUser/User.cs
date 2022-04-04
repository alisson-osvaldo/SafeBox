using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //Para retornar o nome na ComboBox
        public override string ToString()
        {
            return this.UserName;
        }

        public void Gravar()
        {
            new Database.User().Gravar(this.UserName, this.Password);
        }

        public bool ValidacaoLogin()
        {
            bool log = new Database.User().Login(this.UserName, this.Password);
            return log;
        }


        //Lista de todos
        public static List<User> Todos()
        {
            var list = new List<User>();
            var table = new Database.User().Todos();
            if (table.Rows.Count > 0)
            {
                foreach(DataRow row in table.Rows)
                {
                    list.Add(new User()
                    {
                        UserName = row["username"].ToString(),  
                    });
                }   
            }
            return list;
        }
    }
}
