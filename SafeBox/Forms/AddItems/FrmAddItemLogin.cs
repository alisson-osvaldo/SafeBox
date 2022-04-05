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

namespace SafeBox.Forms.AddItems
{
    public partial class FrmAddItemLogin : Form
    {
        public FrmAddItemLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            var item = new Item();
            item.Id = 0; //teste para salvar no bd
            item.Name = txbItemNome.Text;
            item.UserName = txbItemUserName.Text;
            item.Password = txbItemPassword.Text;
            item.URL = txbItemURL.Text;
            item.Note = txbItemNote.Text;
            if (txbItemNome.Text.Length == 0 || txbItemUserName.Text.Length == 0 || txbItemPassword.Text.Length == 0)
            {
                MessageBox.Show("Por favor preencha todos os campos (Name, Username, Password)");
            }
            else
            {
                item.Gravar();
                Close();
            }
        }
    }
}
