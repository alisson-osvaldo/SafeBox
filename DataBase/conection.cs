using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Database
{
    public class Connection
    {
        public SQLiteConnection conn = new SQLiteConnection("Data Source= D:\\Save Projects\\Estudo CSharp POO\\SafeBox\\SafeBox\\bin\\Debug\\SQLite\\bd_SafeBox.db");
   
        public void connect()
        {
            conn.Open();
        }

        public void disconnected()
        {
            conn.Close();
        }
    
    }
}
