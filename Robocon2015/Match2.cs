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
    public partial class Match2 : Form
    {
        String matchtype;
        String redteam;
        String blueteam;
        String rounds;

        public Match2(String r, String b,String rs, String bs, String m,String round)
        {
            InitializeComponent();
            redteam = r;
            blueteam = b;
            matchtype = m;
            rounds = round;
            lbl_redScore.Text = rs;
            lbl_blueScore.Text = bs;
        }

        private void Match_Load(object sender, EventArgs e)
        {
            lbl_red.Text = redteam;
            lbl_redScore1.Text = "";
            lbl_blue.Text = blueteam;
            lbl_blueScore1.Text = "";
            lbl_matchtype.Text = matchtype;
            if (rounds.Equals("3 Rounds"))
            {
                btn_nxtround.Visible = true;
            }

            string constring = @"Data Source=(localdb)\v11.0;Initial Catalog=Robocon2015db;Integrated Security=True;Pooling=False";
            string Query = "select * from RoboconTable where CollegeDisplayName='" + lbl_red.Text + "';";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;

            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                RedTeamImage.SizeMode = PictureBoxSizeMode.StretchImage;
                while (myReader.Read())
                {
                    byte[] imgg = (byte[])(myReader["CollegeImage"]);
                    if (imgg == null)
                    {
                        RedTeamImage.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        RedTeamImage.Image = System.Drawing.Image.FromStream(mstream);

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            string Query2 = "select * from RoboconTable where CollegeDisplayName='" + lbl_blue.Text + "';";
            SqlConnection conDataBase2 = new SqlConnection(constring);
            SqlCommand cmdDataBase2 = new SqlCommand(Query2, conDataBase2);
            SqlDataReader myReader2;
            try
            {

                conDataBase2.Open();
                myReader2 = cmdDataBase2.ExecuteReader();
                BlueTeamImage.SizeMode = PictureBoxSizeMode.StretchImage;
                while (myReader2.Read())
                {
                    byte[] imgg2 = (byte[])(myReader2["CollegeImage"]);
                    if (imgg2 == null)
                    {
                        BlueTeamImage = null;
                    }
                    else
                    {
                        MemoryStream mstream2 = new MemoryStream(imgg2);
                        BlueTeamImage.Image = System.Drawing.Image.FromStream(mstream2);

                    }
                }
            }

            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            lbl_redScore1.Text = "";
            lbl_redScore1.Text = txt_red.Text;
            lbl_blueScore1.Text = "";
            lbl_blueScore1.Text = txt_blue.Text;
        }

        private void redWinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form winner = new Winner(lbl_red.Text, lbl_matchtype.Text);
            winner.Show();
            this.Close();
        }

        private void blueWinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form winner = new Winner(lbl_blue.Text, lbl_matchtype.Text);
            winner.Show();
            this.Close();
        }


        private void buttonnxtrnd_Click(object sender, EventArgs e)
        {
            Form match = new Match3(lbl_red.Text,lbl_blue.Text,lbl_redScore.Text,lbl_blueScore.Text,lbl_redScore1.Text,lbl_blueScore1.Text,lbl_matchtype.Text,rounds);
            match.Show();
            this.Close();
        }

    }
}
