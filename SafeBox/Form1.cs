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
using SafeBox.Forms.AddItems;

namespace SafeBox
{
    public partial class Form1 : Form
    {
        //Global
        public static int User_ID { get; set; }
        public static string User_Name { get; set; }

        //Não precisamos desses caras, conseguimos pegar as VAR Globais apenas : int varEx = SafeBox.Form1.User_ID;
        public static string ReturnUserName() { return User_Name; }
        public static int ReturnId() { return User_ID; }

        Thread t1;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnUnlock_Click(object sender, EventArgs e)
        {
            var login = new User();

            login.UserName = comboBoxLoginUserName.Text;
            login.Password = txtPasswordLogin.Texts;
            bool log = login.ValidacaoLogin();

            //getting id and username
            var usuario = (User)comboBoxLoginUserName.SelectedValue;
            User_ID = int.Parse(usuario.Id);
            User_Name = login.UserName;

            if (log == true)
            {
                this.Close();
                t1 = new Thread(abrirMain);
                t1.SetApartmentState(ApartmentState.STA); //STA thread unica(para 1 janela) caso mais de uma MTA 
                t1.Start();
            } else
            {
                MessageBox.Show("Senha incorreta! tente novamente.");
                txtPasswordLogin.Texts = "";
            }
        }

        

        public void abrirMain(Object obj)
        {
            Application.Run(new FrmMain());
        }

        private void btnFrmRegister_Click(object sender, EventArgs e)
        {
            new FrmRegister().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadALL();
        }

        private void LoadALL()
        {
            comboBoxLoginUserName.DataSource = User.Todos();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            int op;

            if (txtPasswordLogin.PasswordChar.Equals(false)) { op = 1; }
            else { op = 0; }

            switch (op)
            {
                case 0:
                    txtPasswordLogin.PasswordChar = false;
                    btnPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    break;
                case 1:
                    txtPasswordLogin.PasswordChar = true;
                    btnPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                    break;
            }
        }

    }
}
