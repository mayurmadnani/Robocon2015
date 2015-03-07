using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Robocon2015
{
    public partial class Winner : Form
    {
        String winteam;
        public Winner(String w)
        {
            InitializeComponent();
            txt_winner1.Text = txt_winner2.Text = winteam = w;
            timer.Enabled = true;
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txt_winner2.Visible = txt_winner2.Visible == true ? false : true;
        }

    }
}
