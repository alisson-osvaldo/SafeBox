using System;
using System.Windows.Forms;
using Controller;
using SafeBox.Forms.ListItems;
using SafeBox.Forms.SelectedItems;

namespace SafeBox.Forms.AddItems
{
    public partial class FrmAddItemLogin : Form
    {
        public static string type = "Login";
        public static string windows = "AddItemLogin";

        public FrmAddItemLogin()
        {
            FrmMain.LogicPanelButtons(windows);
            FrmMain.ReturnType(windows);
            InitializeComponent();     
        }

        private void FrmAddItemLogin_Load(object sender, EventArgs e)
        {
            
        }

        public static void BtnCancel()
        {
            FrmMain.CloseFormPanelList();
            FrmMain.OpenFormPanelList(type);           
        }

        public static void BtnSaveAddItemLogin()
        {
            var item = new Item();
            item.IdUser = Form1.User_ID;
            item.Name = txbItemNome.Text;
            item.UserName = txbItemUserName.Text;
            item.Password = txbItemPassword.Text;
            item.URL = txbItemURL.Text;
            item.Note = txtItemNote.Text;
            item.Type = type;
            if (txbItemNome.Text.Length == 0 || txbItemUserName.Text.Length == 0 || txbItemPassword.Text.Length == 0)
            {
                MessageBox.Show("Por favor preencha todos os campos (Name, Username, Password)");
            }
            else
            {
                int idReturn = item.Gravar();
                FrmMain.CloseFormPanelList();
                FrmMain.OpenFormPanelList(type);
                if (!idReturn.Equals(-1))
                {
                    FrmListLogin.OpenChildFormPanelDesktop(new FrmItemLogin(idReturn));
                }
            }
            
        }

        
    }
}
