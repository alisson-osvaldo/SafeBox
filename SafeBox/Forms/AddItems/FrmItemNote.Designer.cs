namespace SafeBox.Forms.AddItems
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
            this.panelAddNote = new System.Windows.Forms.Panel();
            this.flowLayoutPanelAddItemNote = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNote = new System.Windows.Forms.TextBox();
            this.btnSaveItem = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbItemURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAddNote.SuspendLayout();
            this.flowLayoutPanelAddItemNote.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddNote
            // 
            this.panelAddNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panelAddNote.Controls.Add(this.flowLayoutPanelAddItemNote);
            this.panelAddNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddNote.Location = new System.Drawing.Point(0, 0);
            this.panelAddNote.Name = "panelAddNote";
            this.panelAddNote.Size = new System.Drawing.Size(800, 450);
            this.panelAddNote.TabIndex = 0;
            // 
            // flowLayoutPanelAddItemNote
            // 
            this.flowLayoutPanelAddItemNote.AutoScroll = true;
            this.flowLayoutPanelAddItemNote.Controls.Add(this.panel1);
            this.flowLayoutPanelAddItemNote.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelAddItemNote.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelAddItemNote.Name = "flowLayoutPanelAddItemNote";
            this.flowLayoutPanelAddItemNote.Size = new System.Drawing.Size(400, 450);
            this.flowLayoutPanelAddItemNote.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSaveItem);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 531);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.txbNote);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 337);
            this.panel2.TabIndex = 0;
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
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(6, 36);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(339, 20);
            this.txbName.TabIndex = 2;
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
            // txbNote
            // 
            this.txbNote.Location = new System.Drawing.Point(6, 92);
            this.txbNote.Multiline = true;
            this.txbNote.Name = "txbNote";
            this.txbNote.Size = new System.Drawing.Size(339, 229);
            this.txbNote.TabIndex = 4;
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnSaveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSaveItem.FlatAppearance.BorderSize = 0;
            this.btnSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveItem.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(194)))), ((int)(((byte)(122)))));
            this.btnSaveItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveItem.IconSize = 30;
            this.btnSaveItem.Location = new System.Drawing.Point(43, 467);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(57, 45);
            this.btnSaveItem.TabIndex = 2;
            this.btnSaveItem.UseVisualStyleBackColor = false;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(136, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.txbItemURL);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(9, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 91);
            this.panel3.TabIndex = 4;
            // 
            // txbItemURL
            // 
            this.txbItemURL.Location = new System.Drawing.Point(3, 33);
            this.txbItemURL.Name = "txbItemURL";
            this.txbItemURL.Size = new System.Drawing.Size(342, 20);
            this.txbItemURL.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "URL";
            // 
            // FrmItemNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAddNote);
            this.Name = "FrmItemNote";
            this.Text = "FrmItemNote";
            this.panelAddNote.ResumeLayout(false);
            this.flowLayoutPanelAddItemNote.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddNote;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAddItemNote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private FontAwesome.Sharp.IconButton btnSaveItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbItemURL;
        private System.Windows.Forms.Label label4;
    }
}