using System;
using System.Windows.Forms;
using Controller;
using SafeBox.Forms.SelectedItems;

namespace SafeBox.Forms.ListItems
{
    public partial class FrmListLogin : Form
    {
        public string type = "Login";
        public string windows = "ListLogin";

        //Variaveis interação Layout
        private static Form currentChildForm;

        //Global
        public int ID { get; set; } 
        public bool Count { get; set; }

        public FrmListLogin()
        {
            FrmMain.LogicPanelButtons(windows);
            InitializeComponent();
            loadAll();
        }

        public static void OpenChildFormPanelDesktop(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            FrmMain.panelDesktop.Controls.Add(childForm);
            FrmMain.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void loadAll()
        {
            int idUser = Form1.User_ID;
            
            if (FrmMain.SearchValidation.Equals(true))
            {
                listBoxLogin.DataSource = Item.SearchList(FrmMain.Search, FrmMain.CurrentType, idUser);
            }
            else
            {
                listBoxLogin.DataSource = Item.SearchItemLoginType(type, idUser);
            }
        }

        public void OpenFrmItemLogin()
        {
            OpenChildFormPanelDesktop(new FrmItemLogin(ID));
        }

        private void FrmListLogin_Load_1(object sender, EventArgs e)
        {
            Count = true;
        }

        public void listBoxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Item)listBoxLogin.SelectedValue;
            ID = item.Id;

            if (Count == true)
            {
                OpenFrmItemLogin();
            }
            else
            {
                FrmMain.OpenFormPanelDesktop();
            }
        }


    }
}
