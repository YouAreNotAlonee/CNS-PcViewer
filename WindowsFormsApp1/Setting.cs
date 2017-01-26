using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using OpenCvSharp;



namespace WindowsFormsApp1
{
    class DllImport
    {
        [DllImport("User32.dll")]
        public static extern int MessageBox(int i, string text, string title, int type);

    
    }

    public partial class Setting : Form
    {
        /*import dll*/
        
            /*dll import*/
        CvCapture capture;
        int shiness;
        int exposure;
        int shade;
        int Shiness_R = 0, Shiness_G = 0, Shiness_B = 0;
        bool flip_x=false, flip_y=false;
        private void Setting_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            IplImage src;
            src = new IplImage("imageTest.jpg", LoadMode.AnyColor);
            //src = new IplImage(openFileDialog1.FileName, LoadMode.AnyColor);
            Cv.AddS(src, Cv.RGB(Shiness_R, Shiness_G, Shiness_B), src, null);
            src.Smooth(src, SmoothType.Gaussian); //블러처리
            pictureBoxIpl1.ImageIpl = src;
            
            //src.Smooth(src, SmoothType.Median);
            
            //Cv.NamedWindow("image");
            //Cv.ShowImage("image", src);
            /*
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                src = new IplImage("imageTest.jpg", LoadMode.AnyColor);
                //src = new IplImage(openFileDialog1.FileName, LoadMode.AnyColor);
                pictureBoxIpl1.ImageIpl = src;
            }*/
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            IplImage src, dst;
            
            src = new IplImage("imageTest.jpg", LoadMode.AnyColor);
            //src = new IplImage(openFileDialog1.FileName, LoadMode.AnyColor);
            Cv.AddS(src, Cv.RGB(Shiness_R, Shiness_G, Shiness_B), src, null);
            //Shiness RGB 값 조절하여 이미지에 추가
            if (flip_x)
                src.Flip(null, FlipMode.X);//x축으로 flip
            if (flip_y)
                src.Flip(null, FlipMode.Y);//y축으로 flip
            /*equailize histogram*///////////////////test//////////test//////test
            /*dst = new IplImage();
            Cv.EqualizeHist(src, dst);
            Cv.NamedWindow("after");
            Cv.ShowImage("after", dst);
            IplImage imgH = new IplImage(src.Size, BitDepth.U8, 1);
            IplImage imgS = new IplImage(src.Size, BitDepth.U8, 1);
            IplImage imgV = new IplImage(src.Size, BitDepth.U8, 1);
            src.CvtColor(dst, ColorConversion.RgbToCrCb);*/
            //dst.CvtPixToPlane()
            
            /*equalize histogram*/////////end//////////end//////////end
            pictureBoxIpl1.ImageIpl = src;
        }
        public Setting()
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
            
            InitializeComponent();
        }

        private void Shiness_minus_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Shiness_label.Text) > 1)
            {
                shiness = Convert.ToInt32(Shiness_label.Text) - 1;
                Shiness_label.Text = Convert.ToString(shiness);
                Shiness_R -= 10;
                Shiness_G -= 10;
                Shiness_B -= 10;
            }
        }

        private void Shiness_plus_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(Shiness_label.Text) < 7)
            {
                shiness = Convert.ToInt32(Shiness_label.Text) + 1;
                Shiness_label.Text = Convert.ToString(shiness);
                Shiness_R += 10;
                Shiness_G += 10;
                Shiness_B += 10;
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
            DllImport.MessageBox(0, "hello", "Message Box Title", 0);
        }

        private void Setting_default_Shiness()
        {
            Shiness_R = 0;
            Shiness_G = 0;
            Shiness_B = 0;
        }

        private void Setting_default_Click(object sender, EventArgs e)
        {
            shiness = 6;
            exposure = 0;
            shade = 0;
            Setting_default_Shiness();
            flip_x = flip_y = false;
            flip_Y.Checked = flip_X.Checked = false;
            Shiness_label.Text = Convert.ToString(shiness);
            Exposure_label.Text = Convert.ToString(exposure);
            Shade_label.Text = Convert.ToString(shade);
        }

        private void Setting_cancel_Click(object sender, EventArgs e)
        {
            Setting_default_Click(null, null);
            this.Close();
        }

        private void flip_X_CheckedChanged(object sender, EventArgs e)
        {
            if (flip_x)
                flip_x = false;
            else
                flip_x = true;
        }

        private void flip_Y_CheckedChanged(object sender, EventArgs e)
        {
            if (flip_y)
                flip_y = false;
            else
                flip_y = true;
        }
        /// <summary>
        /// ////////////////////////////////////test
        /// </summary>
        private void Setting_flip_X()
        {
            
        }
        private void Setting_flip_Y()
        {

        }
        
        private static byte[] CalcLut(int contrast, int brightness)
        {
            byte[] lut = new byte[256];
            if(contrast>0)
            {
                double delta = 127.0 * contrast / 100;
                double a = 255.0 / (255.0 - delta * 2);
                double b = a * (brightness - delta);
                for(int i=0; i<256; i++)
                {
                    int v = Cv.Round(a * i + b);
                    if (v < 0)
                        v = 0;
                    if (v > 255)
                        v = 255;
                    lut[i] = (byte)v;
                }
            }
            else
            {
                double delta = -128.0 * contrast / 100;
                double a = (256.0 - delta * 2) / 255.0;
                double b = a * brightness + delta;
                for(int i=0; i<256; i++)
                {
                    int v = Cv.Round(a * i + b);
                    if (v < 0)
                        v = 0;
                    if (v > 255)
                        v = 255;
                    lut[i] = (byte)v;
                }
            }
            return lut;
        }
    }
}
