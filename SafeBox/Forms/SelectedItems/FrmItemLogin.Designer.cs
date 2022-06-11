namespace SafeBox.Forms.SelectedItems
{
    partial class FrmItemLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCopyUserName = new FontAwesome.Sharp.IconButton();
            txtPassword = new System.Windows.Forms.TextBox();
            txtNote = new System.Windows.Forms.TextBox();
            txtURL = new System.Windows.Forms.TextBox();
            txtUserName = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            this.btnCopyPassword = new FontAwesome.Sharp.IconButton();
            this.btnPassword = new FontAwesome.Sharp.IconButton();
            lblNote = new System.Windows.Forms.Label();
            lblURL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btnCopyUserName);
            this.panel2.Controls.Add(txtPassword);
            this.panel2.Controls.Add(txtNote);
            this.panel2.Controls.Add(txtURL);
            this.panel2.Controls.Add(txtUserName);
            this.panel2.Controls.Add(txtName);
            this.panel2.Controls.Add(this.btnCopyPassword);
            this.panel2.Controls.Add(this.btnPassword);
            this.panel2.Controls.Add(lblNote);
            this.panel2.Controls.Add(lblURL);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 348);
            this.panel2.TabIndex = 1;
            // 
            // btnCopyUserName
            // 
            this.btnCopyUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnCopyUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCopyUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyUserName.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCopyUserName.FlatAppearance.BorderSize = 0;
            this.btnCopyUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyUserName.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnCopyUserName.IconColor = System.Drawing.Color.LawnGreen;
            this.btnCopyUserName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopyUserName.IconSize = 30;
            this.btnCopyUserName.Location = new System.Drawing.Point(372, 87);
            this.btnCopyUserName.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyUserName.Name = "btnCopyUserName";
            this.btnCopyUserName.Size = new System.Drawing.Size(30, 30);
            this.btnCopyUserName.TabIndex = 53;
            this.btnCopyUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnCopyUserName, "Copiar");
            this.btnCopyUserName.UseVisualStyleBackColor = false;
            this.btnCopyUserName.Click += new System.EventHandler(this.btnCopyUserName_Click);
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.Gainsboro;
            txtPassword.Location = new System.Drawing.Point(7, 151);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new System.Drawing.Size(331, 20);
            txtPassword.TabIndex = 52;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtNote
            // 
            txtNote.BackColor = System.Drawing.Color.Gainsboro;
            txtNote.Location = new System.Drawing.Point(7, 256);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ReadOnly = true;
            txtNote.Size = new System.Drawing.Size(387, 89);
            txtNote.TabIndex = 51;
            // 
            // txtURL
            // 
            txtURL.BackColor = System.Drawing.Color.Gainsboro;
            txtURL.Location = new System.Drawing.Point(7, 205);
            txtURL.Name = "txtURL";
            txtURL.ReadOnly = true;
            txtURL.Size = new System.Drawing.Size(387, 20);
            txtURL.TabIndex = 50;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = System.Drawing.Color.Gainsboro;
            txtUserName.Location = new System.Drawing.Point(7, 93);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new System.Drawing.Size(361, 20);
            txtUserName.TabIndex = 48;
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.Color.Gainsboro;
            txtName.Location = new System.Drawing.Point(7, 38);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new System.Drawing.Size(387, 20);
            txtName.TabIndex = 47;
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnCopyPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCopyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyPassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCopyPassword.FlatAppearance.BorderSize = 0;
            this.btnCopyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyPassword.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnCopyPassword.IconColor = System.Drawing.Color.LawnGreen;
            this.btnCopyPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopyPassword.IconSize = 30;
            this.btnCopyPassword.Location = new System.Drawing.Point(372, 140);
            this.btnCopyPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(30, 40);
            this.btnCopyPassword.TabIndex = 46;
            this.btnCopyPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnCopyPassword, "Copiar");
            this.btnCopyPassword.UseVisualStyleBackColor = false;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopy_Click);
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
            this.btnPassword.Location = new System.Drawing.Point(338, 151);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(30, 20);
            this.btnPassword.TabIndex = 43;
            this.btnPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnPassword, "Alternar Visibilidade");
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNote.ForeColor = System.Drawing.SystemColors.Window;
            lblNote.Location = new System.Drawing.Point(4, 237);
            lblNote.Name = "lblNote";
            lblNote.Size = new System.Drawing.Size(42, 18);
            lblNote.TabIndex = 8;
            lblNote.Text = "Note";
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblURL.ForeColor = System.Drawing.SystemColors.Window;
            lblURL.Location = new System.Drawing.Point(4, 186);
            lblURL.Name = "lblURL";
            lblURL.Size = new System.Drawing.Size(41, 18);
            lblURL.TabIndex = 6;
            lblURL.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(4, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informações sobre o item";
            // 
            // FrmItemLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmItemLogin";
            this.Text = "FrmItemLogin";
            this.Load += new System.EventHandler(this.FrmItemLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnPassword;
        private FontAwesome.Sharp.IconButton btnCopyPassword;
        private FontAwesome.Sharp.IconButton btnCopyUserName;
        private System.Windows.Forms.ToolTip toolTip1;
        private static System.Windows.Forms.Label lblNote;
        private static System.Windows.Forms.Label lblURL;
        private static System.Windows.Forms.TextBox txtName;
        private static System.Windows.Forms.TextBox txtNote;
        private static System.Windows.Forms.TextBox txtURL;
        private static System.Windows.Forms.TextBox txtUserName;
        private static System.Windows.Forms.TextBox txtPassword;
    }
}