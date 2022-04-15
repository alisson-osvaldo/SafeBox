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
            
            //GetItem SqlServer
            var id = int.Parse(idItem.ToString());
            var t = Item.SearchItemById(id); //List<>
            string name     = t[0].Name;
            string username = t[0].UserName;
            string password = t[0].Password;
            string url      = t[0].URL;
            string note     = t[0].Note;

            txtName.Text     = name;
            txtUserName.Text = username;
            txtPassword.Text = password;
            if (url == "")
            {
                lblURL.Visible = false;
                txtURL.Visible = false;
            }if(note == "")
            {
                lblNote.Visible = false;
                txtNote.Visible = false;
            }
            else
            {
                txtURL.Text = url;
                txtNote.Text = note;
            }
            
            //var tt = Database.Item.Teste(id); //Datatable
            //Item.SearchItemById(id);
        }

        private void FrmItemLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
