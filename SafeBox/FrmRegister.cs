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

namespace SafeBox
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.UserName = txtUserNameRegister.Text;
            user.Password = txtPasswordRegister.Text;
            if (txtUserNameRegister.Text.Length == 0 || txtPasswordRegister.Text.Length == 0)
            {
                MessageBox.Show("Por favor preencha todos os campos");
            } else
            {
                user.Gravar();
                Application.Restart();
            }  
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
