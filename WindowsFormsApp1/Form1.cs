using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.DirectX.AudioVideoPlayback;
//using DirectShowLib;
using OpenCvSharp;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        
        Microsoft.DirectX.AudioVideoPlayback.Video vid;
        int hour, minute, second, VideoDuration, VideoPosition;
        string Video_Time;
        bool Video_Timer_Enable= false, Valid_FileType = false, Mute_Mode = false;
        bool ScrollEnable = false;
        //Size VideoDefaultSize;
        public void init()
        {
            System.Drawing.Size Panel_Size;
            Panel_Size = video_panel.Size;

            OpenFileDialog of = new OpenFileDialog();
            if(of.ShowDialog()==DialogResult.OK)
            {
                if (vid != null)
                    vid.Dispose();
                vid = new Microsoft.DirectX.AudioVideoPlayback.Video(of.FileName);
                vid.Owner = this.video_panel;
                video_panel.Size = Panel_Size;
            }
        }
        //IGraphBuilder pGraphBuilder = null;
        //IMediaControl pMediaControl = null;

        //IMediaEvent pMediaEvent = null;
        //EventCode eventCode;
        
        //IVideoWindow pVideoWindow = null;
        private void Video_Stop()
        {
            /*Marshal.ReleaseComObject(pGraphBuilder);
            pGraphBuilder = null;
            Marshal.ReleaseComObject(pMediaControl);
            pMediaControl = null;
            Marshal.ReleaseComObject(pMediaEvent);
            pMediaEvent = null;
            Marshal.ReleaseComObject(pVideoWindow);
            pVideoWindow = null;*/
        }

        private void Video_Capture()
        {
            
        }

        private void Video_Play()
        {
            //vid.Size.Width = video_panel.Size.Width;
            vid.Size = video_panel.Size;

            /*VideoDefaultSize = vid.DefaultSize;
            int W = Math.Max(VideoDefaultSize.Width, this.ClientSize.Width);
            int H = VideoDefaultSize.Height;
            Aspect = (double)((double)VideoDefaultSize.Width / (float)VideoDefaultSize.Height);
            */

            if (Mute_Mode)
                vid.Audio.Volume = -100;
            else
                vid.Audio.Volume = Convert.ToInt32((100 - Volume_Bar.Value) * -50);

            VideoDuration = (int)vid.Duration;
            trackBar.Maximum = 10 * VideoDuration;
            hour = VideoPosition / 3600;
            minute = (VideoDuration - hour * 3600) / 60;
            second = (VideoDuration - hour * 3600 - minute * 60);

            string HH = ("00" + hour.ToString());
            HH = HH.Substring(HH.Length - 2, 2);
            string MM = ("00" + minute.ToString());
            MM = MM.Substring(MM.Length - 2, 2);
            string SS = ("00" + second.ToString());
            SS = SS.Substring(SS.Length - 2, 2);

            Video_Time = HH + ":" + MM + ":" + SS;
            VideoTime.Text = "/   " + Video_Time;
            
            /*pGraphBuilder = (IGraphBuilder)new FilterGraph();

            pMediaControl = (IMediaControl)pGraphBuilder;

            pMediaEvent = (IMediaEvent)pGraphBuilder;

            pVideoWindow = (IVideoWindow)pGraphBuilder;

            pMediaControl.RenderFile("test.wmv");

            pVideoWindow.put_Owner(video_panel.Handle);
            pVideoWindow.put_WindowStyle(WindowStyle.Child | WindowStyle.ClipSiblings);
            Rectangle rect = video_panel.ClientRectangle;
            pVideoWindow.SetWindowPosition(0, 0, rect.Right, rect.Bottom);

            pMediaControl.Run();
            */
        }
        /*video test*/
        public MainForm()
        {
            //VideoCapture cap1("2.mp4");
            InitializeComponent();
            
            this.BackColor = Color.White;
            /*make mainform's background to white*/

            audio_play.BackColor = Color.Transparent;
            audio_step_back.BackColor = Color.Transparent;
            audio_step_forward.BackColor = Color.Transparent;
            audio_stop.BackColor = Color.Transparent;
            /*make button's background transparent*/

            audio_play.ForeColor = Color.Transparent;
            audio_step_back.ForeColor = Color.Transparent;
            audio_step_forward.ForeColor = Color.Transparent;
            audio_stop.ForeColor = Color.Transparent;
            Speed_tbox.Text = "018";
            /*make button's line transparent*/

            Video_Timer.Enabled = true;
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.listView.View = View.Details;
            this.listView.Columns.Add("날짜", 100, HorizontalAlignment.Center);
            this.listView.Columns.Add("시", 60, HorizontalAlignment.Center);
            this.listView.Columns.Add("분 초", 60, HorizontalAlignment.Center);
            this.listView.Columns.Add("녹화타입", 80, HorizontalAlignment.Center);
            insert_listviewitem();//listview test
        }
        /*listview test*/
        private void insert_listviewitem()
        {
            ListViewItem item;
            String[] itemStr = new string[4];
            itemStr.SetValue("20161230", 0);
            itemStr.SetValue("6시", 1);
            itemStr.SetValue("46분", 2);
            itemStr.SetValue("상시", 3);
            //itemStr.SetValue("s", 0);
            item = new ListViewItem(itemStr);
            this.listView.Items.Add(item);
        }
        /*test end*/

        private void Settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("setting menu clicked!");
        }

        private void LeftRight_Scroll(object sender, EventArgs e)
        {
            if (LeftRight.Value == 0)
                MessageBox.Show("front");
            else if (LeftRight.Value == 1)
                MessageBox.Show("back");
            else
                MessageBox.Show("error");
        }

        private void UpDown_Scroll(object sender, EventArgs e)
        {
            if (UpDown.Value == 0)
                MessageBox.Show("UP");
            else if (UpDown.Value == 1)
                MessageBox.Show("Down");
            else
                MessageBox.Show("Error");
        }

        private void audio_step_forward_Click(object sender, EventArgs e)
        {
            //vid.
        }

        private void audio_pause_Click(object sender, EventArgs e)
        {
            if(vid != null)
            {
                audio_play.Enabled = true;
                audio_play.Visible = true;
                audio_stop.Enabled = true;
                audio_stop.Visible = true;
                audio_pause.Enabled = false;
                audio_pause.Visible = false;

                Video_Timer_Enable = false;
                vid.Pause();
            }
        }

        private void audio_stop_Click(object sender, EventArgs e)
        {
            if (vid != null)
            {
                audio_play.Enabled = true;
                audio_play.Visible = true;
                audio_stop.Enabled = false;
                audio_stop.Visible = false;
                audio_pause.Enabled = true;
                audio_pause.Visible = true;
                vid.Stop();
            }
        }

        private void audio_play_Click(object sender, EventArgs e)
        {
            if (vid != null)
            {
                audio_play.Enabled = false;
                audio_play.Visible = false;
                audio_stop.Enabled = true;
                audio_stop.Visible = true;
                audio_pause.Enabled = true;
                audio_pause.Visible = true;

                Video_Timer_Enable = true;
                Video_Play();
                vid.Play();
            }
        }

        private void audio_step_back_Click(object sender, EventArgs e)
        {
            //audio_step_back.
        }

        private void zero_dot_two_btn_Click(object sender, EventArgs e)
        {

        }

        private void zero_dot_five_btn_Click(object sender, EventArgs e)
        {

        }

        private void one_dot_zero_btn_Click(object sender, EventArgs e)
        {

        }

        private void one_dot_five_btn_Click(object sender, EventArgs e)
        {

        }

        private void two_dot_zero_btn_Click(object sender, EventArgs e)
        {

        }

        private void Marker_Click(object sender, EventArgs e)
        {
            
            String city = "Seoul";
            String state = "";
            String country = "";
            StringBuilder add = new StringBuilder("http://maps.google.com/maps?q=");
            add.Append(city);
            add.Append(state);
            add.Append(country);

            webBrowser.Navigate(add.ToString());
        
        }

        private void folder_open_Click(object sender, EventArgs e)
        {

        }

        private void Camera_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void Dirve_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Dirve_btn.Checked)
                MessageBox.Show("drive checked");
            else if (!Dirve_btn.Checked)
                MessageBox.Show("drive unchecked");
            else
                MessageBox.Show("drive button error");
        }

        private void Event_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Event_btn.Checked)
                MessageBox.Show("Event checked");
            else if (!Event_btn.Checked)
                MessageBox.Show("Event unchecked");
            else
                MessageBox.Show("drive button error");
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (ScrollEnable)
                vid.CurrentPosition = (double)(trackBar.Value / 10.0);
        }

        private void trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if(vid != null)
            {
                ScrollEnable = false;
                if (audio_play.Visible == false)
                {
                    vid.Play();
                    Video_Timer_Enable = true;
                }
            }
        }

        private void trackBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(vid!=null)
            {
                vid.Pause();
                ScrollEnable = true;
                trackBar.Value = (int)((double)((double)e.X / (double)trackBar.Width)*(double)trackBar.Maximum);
                trackBar_Scroll(null, null);
            }
        }

        private void trackBar_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void trackBar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            if (ScrollEnable)
                vid.CurrentPosition = (double)(trackBar.Value / 10.0);
        }

        private void Parking_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Parking_btn.Checked)
                MessageBox.Show("Parking checked");
            else if (!Parking_btn.Checked)
                MessageBox.Show("parking uncheked");
            else
                MessageBox.Show("drive button error");
        }

        private void Camera_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Camera_btn.Checked)
                MessageBox.Show("camera checked");
            else if (!Camera_btn.Checked)
                MessageBox.Show("camera unchecked");
            else
                MessageBox.Show("camera button error");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            init();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vid != null)
            {
                audio_stop_Click(null, null);
                vid.Dispose();
                vid = null;
            }
        }//free video

        private void Video_Timer_Tick(object sender, EventArgs e)
        {
            string HH, MM, SS;
            if(Video_Timer_Enable)
            {
                VideoPosition = (int)vid.CurrentPosition;
                trackBar.Value = 10 * VideoPosition;
                hour = VideoPosition / 3600;
                minute = (VideoPosition - hour * 3600) / 60;
                second = (VideoPosition - hour * 3600 - minute * 60);

                HH = ("00" + hour.ToString());
                HH = HH.Substring(HH.Length - 2, 2);
                MM = ("00" + minute.ToString());
                MM = MM.Substring(MM.Length - 2, 2);
                SS = ("00" + second.ToString());
                SS = SS.Substring(SS.Length - 2, 2);
                curTime.Text = HH + ":" + MM + ":" + SS;
                
                if (curTime.Text == Video_Time)
                    audio_stop_Click(null, null);
                    
            }
        }

        private void CheckVideo(string VideoFile)
        {
            if(VideoFile.Length != 0 )
            {
                if (VideoFile.EndsWith(".avi") || VideoFile.EndsWith(".wmv"))
                    Valid_FileType = true;
            }
        }
    }
}
