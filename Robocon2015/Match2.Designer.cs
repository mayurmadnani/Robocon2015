namespace Robocon2015
{
    partial class Match2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Match2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.redWinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueWinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_red = new System.Windows.Forms.Label();
            this.RedTeamImage = new System.Windows.Forms.PictureBox();
            this.lbl_redScore = new System.Windows.Forms.Label();
            this.lbl_blueScore = new System.Windows.Forms.Label();
            this.BlueTeamImage = new System.Windows.Forms.PictureBox();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.lbl_matchtype = new System.Windows.Forms.Label();
            this.txt_red = new System.Windows.Forms.TextBox();
            this.txt_blue = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_nxtround = new System.Windows.Forms.Button();
            this.lbl_redScore1 = new System.Windows.Forms.Label();
            this.lbl_blueScore1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTeamImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTeamImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redWinToolStripMenuItem,
            this.blueWinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 744);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // redWinToolStripMenuItem
            // 
            this.redWinToolStripMenuItem.Name = "redWinToolStripMenuItem";
            this.redWinToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.redWinToolStripMenuItem.Text = "Red Win";
            this.redWinToolStripMenuItem.Click += new System.EventHandler(this.redWinToolStripMenuItem_Click);
            // 
            // blueWinToolStripMenuItem
            // 
            this.blueWinToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.blueWinToolStripMenuItem.Name = "blueWinToolStripMenuItem";
            this.blueWinToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.blueWinToolStripMenuItem.Text = "Blue Win";
            this.blueWinToolStripMenuItem.Click += new System.EventHandler(this.blueWinToolStripMenuItem_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(978, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(45, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_red
            // 
            this.lbl_red.BackColor = System.Drawing.Color.Transparent;
            this.lbl_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_red.ForeColor = System.Drawing.Color.Red;
            this.lbl_red.Location = new System.Drawing.Point(30, 175);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(450, 100);
            this.lbl_red.TabIndex = 0;
            this.lbl_red.Text = "Red Team";
            this.lbl_red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RedTeamImage
            // 
            this.RedTeamImage.Location = new System.Drawing.Point(171, 265);
            this.RedTeamImage.Name = "RedTeamImage";
            this.RedTeamImage.Size = new System.Drawing.Size(160, 160);
            this.RedTeamImage.TabIndex = 2;
            this.RedTeamImage.TabStop = false;
            // 
            // lbl_redScore
            // 
            this.lbl_redScore.BackColor = System.Drawing.Color.Transparent;
            this.lbl_redScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_redScore.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_redScore.Location = new System.Drawing.Point(133, 428);
            this.lbl_redScore.Name = "lbl_redScore";
            this.lbl_redScore.Size = new System.Drawing.Size(218, 91);
            this.lbl_redScore.TabIndex = 4;
            this.lbl_redScore.Text = "0";
            this.lbl_redScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_blueScore
            // 
            this.lbl_blueScore.BackColor = System.Drawing.Color.Transparent;
            this.lbl_blueScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blueScore.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_blueScore.Location = new System.Drawing.Point(691, 428);
            this.lbl_blueScore.Name = "lbl_blueScore";
            this.lbl_blueScore.Size = new System.Drawing.Size(230, 91);
            this.lbl_blueScore.TabIndex = 7;
            this.lbl_blueScore.Text = "0";
            this.lbl_blueScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlueTeamImage
            // 
            this.BlueTeamImage.Location = new System.Drawing.Point(704, 265);
            this.BlueTeamImage.Name = "BlueTeamImage";
            this.BlueTeamImage.Size = new System.Drawing.Size(160, 160);
            this.BlueTeamImage.TabIndex = 6;
            this.BlueTeamImage.TabStop = false;
            // 
            // lbl_blue
            // 
            this.lbl_blue.BackColor = System.Drawing.Color.Transparent;
            this.lbl_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_blue.Location = new System.Drawing.Point(560, 175);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(450, 100);
            this.lbl_blue.TabIndex = 5;
            this.lbl_blue.Text = "Blue Team";
            this.lbl_blue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_matchtype
            // 
            this.lbl_matchtype.BackColor = System.Drawing.Color.Transparent;
            this.lbl_matchtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matchtype.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_matchtype.Location = new System.Drawing.Point(380, 390);
            this.lbl_matchtype.Name = "lbl_matchtype";
            this.lbl_matchtype.Size = new System.Drawing.Size(300, 50);
            this.lbl_matchtype.TabIndex = 14;
            this.lbl_matchtype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_red
            // 
            this.txt_red.Location = new System.Drawing.Point(223, 748);
            this.txt_red.Name = "txt_red";
            this.txt_red.Size = new System.Drawing.Size(26, 20);
            this.txt_red.TabIndex = 15;
            this.txt_red.Text = "0";
            // 
            // txt_blue
            // 
            this.txt_blue.Location = new System.Drawing.Point(786, 748);
            this.txt_blue.Name = "txt_blue";
            this.txt_blue.Size = new System.Drawing.Size(26, 20);
            this.txt_blue.TabIndex = 16;
            this.txt_blue.Text = "0";
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(425, 743);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 17;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_nxtround
            // 
            this.btn_nxtround.Location = new System.Drawing.Point(562, 743);
            this.btn_nxtround.Name = "btn_nxtround";
            this.btn_nxtround.Size = new System.Drawing.Size(75, 23);
            this.btn_nxtround.TabIndex = 18;
            this.btn_nxtround.Text = ">>>";
            this.btn_nxtround.UseVisualStyleBackColor = true;
            this.btn_nxtround.Visible = false;
            this.btn_nxtround.Click += new System.EventHandler(this.buttonnxtrnd_Click);
            // 
            // lbl_redScore1
            // 
            this.lbl_redScore1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_redScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_redScore1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_redScore1.Location = new System.Drawing.Point(133, 519);
            this.lbl_redScore1.Name = "lbl_redScore1";
            this.lbl_redScore1.Size = new System.Drawing.Size(218, 195);
            this.lbl_redScore1.TabIndex = 19;
            this.lbl_redScore1.Text = "0";
            this.lbl_redScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_blueScore1
            // 
            this.lbl_blueScore1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_blueScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blueScore1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_blueScore1.Location = new System.Drawing.Point(703, 519);
            this.lbl_blueScore1.Name = "lbl_blueScore1";
            this.lbl_blueScore1.Size = new System.Drawing.Size(218, 195);
            this.lbl_blueScore1.TabIndex = 20;
            this.lbl_blueScore1.Text = "0";
            this.lbl_blueScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Match2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lbl_blueScore1);
            this.Controls.Add(this.lbl_redScore1);
            this.Controls.Add(this.btn_nxtround);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.txt_blue);
            this.Controls.Add(this.txt_red);
            this.Controls.Add(this.lbl_matchtype);
            this.Controls.Add(this.lbl_blueScore);
            this.Controls.Add(this.BlueTeamImage);
            this.Controls.Add(this.lbl_blue);
            this.Controls.Add(this.lbl_redScore);
            this.Controls.Add(this.RedTeamImage);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Match2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match";
            this.Load += new System.EventHandler(this.Match_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTeamImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTeamImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.PictureBox RedTeamImage;
        private System.Windows.Forms.Label lbl_redScore;
        private System.Windows.Forms.Label lbl_blueScore;
        private System.Windows.Forms.PictureBox BlueTeamImage;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.Label lbl_matchtype;
        private System.Windows.Forms.ToolStripMenuItem redWinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueWinToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_red;
        private System.Windows.Forms.TextBox txt_blue;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_nxtround;
        private System.Windows.Forms.Label lbl_redScore1;
        private System.Windows.Forms.Label lbl_blueScore1;
    }
}