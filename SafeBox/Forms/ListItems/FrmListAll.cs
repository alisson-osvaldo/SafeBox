using System;
using System.Windows.Forms;
using Controller;
using SafeBox.Forms.SelectedItems;

namespace SafeBox.Forms.ListItems
{
    public partial class FrmListAll : Form
    {
        public string type = "All";
        public string windows = "SafeBox";

        //Global
        public int ID { get; set; }
        public bool Count { get; set; }

        //Variaveis interação Layout
        private static Form currentChildForm;

        public FrmListAll()
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
                listBoxAll.DataSource = Item.SearchListAll(FrmMain.Search, idUser);
            }
            else
            {
                listBoxAll.DataSource = Item.Todos(idUser);
            }          
        }

        public void OpenFrmItemLogin()
        {
            if (type.Equals("Login"))
            {
                OpenChildFormPanelDesktop(new FrmItemLogin(ID));
            }
            if (type.Equals("Note"))
            {
                OpenChildFormPanelDesktop(new FrmItemNote(ID));
            }                   
        }

        private void FrmListAll_Load(object sender, EventArgs e)
        {
            Count = true;
        }

        private void listBoxAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Item)listBoxAll.SelectedValue;
            ID = item.Id;
            type = item.Type;

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
