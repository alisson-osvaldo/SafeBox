namespace SafeBox.Forms.AddItems
{
    partial class FrmAddItemNote
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
            this.panelAddNote = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            txbNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAddNote.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddNote
            // 
            this.panelAddNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panelAddNote.Controls.Add(this.panel2);
            this.panelAddNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddNote.Location = new System.Drawing.Point(0, 0);
            this.panelAddNote.Name = "panelAddNote";
            this.panelAddNote.Size = new System.Drawing.Size(800, 450);
            this.panelAddNote.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(txbNote);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(txbName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 337);
            this.panel2.TabIndex = 0;
            // 
            // txbNote
            // 
            txbNote.Location = new System.Drawing.Point(6, 92);
            txbNote.Multiline = true;
            txbNote.Name = "txbNote";
            txbNote.Size = new System.Drawing.Size(339, 229);
            txbNote.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note";
            // 
            // txbName
            // 
            txbName.Location = new System.Drawing.Point(6, 36);
            txbName.Name = "txbName";
            txbName.Size = new System.Drawing.Size(339, 20);
            txbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // FrmAddItemNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAddNote);
            this.Name = "FrmAddItemNote";
            this.Text = "FrmItemNote";
            this.Load += new System.EventHandler(this.FrmAddItemNote_Load);
            this.panelAddNote.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddNote;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private static System.Windows.Forms.TextBox txbNote;
        private System.Windows.Forms.Label label1;
        private static System.Windows.Forms.TextBox txbName;
    }
}