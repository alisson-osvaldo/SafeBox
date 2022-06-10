using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;


namespace SafeBox
{
    public partial class FrmRegister : Form
    {
        Thread t1;

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
            user.UserName = txtUserNameRegister.Texts;
            user.Password = txtCreatePassword.Texts;

            bool validationCaracters = Controller.CheckPasswordStrength.ValidationCaracters(txtCreatePassword.Texts);
            string passwordStrength = Controller.CheckPasswordStrength.GetPasswordStrength(txtCreatePassword.Texts);
            bool QtdCaracters = Controller.CheckPasswordStrength.ValidationNumberOfCaracter(txtCreatePassword.Texts);

            if (txtUserNameRegister.Texts.Length == 0 || txtCreatePassword.Texts.Length == 0)
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

                /* Este código abre direto na Main, porem precisa referenciar o usuaria qeu está entrando
                t1 = new Thread(abrirMain);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();*/
            }  
        }

        public void abrirMain(Object obj)
        {
            Application.Run(new FrmMain());
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnPasswordStrength_Click(object sender, EventArgs e)
        {
            string password = txtCreatePassword.Texts;

            CheckPasswordStrength.ValidationCaracters(password);
            CheckPasswordStrength.ValidationNumberOfCaracter(password);

            string passwordStrength = Controller.CheckPasswordStrength.GetPasswordStrength(password);

            if (passwordStrength == "Inaceitável")
            {
                lblPasswordStrength.ForeColor = Color.Red;
            }
            else if (passwordStrength == "Fraca")
            {
                lblPasswordStrength.ForeColor = Color.Orange;
            }
            else if (passwordStrength == "Aceitável")
            {
                lblPasswordStrength.ForeColor = Color.Yellow;
            }
            else
            {
                lblPasswordStrength.ForeColor = Color.Green;
            }
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

    }
}


