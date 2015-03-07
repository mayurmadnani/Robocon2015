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
    public partial class Entry : Form
    {

        public Entry()
        {
            InitializeComponent();
            fillComboBox();
        }

        public void fillComboBox()
        {
            String constring = @"Data Source=(localdb)\v11.0;Initial Catalog=Robocon2015db;Integrated Security=True;Pooling=False";
            String query = "select CollegeDisplayName from RoboconTable order by CollegeDisplayName;";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();


                while (myReader.Read())
                {
                    combobox_red.Items.Add(myReader[0]);
                    combobox_blue.Items.Add(myReader[0]);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        
        private void startMatchToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if (!lbl_matchtype.Text.Equals("??") &&
                 !combobox_red.Text.Equals("") &&
                 !combobox_blue.Text.Equals("") )
             {
                 Form match = new Match(combobox_red.Text, combobox_blue.Text, lbl_matchtype.Text);
                 match.Show();

                 combobox_red.ResetText();
                 combobox_blue.ResetText();
                 lbl_matchtype.Text = "??";
             }
         }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form register = new Register();
            register.Show();
        }

        private void LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_matchtype.Text = "League";
        }

        private void SLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_matchtype.Text = "Super-League";
        }

        private void QFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_matchtype.Text = "Quarter-Final";
        }

        private void SFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_matchtype.Text = "Semi-Final";
        }

        private void FToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbl_matchtype.Text = "Final";
        }


    }
}
