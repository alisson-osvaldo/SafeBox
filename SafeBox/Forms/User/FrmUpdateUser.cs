using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            txtNameUser.Texts = UserName;
        }

        //--------------------------------------------------------------------------------------------

        private void btnSave_Click(object sender, EventArgs e)
        {
            int Id = Form1.ReturnId();
            string newUsername = txtNameUser.Texts;
            string Password = txtPassword.Texts;  
            string newPassword = txtNewPassword.Texts;

            bool validation =  Database.User.validationPassword(Id, Password);

            bool validationCaracters = Controller.CheckPasswordStrength.ValidationCaracters(txtNewPassword.Texts);
            string passwordStrength = Controller.CheckPasswordStrength.GetPasswordStrength(txtNewPassword.Texts);

            if (validation != true)
            {
                MessageBox.Show("Senha Atual Incorreta!!!\nTente novamente.");
                txtPassword.Texts = "";
            }
            else if (validationCaracters != true || passwordStrength == "Inaceitavel")
            {
                MessageBox.Show("Senha Inaceitável");
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
             
            DialogResult confirm = MessageBox.Show("Tem Certeza que Deseja Deletar Sua Conta?", "Deletar Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);                        

            while(confirm.ToString().ToUpper() != "NO")
            {
                bool validation = Database.User.validationPassword(Id, Password);

                if (txtPassword.Texts == "")
                {
                    MessageBox.Show("Por favor, antes confirme sua senha no campo 'Senha Atual'!");
                }
                else if (validation != true)
                {
                    MessageBox.Show("Senha incorreta!, Tente novamente.");
                    txtPassword.Texts = "";
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

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNameUser__TextChanged(object sender, EventArgs e)
        {
            
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

            string passwordStrength = Controller.CheckPasswordStrength.GetPasswordStrength(password);

            lblPasswordStrength.Text = passwordStrength;
        }
    }
}

