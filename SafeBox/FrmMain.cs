using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SafeBox.Forms;
using SafeBox.Forms.AddItems;
using SafeBox.Forms.ListItems;
using SafeBox.Forms.SelectedItems;
using SafeBox.Forms.User;

namespace SafeBox
{
    public partial class FrmMain : Form
    {
        private static string typeForm { get; set; }
        public static string CurrentType { get; set; }
        public static bool SearchValidation { get; set; }
        public static string Search { get; set; }

        //Variaveis interação Layout
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private static Form currentChildForm;
        private static Form currentChildFormPanelList;


        public FrmMain()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //OpenListBox All
            CurrentType = "All";
            typeForm = "All";
            OpenFormPanelList(typeForm);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //Vai deixar uma margen sobrando quando estiver full maximizado
        }

        //Structs
        private struct RGBColors{
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //my methods -----------------------------------------------------------------------------------
        private void ActivateButton(Object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                //Button
                DisableButton();
                currentBtn = (IconButton)senderbtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(5,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon Current Child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public static void OpenChildFormPanelList(Form childForm)
        {
            if (currentChildFormPanelList != null)
            {
                //open only form
                currentChildFormPanelList.Close();
            }
            currentChildFormPanelList = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelList.Controls.Add(childForm);
            panelList.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private static void OpenChildFormPanelDesktop(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private static void OpenChildFormPanelSafebox(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public static void ReturnType(string type)
        {
            typeForm = type;
        }

        public static void OpenFormPanelDesktop()
        {
            OpenChildFormPanelSafebox(new FrmSafeBox());
        }

        public static void OpenFormPanelList(string type)
        {
            if (type.Equals("Login"))
            {
                OpenChildFormPanelList(new FrmListLogin());
            }
            else if (type.Equals("Note"))
            {
                OpenChildFormPanelList(new FrmListNote());
            }
            else if (type.Equals("All"))
            {
                OpenChildFormPanelList(new FrmListAll());
            }           
        }

        public static void CloseFormPanelList()
        {
            if (currentChildFormPanelList != null)
            {
                currentChildFormPanelList.Close();
            }
        }

        //Drag form (arrastar formulário)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        public static void LogicPanelButtons(string type)
        {
            if (type.Equals("AddItemLogin") || type.Equals("AddItemNote"))
            {
                btnSave.Visible = true;
                btnCancel.Visible = true;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
            if (type.Equals("ListLogin") || type.Equals("ListNota") || type.Equals("AddItem") || type.Equals("SafeBox"))
            {
                btnSave.Visible = false;
                btnCancel.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
            if (type.Equals("BtnEdit"))
            {
                btnSave.Visible = true;
                btnCancel.Visible = true;
                btnEdit.Visible = false;
                btnDelete.Visible = true;
            }
            if (type.Equals("SelectItemLogin") || type.Equals("SelectItemNote"))
            {
                btnSave.Visible = false;
                btnCancel.Visible = false;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
        }       

        //--------------------------------------------------------------

        private void sairDoSaleBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Bem vindo " + Form1.User_Name;
        }


        private void BtnAll_Click(object sender, EventArgs e)
        {
            CurrentType = "All";
            lblTitleChildForm.Text = "Todos os Items";
            ActivateButton(sender, RGBColors.color3);
            OpenChildFormPanelList(new FrmListAll());
        }

        private void iconNota_Click(object sender, EventArgs e)
        {
            CurrentType = "Note";
            lblTitleChildForm.Text = "Nota";
            ActivateButton(sender, RGBColors.color2);
            OpenChildFormPanelList(new FrmListNote()); 
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            CurrentType = "Login";
            lblTitleChildForm.Text = "Login";
            ActivateButton(sender, RGBColors.color1);
            OpenChildFormPanelList(new FrmListLogin());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }        
            CloseFormPanelList();
            OpenFormPanelDesktop();
            Reset();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconWindowsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconWindowsMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconWindowsMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenChildFormPanelDesktop(new FrmAddItem());
        }


        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            if (typeForm.Equals("Login"))
            {
                FrmItemLogin.BtnSave();
            }
            if (typeForm.Equals("Note"))
            {
                FrmItemNote.BtnSave();
            }
            if (typeForm.Equals("AddItemLogin"))
            {
                FrmAddItemLogin.BtnSaveAddItemLogin();
            }
            if (typeForm.Equals("AddItemNote"))
            {
                FrmAddItemNote.BtnSaveAddItemLogin();
            }
        }
       
        public void btnDelete_Click(object sender, EventArgs e)
        {
            string windows = "BtnEdit";
            LogicPanelButtons(windows);

            if (typeForm.Equals("Login"))
            {
                FrmItemLogin.BtnDelete();
            }
            if (typeForm.Equals("Note"))
            {
                FrmItemNote.BtnDelete();
            }           
        }

        public static void btnEdit_Click(object sender, EventArgs e)
        {
            string windows = "BtnEdit";
            LogicPanelButtons(windows);

            if (typeForm.Equals("Login"))
            {
                FrmItemLogin.BtnEdit();
            }
            if (typeForm.Equals("Note"))
            {
                FrmItemNote.BtnEdit();
            }           
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (typeForm.Equals("Login"))
            {
                FrmItemLogin.BtnCancel();
            }
            if (typeForm.Equals("Note"))
            {
                FrmItemNote.BtnCancel();
            }   
            if (typeForm.Equals("AddItemNote"))
            {
                FrmAddItemLogin.BtnCancel();
            }
            if (typeForm.Equals("AddItemLogin"))
            {
                FrmAddItemNote.BtnCancel();
            }
        }

        private void adicionarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildFormPanelDesktop(new FrmAddItem());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trocarDeContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void editarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildFormPanelDesktop(new FrmUpdateUser());
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmInfo().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchValidation = true;
            Search = txtSearch.Text;

            if (FrmMain.CurrentType.Equals("Login"))
            {
                FrmMain.OpenChildFormPanelList(new FrmListLogin());
            }
            else if (FrmMain.CurrentType.Equals("Note"))
            {
                FrmMain.OpenChildFormPanelList(new FrmListNote());
            }
            else
            {
                FrmMain.OpenChildFormPanelList(new FrmListAll());
            }

            SearchValidation = false;
        }
    }
}
