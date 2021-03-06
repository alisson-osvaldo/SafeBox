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
            this.panel3 = new System.Windows.Forms.Panel();
            txtItemNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            txbItemURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAddTypeLogin = new System.Windows.Forms.Panel();
            this.btnPassword = new FontAwesome.Sharp.IconButton();
            txbItemPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            txbItemUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            txbItemNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAddLogin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAddTypeLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddLogin
            // 
            this.panelAddLogin.AutoSize = true;
            this.panelAddLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panelAddLogin.Controls.Add(this.panel3);
            this.panelAddLogin.Controls.Add(this.panel2);
            this.panelAddLogin.Controls.Add(this.panelAddTypeLogin);
            this.panelAddLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddLogin.Location = new System.Drawing.Point(0, 0);
            this.panelAddLogin.Name = "panelAddLogin";
            this.panelAddLogin.Size = new System.Drawing.Size(398, 573);
            this.panelAddLogin.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(txtItemNote);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 220);
            this.panel3.TabIndex = 4;
            // 
            // txtItemNote
            // 
            txtItemNote.BackColor = System.Drawing.Color.Gainsboro;
            txtItemNote.Location = new System.Drawing.Point(6, 32);
            txtItemNote.Multiline = true;
            txtItemNote.Name = "txtItemNote";
            txtItemNote.Size = new System.Drawing.Size(377, 176);
            txtItemNote.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Anotação";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(txbItemURL);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 91);
            this.panel2.TabIndex = 3;
            // 
            // txbItemURL
            // 
            txbItemURL.BackColor = System.Drawing.Color.Gainsboro;
            txbItemURL.Location = new System.Drawing.Point(6, 33);
            txbItemURL.Name = "txbItemURL";
            txbItemURL.Size = new System.Drawing.Size(377, 20);
            txbItemURL.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "URL";
            // 
            // panelAddTypeLogin
            // 
            this.panelAddTypeLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panelAddTypeLogin.Controls.Add(this.btnPassword);
            this.panelAddTypeLogin.Controls.Add(txbItemPassword);
            this.panelAddTypeLogin.Controls.Add(this.label3);
            this.panelAddTypeLogin.Controls.Add(txbItemUserName);
            this.panelAddTypeLogin.Controls.Add(this.label1);
            this.panelAddTypeLogin.Controls.Add(txbItemNome);
            this.panelAddTypeLogin.Controls.Add(this.label2);
            this.panelAddTypeLogin.Location = new System.Drawing.Point(3, 3);
            this.panelAddTypeLogin.Name = "panelAddTypeLogin";
            this.panelAddTypeLogin.Size = new System.Drawing.Size(395, 196);
            this.panelAddTypeLogin.TabIndex = 2;
            // 
            // btnPassword
            // 
            this.btnPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnPassword.IconColor = System.Drawing.Color.Red;
            this.btnPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPassword.IconSize = 30;
            this.btnPassword.Location = new System.Drawing.Point(361, 140);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(30, 20);
            this.btnPassword.TabIndex = 44;
            this.btnPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // txbItemPassword
            // 
            txbItemPassword.BackColor = System.Drawing.Color.Gainsboro;
            txbItemPassword.Location = new System.Drawing.Point(6, 140);
            txbItemPassword.Name = "txbItemPassword";
            txbItemPassword.Size = new System.Drawing.Size(352, 20);
            txbItemPassword.TabIndex = 5;
            txbItemPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // txbItemUserName
            // 
            txbItemUserName.BackColor = System.Drawing.Color.Gainsboro;
            txbItemUserName.Location = new System.Drawing.Point(6, 89);
            txbItemUserName.Name = "txbItemUserName";
            txbItemUserName.Size = new System.Drawing.Size(377, 20);
            txbItemUserName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome de usuário ";
            // 
            // txbItemNome
            // 
            txbItemNome.BackColor = System.Drawing.Color.Gainsboro;
            txbItemNome.Location = new System.Drawing.Point(6, 34);
            txbItemNome.Name = "txbItemNome";
            txbItemNome.Size = new System.Drawing.Size(377, 20);
            txbItemNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // FrmAddItemLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 573);
            this.Controls.Add(this.panelAddLogin);
            this.Name = "FrmAddItemLogin";
            this.Text = "FrmAddItemLogin";
            this.Load += new System.EventHandler(this.FrmAddItemLogin_Load);
            this.panelAddLogin.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelAddTypeLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private static System.Windows.Forms.TextBox txbItemNome;
        private static System.Windows.Forms.TextBox txbItemURL;
        private static System.Windows.Forms.TextBox txbItemPassword;
        private static System.Windows.Forms.TextBox txbItemUserName;
        private static System.Windows.Forms.TextBox txtItemNote;
        private FontAwesome.Sharp.IconButton btnPassword;
    }
}