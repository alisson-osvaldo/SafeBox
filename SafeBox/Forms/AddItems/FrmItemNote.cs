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
    public partial class FrmItemNote : Form
    {
        public FrmItemNote()
        {
            InitializeComponent();
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            var item = new Item();
            item.Id = 0; //teste para salvar no bd
            item.Name = txbName.Text;
            item.URL = txbItemURL.Text;
            item.Note = txbNote.Text;
            if (txbName.Text.Length == 0 || txbNote.Text.Length == 0 )
            {
                MessageBox.Show("Por favor preencha todos os campos (Name, Note)");
            }
            else
            {
                item.Gravar();
                Close();
            }
        }
    }
}
