using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace SafeBox.Forms.SelectedItems
{
    public partial class FrmItemLogin : Form
    {
        public FrmItemLogin(object idItem)
        {
            InitializeComponent();
         
            var id = int.Parse(idItem.ToString());
            var t = Item.SearchItemById(id);
            var tt = Database.Item.Teste(id);
            
            
            


            //Item.SearchItemById(id);
        }

        private void FrmItemLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
