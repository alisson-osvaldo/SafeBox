using System;
using System.Drawing;
using System.Windows.Forms;

namespace SafeBox.Forms.User
{
    public partial class FrmUpdateUser : Form
    {
        public FrmUpdateUser()
        {
            InitializeComponent();

            string UserName = Form1.ReturnUserName();
            txtNameUser.Texts = UserName;
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            int Id = Form1.ReturnId();
            string newUsername = txtNameUser.Texts;
            string Password = txtPassword.Texts;  
            string newPassword = txtNewPassword.Texts;

            bool validation =  Database.User.validationPassword(Id, Password);

            bool validationCaracters = Controller.CheckPasswordStrength.ValidationCaracters(txtNewPassword.Texts);
            string passwordStrength = Controller.CheckPasswordStrength.GetPasswordStrength(txtNewPassword.Texts);
            bool QtdCaracters = Controller.CheckPasswordStrength.ValidationNumberOfCaracter(txtNewPassword.Texts);

            if (validation != true)
            {
                MessageBox.Show("Senha Atual Incorreta!!!\nTente novamente.");
                txtPassword.Texts = "";
                txtPassword.Focus();
            }
            else if (validationCaracters != true || passwordStrength == "Inaceitável" || QtdCaracters != true)
            {
                MessageBox.Show("Senha Inaceitável");
                txtNewPassword.Focus();
            }
            else
            {
                Database.User.UpdateUser(Id, newUsername, newPassword);

                MessageBox.Show("Conta editada com sucesso");

                Close();
            }                       
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Form1.ReturnId();
            string Password = txtPassword.Texts;
             
            DialogResult confirm = MessageBox.Show(
                "Tem Certeza que Deseja Deletar Sua Conta?" +
                "\n" +
                "\nTodas as Senhas Salvas Serão Perdidas!",
                "Deletar Conta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2
                );                        

            while(confirm.ToString().ToUpper() != "NO")
            {
                bool validation = Database.User.validationPassword(Id, Password);

                if (txtPassword.Texts == "")
                {
                    MessageBox.Show("Por favor, antes confirme sua senha no campo 'Senha Atual'!");
                    txtPassword.Focus();
                }
                else if (validation != true)
                {
                    MessageBox.Show("Senha incorreta!, Tente novamente.");
                    txtPassword.Texts = "";
                    txtPassword.Focus();
                }

                if (confirm.ToString().ToUpper() == "YES" && validation != false)
                {
                    Database.User.DeleteUser(Id);
                    Application.Restart();
                    Close();
                }
                break;
            }
                      
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            int op;

            if (txtNewPassword.PasswordChar.Equals(false)) {op = 1;} 
            else {op = 0;}          

            switch(op)
            {
                case 0:
                    txtNewPassword.PasswordChar = false;
                        btnPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    break;
                case 1:
                    txtNewPassword.PasswordChar = true;
                        btnPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = txtNewPassword.Texts;

            Controller.CheckPasswordStrength.ValidationCaracters(password);
            Controller.CheckPasswordStrength.ValidationNumberOfCaracter(password);

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

        private void FrmUpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string password = txtNewPassword.Texts;

            Controller.CheckPasswordStrength.ValidationCaracters(password);
            Controller.CheckPasswordStrength.ValidationNumberOfCaracter(password);

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
    }
}

