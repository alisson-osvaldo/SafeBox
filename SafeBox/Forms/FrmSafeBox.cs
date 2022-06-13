using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;

            Controller.Item.SearchItemByNameAll(search);
        }
    }
}
