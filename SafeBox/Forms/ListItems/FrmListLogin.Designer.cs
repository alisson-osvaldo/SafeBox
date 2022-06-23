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
            listBoxLogin = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxLogin
            // 
            listBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            listBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listBoxLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            listBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            listBoxLogin.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listBoxLogin.ForeColor = System.Drawing.SystemColors.Window;
            listBoxLogin.FormattingEnabled = true;
            listBoxLogin.IntegralHeight = false;
            listBoxLogin.ItemHeight = 20;
            listBoxLogin.Location = new System.Drawing.Point(0, 0);
            listBoxLogin.Name = "listBoxLogin";
            listBoxLogin.Size = new System.Drawing.Size(270, 450);
            listBoxLogin.TabIndex = 0;
            listBoxLogin.SelectedIndexChanged += new System.EventHandler(listBoxLogin_SelectedIndexChanged);
            listBoxLogin.DoubleClick += new System.EventHandler(listBoxLogin_SelectedIndexChanged);
            // 
            // FrmListLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 450);
            this.Controls.Add(listBoxLogin);
            this.Name = "FrmListLogin";
            this.Text = "FrmListLogin";
            this.Load += new System.EventHandler(this.FrmListLogin_Load_1);
            this.DoubleClick += new System.EventHandler(listBoxLogin_SelectedIndexChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private static System.Windows.Forms.ListBox listBoxLogin;
    }
}