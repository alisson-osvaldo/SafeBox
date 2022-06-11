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

namespace SafeBox.Forms.SelectedItems
{
    public partial class FrmItemLogin : Form
    {
        public static int Id { get; set; }
        public string windows = "SelectItemLogin";
        public static string type = "Login";

        public FrmItemLogin(object idItem)
        {
            FrmMain.LogicPanelButtons(windows);
            FrmMain.ReturnType(type);
            InitializeComponent();

            //GetItem SqlServer
            Id = int.Parse(idItem.ToString());
            var t = Item.SearchItemById(Id); 
            
            Id = t[0].Id;
            string name = t[0].Name;
            string username = t[0].UserName;
            string password = t[0].Password;
            string url = t[0].URL;
            string note = t[0].Note;

            txtName.Text = name;
            txtUserName.Text = username;
            txtPassword.Text = password;
            if (url == "")
            {
                lblURL.Visible = false;
                txtURL.Visible = false;
            }
            if (note == "")
            {
                lblNote.Visible = false;
                txtNote.Visible = false;
            }
            else
            {
                txtURL.Text = url;
                txtNote.Text = note;
            }
        }

        private void FrmItemLogin_Load(object sender, EventArgs e)
        {  
        }

        public static void BtnEdit()
        {
            lblURL.Visible = true;
            txtURL.Visible = true;
            lblNote.Visible = true;
            txtNote.Visible = true;

            txtName.ReadOnly = false;
            txtUserName.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtURL.ReadOnly = false;
            txtNote.ReadOnly = false;
        }

        public static void BtnCancel()
        {
            FrmMain.CloseFormPanelList();
            FrmMain.OpenFormPanelList(type);
        }


        public static void BtnSave()
        {
            string Name = txtName.Text;
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            string URL = txtURL.Text;
            string Note = txtNote.Text;

            if (String.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Campo Name em branco !!!");
            }
            if (String.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("Campo UsernaName em branco !!!");
            }
            if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Campo Password em branco !!!");
            }
            if (String.IsNullOrEmpty(URL))
            {
                lblURL.Visible = false;
                txtURL.Visible = false;
            }
            if (String.IsNullOrEmpty(Note))
            {
                lblNote.Visible = false;
                txtNote.Visible = false;
            }

            if (!String.IsNullOrEmpty(Name) && !String.IsNullOrEmpty(UserName) && !String.IsNullOrEmpty(Password))
            {
                Database.Item.UpdateItem(Id, Name, UserName, Password, URL, Note);
            }

            FrmMain.CloseFormPanelList();
            FrmMain.OpenFormPanelList(type);           
        }       

        public static void BtnDelete()
        {
            Database.Item.DeleteItem(Id);
            FrmMain.CloseFormPanelList();
            FrmMain.OpenFormPanelList(type);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            int op;

            if (txtPassword.UseSystemPasswordChar.Equals(false)) { op = 1; }
            else { op = 0; }

            switch (op)
            {
                case 0:
                    txtPassword.UseSystemPasswordChar = false;
                    btnPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    break;
                case 1:
                    txtPassword.UseSystemPasswordChar = true;
                    btnPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                    break;
            }
        }

        private void btnCopyUserName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtUserName.Text);
        }
    }
}
