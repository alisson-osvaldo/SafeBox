using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private Form currentChildForm;

        //Global
        public int ID { get; set; } 
        public bool Count { get; set; }

        public FrmListLogin()
        {
            FrmMain.LogicPanelButtons(windows);
            InitializeComponent();
            loadAll();
        }

        private void OpenChildFormPanelDesktop(Form childForm)
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
            listBoxLogin.DataSource = Item.SearchItemLoginType(type);                 
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

            if(Count == true)
            {
                OpenFrmItemLogin();
            }
            else
            {
                FrmMain.OpenFormPanelDesktop();
            }
            //Melhorar essa validação de telas aqui
            /*
             Criar uma Método com validação que:
                -Se eu estiver selecionando um item da lista, abra FrmItemLogin()
                -Se eu adicionar um item novo na AddItemLogin, Abrir a OpenFrmItemLogin() com o Id do item salvo 
             */ 
        }


    }
}
