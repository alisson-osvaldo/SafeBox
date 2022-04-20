namespace SafeBox.Forms
{
    partial class FrmAddItem
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
            this.panelAddItem = new System.Windows.Forms.Panel();
            this.flowLayoutPanelAddItem = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAddType = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.panelAddItem.SuspendLayout();
            this.flowLayoutPanelAddItem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddItem
            // 
            this.panelAddItem.AutoSize = true;
            this.panelAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panelAddItem.Controls.Add(this.flowLayoutPanelAddItem);
            this.panelAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddItem.Location = new System.Drawing.Point(0, 0);
            this.panelAddItem.Name = "panelAddItem";
            this.panelAddItem.Size = new System.Drawing.Size(496, 450);
            this.panelAddItem.TabIndex = 0;
            this.panelAddItem.SizeChanged += new System.EventHandler(this.panelAddItem_SizeChanged);
            // 
            // flowLayoutPanelAddItem
            // 
            this.flowLayoutPanelAddItem.AutoScroll = true;
            this.flowLayoutPanelAddItem.Controls.Add(this.panel1);
            this.flowLayoutPanelAddItem.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAddItem.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelAddItem.Name = "flowLayoutPanelAddItem";
            this.flowLayoutPanelAddItem.Size = new System.Drawing.Size(408, 570);
            this.flowLayoutPanelAddItem.TabIndex = 0;
            this.flowLayoutPanelAddItem.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panelAddType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxItems);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 982);
            this.panel1.TabIndex = 2;
            // 
            // panelAddType
            // 
            this.panelAddType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panelAddType.Location = new System.Drawing.Point(3, 67);
            this.panelAddType.Name = "panelAddType";
            this.panelAddType.Size = new System.Drawing.Size(377, 661);
            this.panelAddType.TabIndex = 2;
            this.panelAddType.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddType_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(133, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Item";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Items.AddRange(new object[] {
            "Login",
            "Secure Note"});
            this.comboBoxItems.Location = new System.Drawing.Point(59, 40);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(264, 21);
            this.comboBoxItems.TabIndex = 1;
            this.comboBoxItems.Text = "Login";
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.panelAddItem);
            this.Name = "FrmAddItem";
            this.Text = "FrmAddItem";
            this.Load += new System.EventHandler(this.FrmAddItem_Load);
            this.SizeChanged += new System.EventHandler(this.FrmAddItem_SizeChanged);
            this.panelAddItem.ResumeLayout(false);
            this.flowLayoutPanelAddItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAddItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAddType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAddItem;
    }
}