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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combobox_red = new System.Windows.Forms.ComboBox();
            this.combobox_blue = new System.Windows.Forms.ComboBox();
            this.lbl_matchtype = new System.Windows.Forms.Label();
            this.combobox_round = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.pToolStripMenuItem,
            this.qToolStripMenuItem,
            this.sToolStripMenuItem,
            this.fToolStripMenuItem,
            this.startMatchToolStripMenuItem});
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
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(26, 20);
            this.pToolStripMenuItem.Text = "P";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // qToolStripMenuItem
            // 
            this.qToolStripMenuItem.Name = "qToolStripMenuItem";
            this.qToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.qToolStripMenuItem.Text = "Q";
            this.qToolStripMenuItem.Click += new System.EventHandler(this.qToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(25, 20);
            this.sToolStripMenuItem.Text = "S";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(25, 20);
            this.fToolStripMenuItem.Text = "F";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // startMatchToolStripMenuItem
            // 
            this.startMatchToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.startMatchToolStripMenuItem.Name = "startMatchToolStripMenuItem";
            this.startMatchToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.startMatchToolStripMenuItem.Text = "Start Match";
            this.startMatchToolStripMenuItem.Click += new System.EventHandler(this.startMatchToolStripMenuItem_Click);
            // 
            // combobox_red
            // 
            this.combobox_red.FormattingEnabled = true;
            this.combobox_red.Location = new System.Drawing.Point(256, 747);
            this.combobox_red.Name = "combobox_red";
            this.combobox_red.Size = new System.Drawing.Size(303, 21);
            this.combobox_red.TabIndex = 5;
            // 
            // combobox_blue
            // 
            this.combobox_blue.DisplayMember = "College";
            this.combobox_blue.FormattingEnabled = true;
            this.combobox_blue.Location = new System.Drawing.Point(576, 747);
            this.combobox_blue.Name = "combobox_blue";
            this.combobox_blue.Size = new System.Drawing.Size(280, 21);
            this.combobox_blue.TabIndex = 7;
            this.combobox_blue.ValueMember = "College";
            // 
            // lbl_matchtype
            // 
            this.lbl_matchtype.AutoSize = true;
            this.lbl_matchtype.Location = new System.Drawing.Point(180, 750);
            this.lbl_matchtype.Name = "lbl_matchtype";
            this.lbl_matchtype.Size = new System.Drawing.Size(70, 13);
            this.lbl_matchtype.TabIndex = 10;
            this.lbl_matchtype.Text = "Match Type?";
            // 
            // combobox_round
            // 
            this.combobox_round.FormattingEnabled = true;
            this.combobox_round.Items.AddRange(new object[] {
            "1 Round",
            "2 Rounds",
            "3 Rounds"});
            this.combobox_round.Location = new System.Drawing.Point(862, 747);
            this.combobox_round.Name = "combobox_round";
            this.combobox_round.Size = new System.Drawing.Size(74, 21);
            this.combobox_round.TabIndex = 11;
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.combobox_round);
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
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qToolStripMenuItem;
        private System.Windows.Forms.Label lbl_matchtype;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startMatchToolStripMenuItem;
        private System.Windows.Forms.ComboBox combobox_round;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

