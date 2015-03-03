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
    public partial class Register : Form
    {
        String imagename;


        public Register()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String constring = @"Data Source=(localdb)\v11.0;Initial Catalog=Robocon2015db;Integrated Security=True;Pooling=False";
            String Query = "delete from RoboconTable where CollegeDisplayName='" + this.txtCollegeDisplayName.Text + "';";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Deleted from the table.");
                while (myReader.Read())
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
            txtCollegeDisplayName.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(@imagename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);



            String constring = @"Data Source=(localdb)\v11.0;Initial Catalog=Robocon2015db;Integrated Security=True;Pooling=False";
            String Query = "insert into RoboconTable(Id,CollegeName,CollegeDisplayName,CollegeImage) values('" + Convert.ToInt32(this.txtID.Text) + "','" + this.txtCollegeName.Text + "','" + this.txtCollegeDisplayName.Text + "',@IMG) ;";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {

                conDataBase.Open();
                cmdDataBase.Parameters.Add(new SqlParameter("@IMG", imageBt));

                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Team has been Successfully Registered");
                while (myReader.Read())
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            txtID.Text = "";
            txtCollegeName.Text = "";
            txtCollegeDisplayName.Text = "";
            CollegeImage.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog fldlg = new OpenFileDialog();
                fldlg.InitialDirectory = @":C\";
                fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png";
                if (fldlg.ShowDialog() == DialogResult.OK)
                {
                    imagename = fldlg.FileName;
                    Bitmap newimg = new Bitmap(imagename);
                    CollegeImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    CollegeImage.Image = (Image)newimg;
                }
                fldlg = null;
            }

            catch (System.ArgumentException ae)
            {
                imagename = " ";
                MessageBox.Show(ae.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
