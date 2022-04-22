namespace SafeBox.Forms.ListItems
{
    partial class FrmListNote
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
            this.listBoxNote = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxNote
            // 
            this.listBoxNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.listBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNote.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNote.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBoxNote.FormattingEnabled = true;
            this.listBoxNote.IntegralHeight = false;
            this.listBoxNote.ItemHeight = 23;
            this.listBoxNote.Location = new System.Drawing.Point(0, 0);
            this.listBoxNote.Name = "listBoxNote";
            this.listBoxNote.Size = new System.Drawing.Size(272, 450);
            this.listBoxNote.TabIndex = 1;
            this.listBoxNote.SelectedIndexChanged += new System.EventHandler(this.listBoxNote_SelectedIndexChanged);
            // 
            // FrmListNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 450);
            this.Controls.Add(this.listBoxNote);
            this.Name = "FrmListNote";
            this.Text = "FrmListNota";
            this.Load += new System.EventHandler(this.FrmListNota_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNote;
    }
}