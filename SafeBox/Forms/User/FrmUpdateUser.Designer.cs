namespace SafeBox.Forms.User
{
    partial class FrmUpdateUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateUser));
            this.panelUpdateUser = new System.Windows.Forms.Panel();
            this.btnPasswordStrength = new System.Windows.Forms.Button();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.txtNewPassword = new SafeBox.Forms.User.RJTextBox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.txtNameUser = new SafeBox.Forms.User.RJTextBox();
            this.btnPassword = new FontAwesome.Sharp.IconButton();
            this.txtPassword = new SafeBox.Forms.User.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelUpdateUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUpdateUser
            // 
            this.panelUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panelUpdateUser.Controls.Add(this.btnPasswordStrength);
            this.panelUpdateUser.Controls.Add(this.lblPasswordStrength);
            this.panelUpdateUser.Controls.Add(this.txtNewPassword);
            this.panelUpdateUser.Controls.Add(this.btnDelete);
            this.panelUpdateUser.Controls.Add(this.txtNameUser);
            this.panelUpdateUser.Controls.Add(this.btnPassword);
            this.panelUpdateUser.Controls.Add(this.txtPassword);
            this.panelUpdateUser.Controls.Add(this.label5);
            this.panelUpdateUser.Controls.Add(this.label4);
            this.panelUpdateUser.Controls.Add(this.btnSave);
            this.panelUpdateUser.Controls.Add(this.label3);
            this.panelUpdateUser.Controls.Add(this.label2);
            this.panelUpdateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUpdateUser.Location = new System.Drawing.Point(0, 0);
            this.panelUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.panelUpdateUser.Name = "panelUpdateUser";
            this.panelUpdateUser.Size = new System.Drawing.Size(474, 446);
            this.panelUpdateUser.TabIndex = 0;
            // 
            // btnPasswordStrength
            // 
            this.btnPasswordStrength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPasswordStrength.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasswordStrength.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPasswordStrength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordStrength.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordStrength.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPasswordStrength.Location = new System.Drawing.Point(74, 244);
            this.btnPasswordStrength.Margin = new System.Windows.Forms.Padding(4);
            this.btnPasswordStrength.Name = "btnPasswordStrength";
            this.btnPasswordStrength.Size = new System.Drawing.Size(199, 34);
            this.btnPasswordStrength.TabIndex = 26;
            this.btnPasswordStrength.Text = "Verificar Força da Senha";
            this.btnPasswordStrength.UseVisualStyleBackColor = false;
            this.btnPasswordStrength.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic);
            this.lblPasswordStrength.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPasswordStrength.Location = new System.Drawing.Point(280, 251);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(0, 20);
            this.lblPasswordStrength.TabIndex = 25;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNewPassword.BorderColor = System.Drawing.Color.LawnGreen;
            this.txtNewPassword.BorderFocusColor = System.Drawing.SystemColors.Window;
            this.txtNewPassword.BorderRadius = 10;
            this.txtNewPassword.BorderSize = 2;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPassword.Location = new System.Drawing.Point(74, 192);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewPassword.Multiline = false;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtNewPassword.PasswordChar = true;
            this.txtNewPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPassword.PlaceholderText = "Digite sua nova senha";
            this.txtNewPassword.Size = new System.Drawing.Size(333, 35);
            this.txtNewPassword.TabIndex = 23;
            this.txtNewPassword.Texts = "";
            this.txtNewPassword.UnderlinedStyle = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 30;
            this.btnDelete.Location = new System.Drawing.Point(209, 392);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnDelete, "Deletar");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNameUser
            // 
            this.txtNameUser.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNameUser.BorderColor = System.Drawing.Color.LawnGreen;
            this.txtNameUser.BorderFocusColor = System.Drawing.SystemColors.Window;
            this.txtNameUser.BorderRadius = 10;
            this.txtNameUser.BorderSize = 2;
            this.txtNameUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUser.ForeColor = System.Drawing.Color.Black;
            this.txtNameUser.Location = new System.Drawing.Point(74, 79);
            this.txtNameUser.Margin = new System.Windows.Forms.Padding(5);
            this.txtNameUser.Multiline = false;
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtNameUser.PasswordChar = false;
            this.txtNameUser.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNameUser.PlaceholderText = "";
            this.txtNameUser.Size = new System.Drawing.Size(333, 35);
            this.txtNameUser.TabIndex = 22;
            this.txtNameUser.Texts = "";
            this.txtNameUser.UnderlinedStyle = false;
            // 
            // btnPassword
            // 
            this.btnPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnPassword.IconColor = System.Drawing.Color.Red;
            this.btnPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPassword.IconSize = 30;
            this.btnPassword.Location = new System.Drawing.Point(416, 197);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(39, 30);
            this.btnPassword.TabIndex = 21;
            this.btnPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnPassword, "Alternar Visibilidade");
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.BorderColor = System.Drawing.Color.LawnGreen;
            this.txtPassword.BorderFocusColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(74, 134);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Digite sua senha atual";
            this.txtPassword.Size = new System.Drawing.Size(333, 35);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(177, 370);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Deletar Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(195, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Senha Atual";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(180, 310);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Salvar";
            this.toolTip1.SetToolTip(this.btnSave, "Salvar todas as alterações");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(179, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome de Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(199, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nova Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atualizar Conta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 40);
            this.panel1.TabIndex = 22;
            // 
            // FrmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(474, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUpdateUser);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafeBox - Atualizar Conta";
            this.Load += new System.EventHandler(this.FrmUpdateUser_Load);
            this.panelUpdateUser.ResumeLayout(false);
            this.panelUpdateUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpdateUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.Label label5;
        private RJTextBox txtPassword;
        private FontAwesome.Sharp.IconButton btnPassword;
        private System.Windows.Forms.Panel panel1;
        private RJTextBox txtNameUser;
        private RJTextBox txtNewPassword;
        private System.Windows.Forms.Label lblPasswordStrength;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnPasswordStrength;
    }
}