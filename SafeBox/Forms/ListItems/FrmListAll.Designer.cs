namespace SafeBox.Forms.ListItems
{
    partial class FrmListAll
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
            this.listBoxAll = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxAll
            // 
            this.listBoxAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.listBoxAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAll.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBoxAll.FormattingEnabled = true;
            this.listBoxAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxAll.IntegralHeight = false;
            this.listBoxAll.ItemHeight = 23;
            this.listBoxAll.Location = new System.Drawing.Point(0, 0);
            this.listBoxAll.Name = "listBoxAll";
            this.listBoxAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxAll.Size = new System.Drawing.Size(272, 372);
            this.listBoxAll.TabIndex = 1;
            this.listBoxAll.SelectedIndexChanged += new System.EventHandler(this.listBoxAll_SelectedIndexChanged);
            // 
            // FrmListAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 372);
            this.Controls.Add(this.listBoxAll);
            this.Name = "FrmListAll";
            this.Text = "FrmListAll";
            this.Load += new System.EventHandler(this.FrmListAll_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAll;
    }
}