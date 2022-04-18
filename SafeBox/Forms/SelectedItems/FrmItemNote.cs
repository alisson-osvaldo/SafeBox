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

namespace SafeBox.Forms.SelectedItems
{
    public partial class FrmItemNote : Form
    {
        public int Id { get; set; }
        public string windows = "SelectItemNote";

        public FrmItemNote(object idItem)
        {
            FrmMain.LogicPanelButtons(windows);
            InitializeComponent();

            //GetItem SqlServer
            Id = int.Parse(idItem.ToString());
            var itemId = Item.SearchItemById(Id);

            Id = itemId[0].Id;
            string name = itemId[0].Name;
            string note = itemId[0].Note;

            txtName.Text = name;
            txtNote.Text = note;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Note = txtNote.Text;
            string UserName = "";
            string Password = "";
            string URL = "";

            if (String.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Campo Name em branco !!!");
            }
            if (String.IsNullOrEmpty(Note))
            {
                MessageBox.Show("Campo Name em branco !!!");
            }

            if (!String.IsNullOrEmpty(Name) && !String.IsNullOrEmpty(Note))
            {
                Database.Item.UpdateItem(Id, Name, UserName, Password, URL, Note);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string type = "Note";
            Database.Item.DeleteItem(Id);
            FrmMain.CloseFormPanelList();
            FrmMain.OpenFormPanelList(type);
        }

        private void FrmItemNote_Load(object sender, EventArgs e)
        {

        }
    }
}
