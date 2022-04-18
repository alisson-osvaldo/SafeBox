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
            this.listBoxNote.FormattingEnabled = true;
            this.listBoxNote.IntegralHeight = false;
            this.listBoxNote.Location = new System.Drawing.Point(12, 12);
            this.listBoxNote.Name = "listBoxNote";
            this.listBoxNote.Size = new System.Drawing.Size(249, 342);
            this.listBoxNote.TabIndex = 1;
            this.listBoxNote.SelectedIndexChanged += new System.EventHandler(this.listBoxNote_SelectedIndexChanged);
            // 
            // FrmListNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxNote);
            this.Name = "FrmListNota";
            this.Text = "FrmListNota";
            this.Load += new System.EventHandler(this.FrmListNota_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNote;
    }
}