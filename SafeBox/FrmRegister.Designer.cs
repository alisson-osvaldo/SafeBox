namespace SafeBox
{
    partial class FrmRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnPasswordStrength = new System.Windows.Forms.Button();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.btnPassword = new FontAwesome.Sharp.IconButton();
            this.txtUserNameRegister = new SafeBox.Forms.User.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreatePassword = new SafeBox.Forms.User.RJTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(331, 365);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(121, 39);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Confirmar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnPasswordStrength
            // 
            this.btnPasswordStrength.Location = new System.Drawing.Point(273, 240);
            this.btnPasswordStrength.Name = "btnPasswordStrength";
            this.btnPasswordStrength.Size = new System.Drawing.Size(186, 28);
            this.btnPasswordStrength.TabIndex = 25;
            this.btnPasswordStrength.Text = "Verificar Força da Senha";
            this.btnPasswordStrength.UseVisualStyleBackColor = true;
            this.btnPasswordStrength.Click += new System.EventHandler(this.btnPasswordStrength_Click);
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordStrength.Location = new System.Drawing.Point(463, 312);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(0, 16);
            this.lblPasswordStrength.TabIndex = 26;
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
            this.btnPassword.Location = new System.Drawing.Point(612, 192);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(39, 30);
            this.btnPassword.TabIndex = 27;
            this.btnPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // txtUserNameRegister
            // 
            this.txtUserNameRegister.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUserNameRegister.BorderColor = System.Drawing.Color.LawnGreen;
            this.txtUserNameRegister.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserNameRegister.BorderRadius = 10;
            this.txtUserNameRegister.BorderSize = 2;
            this.txtUserNameRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameRegister.ForeColor = System.Drawing.Color.Black;
            this.txtUserNameRegister.Location = new System.Drawing.Point(269, 124);
            this.txtUserNameRegister.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserNameRegister.Multiline = false;
            this.txtUserNameRegister.Name = "txtUserNameRegister";
            this.txtUserNameRegister.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtUserNameRegister.PasswordChar = false;
            this.txtUserNameRegister.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserNameRegister.PlaceholderText = "";
            this.txtUserNameRegister.Size = new System.Drawing.Size(333, 35);
            this.txtUserNameRegister.TabIndex = 30;
            this.txtUserNameRegister.Texts = "";
            this.txtUserNameRegister.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(374, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nome de Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(398, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Senha ";
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCreatePassword.BorderColor = System.Drawing.Color.LawnGreen;
            this.txtCreatePassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCreatePassword.BorderRadius = 10;
            this.txtCreatePassword.BorderSize = 2;
            this.txtCreatePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreatePassword.Location = new System.Drawing.Point(269, 192);
            this.txtCreatePassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtCreatePassword.Multiline = false;
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtCreatePassword.PasswordChar = false;
            this.txtCreatePassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCreatePassword.PlaceholderText = "";
            this.txtCreatePassword.Size = new System.Drawing.Size(333, 35);
            this.txtCreatePassword.TabIndex = 32;
            this.txtCreatePassword.Texts = "";
            this.txtCreatePassword.UnderlinedStyle = false;
            this.txtCreatePassword._TextChanged += new System.EventHandler(this.txtPassword__TextChanged);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCreatePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserNameRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.btnPasswordStrength);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnPasswordStrength;
        private System.Windows.Forms.Label lblPasswordStrength;
        private FontAwesome.Sharp.IconButton btnPassword;
        private Forms.User.RJTextBox txtUserNameRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Forms.User.RJTextBox txtCreatePassword;
    }
}