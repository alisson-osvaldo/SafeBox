﻿namespace SafeBox.Forms.ListItems
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
            this.listBoxLogin.FormattingEnabled = true;
            this.listBoxLogin.IntegralHeight = false;
            this.listBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.listBoxLogin.Name = "listBoxLogin";
            this.listBoxLogin.Size = new System.Drawing.Size(249, 342);
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