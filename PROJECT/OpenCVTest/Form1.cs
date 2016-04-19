using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;


namespace OpenCVTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string imagename;
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                try
                {

                    FileDialog fldlg = new OpenFileDialog();

                    //specify your own initial directory

                    fldlg.InitialDirectory = @":D\";

                    //this will allow only those file extensions to be added

                    fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png";

                    if (fldlg.ShowDialog() == DialogResult.OK)
                    {

                        imagename = fldlg.FileName;

                        Bitmap newimg = new Bitmap(imagename);

                        imageName.SizeMode = PictureBoxSizeMode.StretchImage;

                        imageName.Image = (Image)newimg;

                    }

                    fldlg = null;

                }

                catch (System.ArgumentException ae)
                {

                    imagename = " ";

                    MessageBox.Show(ae.Message.ToString());

                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    FileDialog fldlg = new OpenFileDialog();

                    //specify your own initial directory

                    fldlg.InitialDirectory = @":D\";

                    //this will allow only those file extensions to be added

                    fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png";

                    if (fldlg.ShowDialog() == DialogResult.OK)
                    {

                        imagename = fldlg.FileName;

                        Bitmap newimg = new Bitmap(imagename);

                        imageName1.SizeMode = PictureBoxSizeMode.StretchImage;

                        imageName1.Image = (Image)newimg;

                    }

                    fldlg = null;

                }

                catch (System.ArgumentException ae)
                {

                    imagename = " ";

                    MessageBox.Show(ae.Message.ToString());

                }


            }
        }
    }
}
