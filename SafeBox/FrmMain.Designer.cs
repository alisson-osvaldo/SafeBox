namespace SafeBox
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSaleBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnNota = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.iconWindowsExit = new FontAwesome.Sharp.IconPictureBox();
            this.iconWindowsMaximized = new FontAwesome.Sharp.IconPictureBox();
            this.iconWindowsMinimize = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            panelList = new System.Windows.Forms.Panel();
            this.panelButtonAdd = new System.Windows.Forms.Panel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            panelDesktop = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
           btnDelete = new FontAwesome.Sharp.IconButton();
            btnCancel = new System.Windows.Forms.Button();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            this.menuStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconWindowsExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconWindowsMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconWindowsMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            panelList.SuspendLayout();
            this.panelButtonAdd.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairDoSaleBoxToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairDoSaleBoxToolStripMenuItem
            // 
            this.sairDoSaleBoxToolStripMenuItem.Name = "sairDoSaleBoxToolStripMenuItem";
            this.sairDoSaleBoxToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sairDoSaleBoxToolStripMenuItem.Text = "Sair do SaFeBox";
            this.sairDoSaleBoxToolStripMenuItem.Click += new System.EventHandler(this.sairDoSaleBoxToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.panelMenu.Controls.Add(this.btnNota);
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(212, 560);
            this.panelMenu.TabIndex = 2;
            // 
            // btnNota
            // 
            this.btnNota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNota.FlatAppearance.BorderSize = 0;
            this.btnNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNota.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNota.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnNota.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNota.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNota.IconSize = 32;
            this.btnNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNota.Location = new System.Drawing.Point(0, 145);
            this.btnNota.Name = "btnNota";
            this.btnNota.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNota.Size = new System.Drawing.Size(212, 60);
            this.btnNota.TabIndex = 3;
            this.btnNota.Text = "Nota";
            this.btnNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNota.UseVisualStyleBackColor = true;
            this.btnNota.Click += new System.EventHandler(this.iconNota_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.GlobeAmericas;
            this.btnLogin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 32;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 85);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(212, 60);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(212, 85);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::SafeBox.Properties.Resources.SafLock;
            this.btnHome.Location = new System.Drawing.Point(-1, -46);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(213, 177);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.panelTitleBar.Controls.Add(this.lblUserName);
            this.panelTitleBar.Controls.Add(this.iconWindowsExit);
            this.panelTitleBar.Controls.Add(this.iconWindowsMaximized);
            this.panelTitleBar.Controls.Add(this.iconWindowsMinimize);
            this.panelTitleBar.Controls.Add(lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(212, 24);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(753, 75);
            this.panelTitleBar.TabIndex = 3;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserName.Location = new System.Drawing.Point(7, 1);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 18);
            this.lblUserName.TabIndex = 5;
            // 
            // iconWindowsExit
            // 
            this.iconWindowsExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.iconWindowsExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconWindowsExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconWindowsExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconWindowsExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconWindowsExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconWindowsExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconWindowsExit.Location = new System.Drawing.Point(721, 0);
            this.iconWindowsExit.Name = "iconWindowsExit";
            this.iconWindowsExit.Size = new System.Drawing.Size(32, 75);
            this.iconWindowsExit.TabIndex = 4;
            this.iconWindowsExit.TabStop = false;
            this.iconWindowsExit.Click += new System.EventHandler(this.iconWindowsExit_Click);
            // 
            // iconWindowsMaximized
            // 
            this.iconWindowsMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconWindowsMaximized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.iconWindowsMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconWindowsMaximized.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconWindowsMaximized.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconWindowsMaximized.IconColor = System.Drawing.Color.Gainsboro;
            this.iconWindowsMaximized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconWindowsMaximized.Location = new System.Drawing.Point(692, 0);
            this.iconWindowsMaximized.Name = "iconWindowsMaximized";
            this.iconWindowsMaximized.Size = new System.Drawing.Size(32, 75);
            this.iconWindowsMaximized.TabIndex = 3;
            this.iconWindowsMaximized.TabStop = false;
            this.iconWindowsMaximized.Click += new System.EventHandler(this.iconWindowsMaximized_Click);
            // 
            // iconWindowsMinimize
            // 
            this.iconWindowsMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconWindowsMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.iconWindowsMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconWindowsMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconWindowsMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconWindowsMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconWindowsMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconWindowsMinimize.IconSize = 19;
            this.iconWindowsMinimize.Location = new System.Drawing.Point(667, 0);
            this.iconWindowsMinimize.Name = "iconWindowsMinimize";
            this.iconWindowsMinimize.Size = new System.Drawing.Size(19, 23);
            this.iconWindowsMinimize.TabIndex = 2;
            this.iconWindowsMinimize.TabStop = false;
            this.iconWindowsMinimize.Click += new System.EventHandler(this.iconWindowsMinimize_Click_1);
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            lblTitleChildForm.Location = new System.Drawing.Point(45, 32);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new System.Drawing.Size(39, 13);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.Click += new System.EventHandler(lblTitleChildForm_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(7, 22);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(212, 99);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(753, 10);
            this.panelShadow.TabIndex = 4;
            // 
            // panelList
            // 
            panelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            panelList.Controls.Add(this.panelButtonAdd);
            panelList.Dock = System.Windows.Forms.DockStyle.Left;
            panelList.Location = new System.Drawing.Point(212, 109);
            panelList.Name = "panelList";
            panelList.Size = new System.Drawing.Size(263, 475);
            panelList.TabIndex = 5;
            panelList.SizeChanged += new System.EventHandler(panelList_SizeChanged);
            panelList.Paint += new System.Windows.Forms.PaintEventHandler(panelDesktop_Paint);
            // 
            // panelButtonAdd
            // 
            this.panelButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panelButtonAdd.Controls.Add(this.btnAdd);
            this.panelButtonAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonAdd.Location = new System.Drawing.Point(0, 418);
            this.panelButtonAdd.Name = "panelButtonAdd";
            this.panelButtonAdd.Size = new System.Drawing.Size(263, 57);
            this.panelButtonAdd.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(194)))), ((int)(((byte)(122)))));
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.Location = new System.Drawing.Point(7, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(247, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDesktop.Location = new System.Drawing.Point(475, 109);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new System.Drawing.Size(490, 475);
            panelDesktop.TabIndex = 6;
            panelDesktop.SizeChanged += new System.EventHandler(panelDesktop_SizeChanged);
            panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(panelDesktop_Paint_1);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panelButtons.Controls.Add(btnDelete);
            this.panelButtons.Controls.Add(btnCancel);
            this.panelButtons.Controls.Add(btnEdit);
            this.panelButtons.Controls.Add(btnSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(475, 527);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(490, 57);
            this.panelButtons.TabIndex = 0;
            this.panelButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnDelete
            // 
           btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
           btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
           btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
           btnDelete.Cursor = System.Windows.Forms.Cursors.IBeam;
           btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
           btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
           btnDelete.IconColor = System.Drawing.Color.Red;
           btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
           btnDelete.IconSize = 30;
           btnDelete.Location = new System.Drawing.Point(424, 9);
           btnDelete.Name = "btnDelete";
           btnDelete.Size = new System.Drawing.Size(54, 42);
           btnDelete.TabIndex = 6;
           btnDelete.UseVisualStyleBackColor = false;
           btnDelete.Visible = false;
           btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            btnCancel.Location = new System.Drawing.Point(93, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 42);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(194)))), ((int)(((byte)(122)))));
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.IconSize = 30;
            btnEdit.Location = new System.Drawing.Point(19, 7);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(54, 42);
            btnEdit.TabIndex = 4;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnSave.Cursor = System.Windows.Forms.Cursors.IBeam;
            btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(194)))), ((int)(((byte)(122)))));
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 30;
            btnSave.Location = new System.Drawing.Point(19, 7);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(54, 42);
            btnSave.TabIndex = 3;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += new System.EventHandler(btnSaveItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(965, 584);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(panelDesktop);
            this.Controls.Add(panelList);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconWindowsExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconWindowsMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconWindowsMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            panelList.ResumeLayout(false);
            this.panelButtonAdd.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSaleBoxToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconPictureBox iconWindowsMinimize;
        private FontAwesome.Sharp.IconPictureBox iconWindowsMaximized;
        private FontAwesome.Sharp.IconPictureBox iconWindowsExit;
        private System.Windows.Forms.Panel panelButtonAdd;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnNota;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panelButtons;
        private static FontAwesome.Sharp.IconButton btnSave;
        private static FontAwesome.Sharp.IconButton btnEdit;
        private static FontAwesome.Sharp.IconButton btnDelete;
        private static System.Windows.Forms.Button btnCancel;
        public static System.Windows.Forms.Label lblTitleChildForm;
        public static System.Windows.Forms.Panel panelList;
        public static System.Windows.Forms.Panel panelDesktop;
    }
}