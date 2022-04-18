﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace SafeBox.Forms.AddItems
{
    public partial class FrmAddItemLogin : Form
    {
        public string type = "Login";

        public FrmAddItemLogin()
        {
            InitializeComponent();
        }

        private void FrmAddItemLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            var item = new Item();
            item.IdUser = Form1.User_ID; 
            item.Name = txbItemNome.Text;
            item.UserName = txbItemUserName.Text;
            item.Password = txbItemPassword.Text;
            item.URL = txbItemURL.Text;
            item.Note = txbItemNote.Text;
            item.Type = type;
            if (txbItemNome.Text.Length == 0 || txbItemUserName.Text.Length == 0 || txbItemPassword.Text.Length == 0)
            {
                MessageBox.Show("Por favor preencha todos os campos (Name, Username, Password)");
            }
            else
            {
                item.Gravar();
                Close();

                FrmMain.CloseFormPanelList();
                FrmMain.OpenFormPanelList(type);
            }    
        }

        
    }
}
