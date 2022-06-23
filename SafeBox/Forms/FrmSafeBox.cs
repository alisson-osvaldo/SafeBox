using System;
using System.Windows.Forms;
using SafeBox.Forms.ListItems;

namespace SafeBox.Forms
{
    public partial class FrmSafeBox : Form
    {       
        public string windows = "SafeBox";

        public FrmSafeBox()
        {
            FrmMain.LogicPanelButtons(windows);
            InitializeComponent();           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSafeBox_Load(object sender, EventArgs e)
        {

        }      

    }
}
