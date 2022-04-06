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
        //Variaveis interação Layout
        private Form currentChildForm;


        public FrmAddItem()
        {
            InitializeComponent();
        }

        //My Methods-------------------------------------------------------------------

        //PanelAddItem
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

        private void panelAddItem_SizeChanged(object sender, EventArgs e)
        { 
          
        }

        private void FrmAddItem_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void panelAddType_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxItems.SelectedIndex;

            if (selectedIndex == 0)
            {
                OpenChildFormPanelAddItem(new FrmAddItemLogin());
            } else if (selectedIndex == 1)
            {
                OpenChildFormPanelAddItem(new FrmItemNote());
            }

            
        }
    }
}
