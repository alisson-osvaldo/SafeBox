namespace SafeBox.Forms
{
    partial class FrmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfo));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblVideo = new System.Windows.Forms.Label();
            this.btnVideo = new FontAwesome.Sharp.IconButton();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnLinkedin = new FontAwesome.Sharp.IconButton();
            this.btnGitHub = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panelInfo.Controls.Add(this.lblVideo);
            this.panelInfo.Controls.Add(this.btnVideo);
            this.panelInfo.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelInfo.Controls.Add(this.btnLinkedin);
            this.panelInfo.Controls.Add(this.btnGitHub);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.textBox1);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(800, 450);
            this.panelInfo.TabIndex = 0;
            this.panelInfo.TabStop = true;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblVideo.Location = new System.Drawing.Point(625, 161);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(122, 15);
            this.lblVideo.TabIndex = 9;
            this.lblVideo.Text = "Não Clique Aqui ->";
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.IconChar = FontAwesome.Sharp.IconChar.Ghost;
            this.btnVideo.IconColor = System.Drawing.Color.Red;
            this.btnVideo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVideo.IconSize = 30;
            this.btnVideo.Location = new System.Drawing.Point(744, 148);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(45, 38);
            this.btnVideo.TabIndex = 8;
            this.btnVideo.UseVisualStyleBackColor = false;
            this.btnVideo.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 192);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(800, 258);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            this.axWindowsMediaPlayer1.TabStop = false;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // btnLinkedin
            // 
            this.btnLinkedin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLinkedin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLinkedin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkedin.IconChar = FontAwesome.Sharp.IconChar.Linkedin;
            this.btnLinkedin.IconColor = System.Drawing.Color.LawnGreen;
            this.btnLinkedin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLinkedin.IconSize = 30;
            this.btnLinkedin.Location = new System.Drawing.Point(69, 148);
            this.btnLinkedin.Name = "btnLinkedin";
            this.btnLinkedin.Size = new System.Drawing.Size(45, 38);
            this.btnLinkedin.TabIndex = 6;
            this.btnLinkedin.UseVisualStyleBackColor = false;
            this.btnLinkedin.Click += new System.EventHandler(this.btnLinkedin_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGitHub.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.btnGitHub.IconColor = System.Drawing.Color.LawnGreen;
            this.btnGitHub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGitHub.IconSize = 30;
            this.btnGitHub.Location = new System.Drawing.Point(18, 148);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(45, 38);
            this.btnGitHub.TabIndex = 5;
            this.btnGitHub.UseVisualStyleBackColor = false;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contatos do Desenvolvedor:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LawnGreen;
            this.textBox1.Location = new System.Drawing.Point(17, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(711, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Essa ferramento foi desenvolvida com intuito de ajudar a organizar suas senhas e " +
    "notas e  de forma pratica e segura.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao SafeBox";
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInfo);
            this.MaximizeBox = false;
            this.Name = "FrmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInfo";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnLinkedin;
        private FontAwesome.Sharp.IconButton btnGitHub;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private FontAwesome.Sharp.IconButton btnVideo;
        private System.Windows.Forms.Label lblVideo;
    }
}