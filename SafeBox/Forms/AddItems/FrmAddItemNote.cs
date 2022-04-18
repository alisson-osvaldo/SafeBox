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
    public partial class FrmAddItemNote : Form
    {
        public string type = "Note";
        public string windows = "AddItemNote";

        public FrmAddItemNote()
        {
            FrmMain.LogicPanelButtons(windows);
            InitializeComponent();           
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            var item = new Item();
            item.Name = txbName.Text;
            item.Note = txbNote.Text;
            item.Type = type;
            if (txbName.Text.Length == 0 || txbNote.Text.Length == 0 )
            {
                MessageBox.Show("Por favor preencha todos os campos (Name, Note)");
            }
            else
            {
                item.Gravar();
                Close();

                FrmMain.CloseFormPanelList();
                FrmMain.OpenFormPanelList(type);
            }           
        }

        private void FrmAddItemNote_Load(object sender, EventArgs e)
        {

        }
    }
}
