namespace SafeBox.Forms.SelectedItems
{
    partial class FrmItemNote
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
            this.panelItemNote = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelItemNote.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItemNote
            // 
            this.panelItemNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panelItemNote.Controls.Add(this.panel2);
            this.panelItemNote.Controls.Add(this.label1);
            this.panelItemNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelItemNote.Location = new System.Drawing.Point(0, 0);
            this.panelItemNote.Name = "panelItemNote";
            this.panelItemNote.Size = new System.Drawing.Size(800, 450);
            this.panelItemNote.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(txtNote);
            this.panel2.Controls.Add(this.lblNote);
            this.panel2.Controls.Add(txtName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 309);
            this.panel2.TabIndex = 2;
            // 
            // txtNote
            // 
            txtNote.BackColor = System.Drawing.Color.Gainsboro;
            txtNote.Location = new System.Drawing.Point(7, 90);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ReadOnly = true;
            txtNote.Size = new System.Drawing.Size(390, 199);
            txtNote.TabIndex = 9;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNote.Location = new System.Drawing.Point(4, 71);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(42, 18);
            this.lblNote.TabIndex = 8;
            this.lblNote.Text = "Note";
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.Color.Gainsboro;
            txtName.Location = new System.Drawing.Point(7, 38);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new System.Drawing.Size(390, 20);
            txtName.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informações sobre o item";
            // 
            // FrmItemNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelItemNote);
            this.Name = "FrmItemNote";
            this.Text = "FrmItemNote";
            this.Load += new System.EventHandler(this.FrmItemNote_Load);
            this.panelItemNote.ResumeLayout(false);
            this.panelItemNote.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItemNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label label2;
        private static System.Windows.Forms.TextBox txtNote;
        private static System.Windows.Forms.TextBox txtName;
    }
}