namespace SafeBox.Forms.AddItems
{
    partial class FrmAddItemLogin
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
            this.panelAddLogin = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveItem = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanelAddItemLogin = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbItemNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbItemURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAddTypeLogin = new System.Windows.Forms.Panel();
            this.txbItemPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbItemUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbItemNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAddLogin.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanelAddItemLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAddTypeLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddLogin
            // 
            this.panelAddLogin.AutoSize = true;
            this.panelAddLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panelAddLogin.Controls.Add(this.flowLayoutPanelAddItemLogin);
            this.panelAddLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddLogin.Location = new System.Drawing.Point(0, 0);
            this.panelAddLogin.Name = "panelAddLogin";
            this.panelAddLogin.Size = new System.Drawing.Size(800, 573);
            this.panelAddLogin.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnSaveItem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 570);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 50);
            this.panel4.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(126, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnSaveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSaveItem.FlatAppearance.BorderSize = 0;
            this.btnSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveItem.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(194)))), ((int)(((byte)(122)))));
            this.btnSaveItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveItem.IconSize = 30;
            this.btnSaveItem.Location = new System.Drawing.Point(63, 10);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(57, 32);
            this.btnSaveItem.TabIndex = 1;
            this.btnSaveItem.UseVisualStyleBackColor = false;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // flowLayoutPanelAddItemLogin
            // 
            this.flowLayoutPanelAddItemLogin.AutoScroll = true;
            this.flowLayoutPanelAddItemLogin.Controls.Add(this.panel1);
            this.flowLayoutPanelAddItemLogin.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAddItemLogin.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanelAddItemLogin.Name = "flowLayoutPanelAddItemLogin";
            this.flowLayoutPanelAddItemLogin.Size = new System.Drawing.Size(417, 517);
            this.flowLayoutPanelAddItemLogin.TabIndex = 0;
            this.flowLayoutPanelAddItemLogin.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelAddTypeLogin);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 620);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.txbItemNote);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(6, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 220);
            this.panel3.TabIndex = 4;
            // 
            // txbItemNote
            // 
            this.txbItemNote.Location = new System.Drawing.Point(3, 32);
            this.txbItemNote.Multiline = true;
            this.txbItemNote.Name = "txbItemNote";
            this.txbItemNote.Size = new System.Drawing.Size(368, 174);
            this.txbItemNote.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Note";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.txbItemURL);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(6, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 91);
            this.panel2.TabIndex = 3;
            // 
            // txbItemURL
            // 
            this.txbItemURL.Location = new System.Drawing.Point(3, 33);
            this.txbItemURL.Name = "txbItemURL";
            this.txbItemURL.Size = new System.Drawing.Size(368, 20);
            this.txbItemURL.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "URL";
            // 
            // panelAddTypeLogin
            // 
            this.panelAddTypeLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panelAddTypeLogin.Controls.Add(this.txbItemPassword);
            this.panelAddTypeLogin.Controls.Add(this.label3);
            this.panelAddTypeLogin.Controls.Add(this.txbItemUserName);
            this.panelAddTypeLogin.Controls.Add(this.label1);
            this.panelAddTypeLogin.Controls.Add(this.txbItemNome);
            this.panelAddTypeLogin.Controls.Add(this.label2);
            this.panelAddTypeLogin.Location = new System.Drawing.Point(6, 9);
            this.panelAddTypeLogin.Name = "panelAddTypeLogin";
            this.panelAddTypeLogin.Size = new System.Drawing.Size(377, 196);
            this.panelAddTypeLogin.TabIndex = 2;
            // 
            // txbItemPassword
            // 
            this.txbItemPassword.Location = new System.Drawing.Point(6, 140);
            this.txbItemPassword.Name = "txbItemPassword";
            this.txbItemPassword.Size = new System.Drawing.Size(368, 20);
            this.txbItemPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txbItemUserName
            // 
            this.txbItemUserName.Location = new System.Drawing.Point(6, 89);
            this.txbItemUserName.Name = "txbItemUserName";
            this.txbItemUserName.Size = new System.Drawing.Size(368, 20);
            this.txbItemUserName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // txbItemNome
            // 
            this.txbItemNome.Location = new System.Drawing.Point(6, 34);
            this.txbItemNome.Name = "txbItemNome";
            this.txbItemNome.Size = new System.Drawing.Size(368, 20);
            this.txbItemNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmAddItemLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.panelAddLogin);
            this.Name = "FrmAddItemLogin";
            this.Text = "FrmAddItemLogin";
            this.Load += new System.EventHandler(this.FrmAddItemLogin_Load);
            this.panelAddLogin.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanelAddItemLogin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelAddTypeLogin.ResumeLayout(false);
            this.panelAddTypeLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAddLogin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAddItemLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAddTypeLogin;
        private System.Windows.Forms.TextBox txbItemNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbItemNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbItemURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbItemPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbItemUserName;
        private FontAwesome.Sharp.IconButton btnSaveItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel4;
    }
}