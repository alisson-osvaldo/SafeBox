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
using SafeBox.Forms.ListItems;
using SafeBox.Forms.SelectedItems;

namespace SafeBox.Forms.AddItems
{
    public partial class FrmAddItemNote : Form
    {
        public static string type = "Note";
        public static string windows = "AddItemNote";

        public FrmAddItemNote()
        {
            FrmMain.LogicPanelButtons(windows);
            FrmMain.ReturnType(windows);
            InitializeComponent();           
        }

        public static void BtnSaveAddItemLogin()
        {
            var item = new Item();
            item.Name = txbName.Text;
            item.Note = txbNote.Text;
            item.Type = type;
            if (txbName.Text.Length == 0 || txbNote.Text.Length == 0)
            {
                MessageBox.Show("Por favor preencha todos os campos (Name, Note)");
            }
            else
            {
                int idReturn = item.Gravar();

                FrmMain.CloseFormPanelList();
                FrmMain.OpenFormPanelList(type);
                if (!idReturn.Equals(-1))
                {
                    FrmListLogin.OpenChildFormPanelDesktop(new FrmItemNote(idReturn));
                }
                    
            }         
        }
      
        private void FrmAddItemNote_Load(object sender, EventArgs e)
        {

        }
    }
}
