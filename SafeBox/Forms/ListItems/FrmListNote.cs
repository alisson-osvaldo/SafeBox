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
using SafeBox.Forms.SelectedItems;

namespace SafeBox.Forms.ListItems
{
    public partial class FrmListNote : Form
    {
        public string type = "Note";
        public string windows = "ListNote";

        //Variaveis interação Layout
        private Form currentChildForm;

        //Global
        public int ID { get; set; }
        public bool Count { get; set; }

        public FrmListNote()
        {
            FrmMain.LogicPanelButtons(windows);
            InitializeComponent();
            loadAll();
        }

        private void OpenChildFormPanelDesktop(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            FrmMain.panelDesktop.Controls.Add(childForm);
            FrmMain.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void loadAll()
        {
            listBoxNote.DataSource = Item.SearchItemNoteType(type);
        }

        public void OpenFrmItemNote()
        {
           OpenChildFormPanelDesktop(new FrmItemNote(ID));
        }

        private void FrmListNota_Load(object sender, EventArgs e)
        {
            Count = true;
        }

        private void listBoxNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Item)listBoxNote.SelectedValue;
            ID = item.Id;

            if (Count == true)
            {
                OpenFrmItemNote();
            }
            else
            {
                FrmMain.OpenFormPanelDesktop();
            }
        }
    }
}
