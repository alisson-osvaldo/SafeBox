﻿namespace SafeBox.Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAddItem.SuspendLayout();
            this.flowLayoutPanelAddItem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddItem
            // 
            this.panelAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panelAddItem.Controls.Add(this.flowLayoutPanelAddItem);
            this.panelAddItem.Location = new System.Drawing.Point(1, 1);
            this.panelAddItem.Name = "panelAddItem";
            this.panelAddItem.Size = new System.Drawing.Size(495, 452);
            this.panelAddItem.TabIndex = 0;
            // 
            // flowLayoutPanelAddItem
            // 
            this.flowLayoutPanelAddItem.AutoScroll = true;
            this.flowLayoutPanelAddItem.Controls.Add(this.panel1);
            this.flowLayoutPanelAddItem.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAddItem.Location = new System.Drawing.Point(38, 3);
            this.flowLayoutPanelAddItem.Name = "flowLayoutPanelAddItem";
            this.flowLayoutPanelAddItem.Size = new System.Drawing.Size(418, 450);
            this.flowLayoutPanelAddItem.TabIndex = 0;
            this.flowLayoutPanelAddItem.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(147, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Item";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(398, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 400);
            this.panel1.TabIndex = 2;
            // 
            // FrmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.panelAddItem);
            this.Name = "FrmAddItem";
            this.Text = "FrmAddItem";
            this.panelAddItem.ResumeLayout(false);
            this.flowLayoutPanelAddItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAddItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}