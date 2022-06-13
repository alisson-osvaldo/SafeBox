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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnPasswordStrength = new System.Windows.Forms.Button();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.btnPassword = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserNameRegister = new SafeBox.Forms.User.RJTextBox();
            this.txtCreatePassword = new SafeBox.Forms.User.RJTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(451, 424);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(161, 48);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Confirmar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnPasswordStrength
            // 
            this.btnPasswordStrength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPasswordStrength.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPasswordStrength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordStrength.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordStrength.Location = new System.Drawing.Point(312, 287);
            this.btnPasswordStrength.Margin = new System.Windows.Forms.Padding(4);
            this.btnPasswordStrength.Name = "btnPasswordStrength";
            this.btnPasswordStrength.Size = new System.Drawing.Size(199, 34);
            this.btnPasswordStrength.TabIndex = 25;
            this.btnPasswordStrength.Text = "Verificar Força da Senha";
            this.btnPasswordStrength.UseVisualStyleBackColor = false;
            this.btnPasswordStrength.Click += new System.EventHandler(this.btnPasswordStrength_Click);
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordStrength.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPasswordStrength.Location = new System.Drawing.Point(519, 295);
            this.lblPasswordStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(0, 20);
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
            this.btnPassword.Location = new System.Drawing.Point(740, 231);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(5);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(52, 37);
            this.btnPassword.TabIndex = 27;
            this.btnPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnPassword, "Alternar Visibilidade");
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(485, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Senha ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(448, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nome de Usuário";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 49);
            this.panel1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(459, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cadastro";
            // 
            // txtUserNameRegister
            // 
            this.txtUserNameRegister.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUserNameRegister.BorderColor = System.Drawing.Color.LawnGreen;
            this.txtUserNameRegister.BorderFocusColor = System.Drawing.SystemColors.Window;
            this.txtUserNameRegister.BorderRadius = 10;
            this.txtUserNameRegister.BorderSize = 2;
            this.txtUserNameRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameRegister.ForeColor = System.Drawing.Color.Black;
            this.txtUserNameRegister.Location = new System.Drawing.Point(312, 144);
            this.txtUserNameRegister.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserNameRegister.Multiline = false;
            this.txtUserNameRegister.Name = "txtUserNameRegister";
            this.txtUserNameRegister.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtUserNameRegister.PasswordChar = false;
            this.txtUserNameRegister.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserNameRegister.PlaceholderText = "Digite um nome de usuário";
            this.txtUserNameRegister.Size = new System.Drawing.Size(417, 35);
            this.txtUserNameRegister.TabIndex = 35;
            this.txtUserNameRegister.Texts = "";
            this.txtUserNameRegister.UnderlinedStyle = false;
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCreatePassword.BorderColor = System.Drawing.Color.LawnGreen;
            this.txtCreatePassword.BorderFocusColor = System.Drawing.SystemColors.Window;
            this.txtCreatePassword.BorderRadius = 10;
            this.txtCreatePassword.BorderSize = 2;
            this.txtCreatePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePassword.ForeColor = System.Drawing.Color.Black;
            this.txtCreatePassword.Location = new System.Drawing.Point(312, 230);
            this.txtCreatePassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtCreatePassword.Multiline = false;
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtCreatePassword.PasswordChar = true;
            this.txtCreatePassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCreatePassword.PlaceholderText = "Digite uma senha";
            this.txtCreatePassword.Size = new System.Drawing.Size(417, 35);
            this.txtCreatePassword.TabIndex = 32;
            this.txtCreatePassword.Texts = "";
            this.txtCreatePassword.UnderlinedStyle = false;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserNameRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCreatePassword);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.btnPasswordStrength);
            this.Controls.Add(this.btnRegister);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafeBox - Cadastro";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnPasswordStrength;
        private System.Windows.Forms.Label lblPasswordStrength;
        private FontAwesome.Sharp.IconButton btnPassword;
        private Forms.User.RJTextBox txtCreatePassword;
        private System.Windows.Forms.Label label2;
        private Forms.User.RJTextBox txtUserNameRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}