namespace SafeBox
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnFrmRegister = new System.Windows.Forms.Button();
            this.comboBoxLoginUserName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPassword = new FontAwesome.Sharp.IconButton();
            this.txtPasswordLogin = new SafeBox.Forms.User.RJTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seu cofre está bloqueado, \r\ninforme sua senha para continuar. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUnlock
            // 
            this.btnUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlock.Location = new System.Drawing.Point(90, 285);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(283, 37);
            this.btnUnlock.TabIndex = 2;
            this.btnUnlock.Text = "Desbloquear";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnFrmRegister
            // 
            this.btnFrmRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmRegister.Location = new System.Drawing.Point(149, 430);
            this.btnFrmRegister.Name = "btnFrmRegister";
            this.btnFrmRegister.Size = new System.Drawing.Size(137, 33);
            this.btnFrmRegister.TabIndex = 3;
            this.btnFrmRegister.Text = "cadastrar-se";
            this.btnFrmRegister.UseVisualStyleBackColor = true;
            this.btnFrmRegister.Click += new System.EventHandler(this.btnFrmRegister_Click);
            // 
            // comboBoxLoginUserName
            // 
            this.comboBoxLoginUserName.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxLoginUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLoginUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoginUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoginUserName.FormattingEnabled = true;
            this.comboBoxLoginUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxLoginUserName.Location = new System.Drawing.Point(121, 154);
            this.comboBoxLoginUserName.Name = "comboBoxLoginUserName";
            this.comboBoxLoginUserName.Size = new System.Drawing.Size(205, 26);
            this.comboBoxLoginUserName.TabIndex = 7;
            this.comboBoxLoginUserName.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(161, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nome de Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(192, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Senha ";
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
            this.btnPassword.Location = new System.Drawing.Point(334, 214);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(39, 30);
            this.btnPassword.TabIndex = 40;
            this.btnPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPasswordLogin.BorderColor = System.Drawing.Color.LawnGreen;
            this.txtPasswordLogin.BorderFocusColor = System.Drawing.SystemColors.Window;
            this.txtPasswordLogin.BorderRadius = 10;
            this.txtPasswordLogin.BorderSize = 2;
            this.txtPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordLogin.Location = new System.Drawing.Point(121, 213);
            this.txtPasswordLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordLogin.Multiline = false;
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPasswordLogin.PasswordChar = true;
            this.txtPasswordLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPasswordLogin.PlaceholderText = "";
            this.txtPasswordLogin.Size = new System.Drawing.Size(205, 31);
            this.txtPasswordLogin.TabIndex = 39;
            this.txtPasswordLogin.Texts = "";
            this.txtPasswordLogin.UnderlinedStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(449, 475);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLoginUserName);
            this.Controls.Add(this.btnFrmRegister);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnFrmRegister;
        private System.Windows.Forms.ComboBox comboBoxLoginUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Forms.User.RJTextBox txtPasswordLogin;
        private FontAwesome.Sharp.IconButton btnPassword;
    }
}

