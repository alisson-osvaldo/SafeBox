namespace SafeBox.Forms.ListItems
{
    partial class FrmListLogin
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
            this.listBoxLogin = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxLogin
            // 
            this.listBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.listBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLogin.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxLogin.FormattingEnabled = true;
            this.listBoxLogin.IntegralHeight = false;
            this.listBoxLogin.ItemHeight = 20;
            this.listBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.listBoxLogin.Name = "listBoxLogin";
            this.listBoxLogin.Size = new System.Drawing.Size(270, 450);
            this.listBoxLogin.TabIndex = 0;
            this.listBoxLogin.SelectedIndexChanged += new System.EventHandler(this.listBoxLogin_SelectedIndexChanged);
            this.listBoxLogin.DoubleClick += new System.EventHandler(this.listBoxLogin_SelectedIndexChanged);
            // 
            // FrmListLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 450);
            this.Controls.Add(this.listBoxLogin);
            this.Name = "FrmListLogin";
            this.Text = "FrmListLogin";
            this.Load += new System.EventHandler(this.FrmListLogin_Load_1);
            this.DoubleClick += new System.EventHandler(this.listBoxLogin_SelectedIndexChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLogin;
    }
}