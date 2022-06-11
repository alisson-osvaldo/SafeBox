using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafeBox.Forms.AddItems;

namespace SafeBox.Forms
{
    public partial class FrmAddItem : Form
    {
        public string windows = "AddItem";       

        //Variaveis interação Layout
        private Form currentChildForm;

        public FrmAddItem()
        {
            FrmMain.LogicPanelButtons(windows);
            InitializeComponent();
            OpenChildFormPanelAddItem(new FrmAddItemLogin());
        }

        //My Methods-------------------------------------------------------------------

        private void OpenChildFormPanelAddItem(Form childForm)
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
            panelAddType.Controls.Add(childForm);
            panelAddType.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        //------------------------------------------------------------------------------

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxItems.SelectedIndex;

            if (selectedIndex == 0)
            {
                OpenChildFormPanelAddItem(new FrmAddItemLogin());
                lblType.Text = "Login";
            } else if (selectedIndex == 1)
            {
                lblType.Text = "Nota Segura";
                OpenChildFormPanelAddItem(new FrmAddItemNote());
            }

            
        }

        private void FrmAddItem_Load(object sender, EventArgs e)
        {

        }

    }
}
