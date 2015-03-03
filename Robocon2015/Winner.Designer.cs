namespace Robocon2015
{
    partial class Winner
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txt_winner1 = new System.Windows.Forms.Label();
            this.txt_winner2 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txt_winner1
            // 
            this.txt_winner1.BackColor = System.Drawing.Color.Transparent;
            this.txt_winner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_winner1.ForeColor = System.Drawing.Color.Red;
            this.txt_winner1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.txt_winner1.Location = new System.Drawing.Point(10, 185);
            this.txt_winner1.Name = "txt_winner1";
            this.txt_winner1.Size = new System.Drawing.Size(1000, 350);
            this.txt_winner1.TabIndex = 6;
            this.txt_winner1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_winner2
            // 
            this.txt_winner2.BackColor = System.Drawing.Color.Transparent;
            this.txt_winner2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_winner2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_winner2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.txt_winner2.Location = new System.Drawing.Point(10, 185);
            this.txt_winner2.Name = "txt_winner2";
            this.txt_winner2.Size = new System.Drawing.Size(1000, 350);
            this.txt_winner2.TabIndex = 9;
            this.txt_winner2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(972, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(45, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Robocon2015.Properties.Resources.Winner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_winner2);
            this.Controls.Add(this.txt_winner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label txt_winner1;
        private System.Windows.Forms.Label txt_winner2;
        private System.Windows.Forms.Button btn_exit;

    }
}