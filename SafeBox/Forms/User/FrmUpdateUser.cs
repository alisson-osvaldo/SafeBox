using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeBox.Forms.User
{
    public partial class FrmUpdateUser : Form
    {
        public FrmUpdateUser()
        {
            InitializeComponent();

            string UserName = Form1.ReturnUserName();
            txtNameUser.Text = UserName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int Id = Form1.ReturnId();
            string newUsername = txtNameUser.Text;
            string Password = txtPassword.Text;  
            string newPassword = txtNewPassword.Text;

            Database.User.UpdateUser(Id, Password, newUsername, newPassword);

            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem Certeza que Deseja Deletar Sua Conta?", "Deletar Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            
            if (confirm.ToString().ToUpper() == "YES")
            {
                int Id = Form1.ReturnId();
                Database.User.DeleteUser(Id);
                Application.Restart();
            }
            Close();              
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
