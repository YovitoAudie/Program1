namespace Program1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.leftPanel.Controls.Add(this.buttonCheckout);
            this.leftPanel.Controls.Add(this.buttonHistory);
            this.leftPanel.Controls.Add(this.buttonEdit);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(300, 627);
            this.leftPanel.TabIndex = 0;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.FlatAppearance.BorderSize = 0;
            this.buttonCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCheckout.Image = ((System.Drawing.Image)(resources.GetObject("buttonCheckout.Image")));
            this.buttonCheckout.Location = new System.Drawing.Point(8, 371);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(290, 37);
            this.buttonCheckout.TabIndex = 4;
            this.buttonCheckout.Text = "        Checkout";
            this.buttonCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonHistory.Image")));
            this.buttonHistory.Location = new System.Drawing.Point(4, 292);
            this.buttonHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(294, 37);
            this.buttonHistory.TabIndex = 3;
            this.buttonHistory.Text = "         History";
            this.buttonHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(-3, 221);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(301, 37);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "          Manage";
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(300, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1092, 627);
            this.mainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 627);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonHistory;
        public System.Windows.Forms.Panel mainPanel;
    }
}

