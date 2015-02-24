using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robocon2015
{
    public partial class Winner : Form
    {
        public Winner(String winteam, String matchtype)
        {
            InitializeComponent();
            txt_winner1.Text = winteam;
            txt_winner2.Text = winteam;
            if(matchtype.Equals("Final"))
            {
                lbl_winner.Text = "WINNER of ROBOMINTON 2015";
            }
            else
            {
                lbl_winner.Text = "WINNER";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txt_winner2.Visible = txt_winner2.Visible == true ? false : true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
