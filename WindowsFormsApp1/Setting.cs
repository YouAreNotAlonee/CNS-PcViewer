using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;
namespace WindowsFormsApp1
{
    public partial class Setting : Form
    {        
        string video_path;
        CvCapture capture;
        int shiness;
        int exposure;
        int shade;
        int Shiness_R = 0, Shiness_G = 0, Shiness_B = 0;

        private void Setting_Load(object sender, EventArgs e)
        {
           //timer1.Enabled = true;

            /*IplImage src;
            src = new IplImage(video_path, LoadMode.AnyColor);
            Cv.AddS(src, Cv.RGB(Shiness_R, Shiness_G, Shiness_B), src, null);
            pictureBoxIpl1.ImageIpl = src;*/

            capture = Cv.CreateFileCapture(video_path); //받은 경로의 영상을 담는다
            IplImage frame = Cv.QueryFrame(capture); //capture의 영상을 이미지로
            pictureBoxIpl1.ImageIpl = frame; //이미지 출력
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            IplImage src;
            src = new IplImage("imageTest.jpg", LoadMode.AnyColor);
            //src = new IplImage(openFileDialog1.FileName, LoadMode.AnyColor);
            Cv.AddS(src, Cv.RGB(Shiness_R, Shiness_G, Shiness_B), src, null);
            pictureBoxIpl1.ImageIpl = src;
        }
        public Setting(string path)
        {
            //IplImage img = Cv.LoadImage("imageTest.jpg");
            //IplImage img = new IplImage("imageTest.jpg");
            //img = new IplImage("imageTest.jpg", LoadMode.AnyColor);
            //img = capture.QueryFrame();
            //pictureBoxIpl1.ImageIpl = img;
            //bright_image = Cv.CreateImage(Cv.GetSize(img), 8, 3);
            //Cv.AddS(img, Cv.RGB(60, 60, 60), img, null);
            /*
            Cv.NamedWindow("image");
            Cv.ShowImage("image", img);

            Cv.WaitKey();
            Cv.DestroyWindow("image");
            Cv.ReleaseImage(img);
            */
            video_path = path;
            InitializeComponent();
        }

        private void Shiness_minus_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Shiness_label.Text) > 1)
            {
                shiness = Convert.ToInt32(Shiness_label.Text) - 1;
                Shiness_label.Text = Convert.ToString(shiness);
            }
        }

        private void Shiness_plus_Click(object sender, EventArgs e)
        {
            Shiness_R += 10;
            Shiness_G += 10;
            Shiness_B += 10;
            if (Convert.ToInt32(Shiness_label.Text) < 7)
            {
                shiness = Convert.ToInt32(Shiness_label.Text) + 1;
                Shiness_label.Text = Convert.ToString(shiness);
            }
        }

        private void Exposure_minus_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Exposure_label.Text) > -3)
            {
                exposure = Convert.ToInt32(Exposure_label.Text) - 1;
                Exposure_label.Text = Convert.ToString(exposure);
            }
        }

        private void Exposure_plus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Exposure_label.Text) < 3)
            {
                exposure = Convert.ToInt32(Exposure_label.Text) + 1;
                Exposure_label.Text = Convert.ToString(exposure);
            }
        }

        private void Shade_minus_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Shade_label.Text) > 0)
            {
                shade = Convert.ToInt32(Shade_label.Text) - 1;
                Shade_label.Text = Convert.ToString(shade);
            }
        }

        private void Shade_plus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Shade_label.Text) < 6)
            {
                shade = Convert.ToInt32(Shade_label.Text) + 1;
                Shade_label.Text = Convert.ToString(shade);
            }
        }

        private void Setting_save_Click(object sender, EventArgs e)
        {

        }



        private void Setting_default_Click(object sender, EventArgs e)
        {
            shiness = 6;
            exposure = 0;
            shade = 0;
            Shiness_label.Text = Convert.ToString(shiness);
            Exposure_label.Text = Convert.ToString(exposure);
            Shade_label.Text = Convert.ToString(shade);
        }

        private void Setting_cancel_Click(object sender, EventArgs e)
        {
            Setting_default_Click(null, null);
            this.Close();
        }


    }
}
