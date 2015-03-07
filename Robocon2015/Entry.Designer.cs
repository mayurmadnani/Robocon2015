namespace Robocon2015
{
    partial class Entry
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.combobox_red = new System.Windows.Forms.ComboBox();
            this.combobox_blue = new System.Windows.Forms.ComboBox();
            this.lbl_matchtype = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.LToolStripMenuItem,
            this.SLToolStripMenuItem,
            this.QFToolStripMenuItem,
            this.SFToolStripMenuItem,
            this.startMatchToolStripMenuItem,
            this.FToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 744);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.exitToolStripMenuItem.Text = "System";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // LToolStripMenuItem
            // 
            this.LToolStripMenuItem.Name = "LToolStripMenuItem";
            this.LToolStripMenuItem.Size = new System.Drawing.Size(25, 20);
            this.LToolStripMenuItem.Text = "L";
            this.LToolStripMenuItem.Click += new System.EventHandler(this.LToolStripMenuItem_Click);
            // 
            // SLToolStripMenuItem
            // 
            this.SLToolStripMenuItem.Name = "SLToolStripMenuItem";
            this.SLToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.SLToolStripMenuItem.Text = "SL";
            this.SLToolStripMenuItem.Click += new System.EventHandler(this.SLToolStripMenuItem_Click);
            // 
            // QFToolStripMenuItem
            // 
            this.QFToolStripMenuItem.Name = "QFToolStripMenuItem";
            this.QFToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.QFToolStripMenuItem.Text = "QF";
            this.QFToolStripMenuItem.Click += new System.EventHandler(this.QFToolStripMenuItem_Click);
            // 
            // SFToolStripMenuItem
            // 
            this.SFToolStripMenuItem.Name = "SFToolStripMenuItem";
            this.SFToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.SFToolStripMenuItem.Text = "SF";
            this.SFToolStripMenuItem.Click += new System.EventHandler(this.SFToolStripMenuItem_Click);
            // 
            // startMatchToolStripMenuItem
            // 
            this.startMatchToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.startMatchToolStripMenuItem.Name = "startMatchToolStripMenuItem";
            this.startMatchToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.startMatchToolStripMenuItem.Text = "Start Match";
            this.startMatchToolStripMenuItem.Click += new System.EventHandler(this.startMatchToolStripMenuItem_Click);
            // 
            // FToolStripMenuItem1
            // 
            this.FToolStripMenuItem1.Name = "FToolStripMenuItem1";
            this.FToolStripMenuItem1.Size = new System.Drawing.Size(25, 20);
            this.FToolStripMenuItem1.Text = "F";
            this.FToolStripMenuItem1.Click += new System.EventHandler(this.FToolStripMenuItem1_Click);
            // 
            // combobox_red
            // 
            this.combobox_red.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combobox_red.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_red.FormattingEnabled = true;
            this.combobox_red.Location = new System.Drawing.Point(607, 747);
            this.combobox_red.Name = "combobox_red";
            this.combobox_red.Size = new System.Drawing.Size(338, 21);
            this.combobox_red.TabIndex = 5;
            // 
            // combobox_blue
            // 
            this.combobox_blue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combobox_blue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_blue.DisplayMember = "College";
            this.combobox_blue.FormattingEnabled = true;
            this.combobox_blue.Location = new System.Drawing.Point(293, 747);
            this.combobox_blue.Name = "combobox_blue";
            this.combobox_blue.Size = new System.Drawing.Size(308, 21);
            this.combobox_blue.TabIndex = 7;
            this.combobox_blue.ValueMember = "College";
            // 
            // lbl_matchtype
            // 
            this.lbl_matchtype.AutoSize = true;
            this.lbl_matchtype.Location = new System.Drawing.Point(211, 750);
            this.lbl_matchtype.Name = "lbl_matchtype";
            this.lbl_matchtype.Size = new System.Drawing.Size(19, 13);
            this.lbl_matchtype.TabIndex = 10;
            this.lbl_matchtype.Text = "??";
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Robocon2015.Properties.Resources.Entry;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lbl_matchtype);
            this.Controls.Add(this.combobox_blue);
            this.Controls.Add(this.combobox_red);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox combobox_red;
        private System.Windows.Forms.ComboBox combobox_blue;
        private System.Windows.Forms.ToolStripMenuItem LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SLToolStripMenuItem;
        private System.Windows.Forms.Label lbl_matchtype;
        private System.Windows.Forms.ToolStripMenuItem QFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FToolStripMenuItem1;
    }
}

