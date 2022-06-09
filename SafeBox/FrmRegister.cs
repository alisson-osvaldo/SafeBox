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
            user.Password = txtCreatePassword.Text;

            bool validationCaracters = Controller.CheckPasswordStrength.ValidationCaracters(txtCreatePassword.Text);
            string passwordStrength = Controller.CheckPasswordStrength.GetPasswordStrength(txtCreatePassword.Text);
            bool QtdCaracters = Controller.CheckPasswordStrength.ValidationNumberOfCaracter(txtCreatePassword.Text);

            if (txtUserNameRegister.Text.Length == 0 || txtCreatePassword.Text.Length == 0)
            {
                MessageBox.Show("Por favor preencha todos os campos");
            } 
            else if (validationCaracters != true || passwordStrength == "Inaceitavel" || QtdCaracters != true)
            {
                MessageBox.Show("Senha Inaceitável");
            }
            else
            {
                user.Gravar();
                Application.Restart();
            }  
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnPasswordStrength_Click(object sender, EventArgs e)
        {
            string password = txtCreatePassword.Text;

            CheckPasswordStrength.ValidationCaracters(password);
            CheckPasswordStrength.ValidationNumberOfCaracter(password);

            string passwordStrength = Controller.CheckPasswordStrength.GetPasswordStrength(password);

            lblPasswordStrength.Text = passwordStrength;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            int op;

            if (txtCreatePassword.PasswordChar.Equals(false)) { op = 1; }
            else { op = 0; }

            switch (op)
            {
                case 0:
                    txtCreatePassword.PasswordChar = false;
                    btnPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    break;
                case 1:
                    txtCreatePassword.PasswordChar = true;
                    btnPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                    break;
            }
        }


        private void txtPassword__TextChanged(object sender, EventArgs e)
        {

        }
    }
}


