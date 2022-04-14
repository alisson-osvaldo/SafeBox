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
        //Variaveis interação Layout
        private Form currentChildForm;

        //Global
        public int ID { get; set; } 
        public object teste { get; set; }

        public FrmListLogin()
        {
            InitializeComponent();
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

        }

        //não estou usando
        /*public int selectItemList()
        {
        }*/

        private void FrmListLogin_Load_1(object sender, EventArgs e)
        {
            listBoxLogin.DataSource = Item.Todos();
            //listBoxLogin.DisplayMember = "name";
            //listBoxLogin.ValueMember = "id";
            teste = (Item)listBoxLogin.SelectedValue;

        }

        private void listBoxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBoxLogin.SelectedValue;
          

            //selectItemList();

            if (item != listBoxLogin.SelectedItem)
            {
                OpenChildFormPanelDesktop(new FrmItemLogin(item));
            }  
        }


    }
}
