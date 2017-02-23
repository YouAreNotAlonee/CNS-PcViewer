using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Threading;
//using DirectShowLib;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using OpenCvSharp;
using System.Collections.Generic;


namespace WindowsFormsApp1
{

    public unsafe partial class MainForm : Form
    {
        Video vid;
        int hour, minute, second, VideoDuration, VideoPosition, handle=0;
        string Video_Time;
        bool Video_Timer_Enable = false, Valid_FileType = false, Mute_Mode = false;
        bool ScrollEnable = false;
        bool P_check = true, E_check = true, N_check = true, M_check = true;//리스트 뷰 위 체크박스 플래그 //parking Event Normal
        char Eevnet = (char)0, Nnormal = (char)0, Pparking = (char)0, Bbackup = (char)0, Rreserve = (char)0;
        /// <summary>
        /// openCV 이미지
        /// </summary>
        CvCapture capture;
        IplImage imgSrc = new IplImage(640, 480, BitDepth.U8, 3);
        private string video_path;
        Device _device;

        /// <summary>
        /// TATLib에 필요한 함수와 인자들 
        /// </summary>
        [DllImport("TATLib.dll")]
        public static extern int TAT_Create();

        [DllImport("TATLib.dll")]
        public static extern void TAT_Delete(int handle);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Open(int handle, byte* device);

        [DllImport("TATLib.dll")]
        public static extern void TAT_Close(int handle, int fp);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Read(int handle, int fp, long pos, byte* data, int size);//

        [DllImport("TATLib.dll")]
        public static extern int TAT_Write(int handle, int fp, long pos, int bytes, byte* data, int size);

        [DllImport("TATLib.dll")]
        public static extern bool TAT_Format(int handle);

        [DllImport("TATLib.dll")]
        public static extern bool TAT_Check_Tat_Device(int handle, byte* device);

        [DllImport("TATLib.dll")]
        public static extern bool TAT_Check_Version();//TATLib.h에 없음

        [DllImport("TATLib.dll")]
        public static extern bool TAT_Get_File_Frame_Cnt(int handle, char mode, ref byte fname, ref int front, ref int rear);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_File_Index_info(int handle, char mode, ref byte fname, ref FileInfo f_info); //기존 TATLib에서는 마지막 인자가 FILE_INFO *f_info 이다 이게 맞나?

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_File_Cnt(int handle, char mode);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_File_List(int handle, char mode, int list_cnt, ref byte fname, ref int findex, ref int fsize);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_File_List_tt(int handle, char mode, int list_cnt, byte[] fname, int[] findex, int[] fsize, int[] ftime);

        [DllImport("TATLib.dll")]
        public static extern bool TAT_Get_File_Flag(int handle, char* Eevent, char* Nnormal, char* Pparking, char* Rreserv);
        //        public static extern bool TAT_Get_File_Flag(int handle, char device, ref byte Eevent, ref byte Nnormal, ref byte Pparking);

        [DllImport("TATLib.dll")]
        public static extern char TAT_Find_Start_Stop(int handle, int fp, char mode, int* start, ref int stop, ref int last_pos);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_PB_Pos(int handle, char mode, byte* file);

        [DllImport("TATLib.dll")]
        public static extern bool TAT_Get_Seek_Pos(int handle, char seek, char total);

        [DllImport("TATLib.dll")]
        public static extern bool TAT_Set_PcFolder(int handle, byte* folder);

        [DllImport("TATLib.dll")]
        public static extern void TAT_PB_Init(int handle);

        [DllImport("TATLib.dll")]
        public static extern void TAT_PB_DeInit(int handle);

        [DllImport("TATLib.dll")]
        public static extern void TAT_PB_Start(int handle, char mode, char ch, int pb_pos);

        [DllImport("TATLib.dll")]
        public static extern void TAT_PB_Stop(int handle);

        [DllImport("TATLib.dll")]
        public static extern void TAT_FAT_PB_Start(int handle, byte* file, int* frame_cnt);

        [DllImport("TATLib.dll")]
        public static extern void TAT_FAT_PB_Stop(int handle);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Read_Frame(int handle, byte* ch, byte* p_type, int* size, byte* data, int* timestamp);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Make_Avi_File(int handle, string fname);

        [DllImport("TATLib.dll")]
        public static extern void TAT_Make_Play_File();//TATLib에 없음

        [DllImport("TATLib.dll")]
        public static extern void TAT_Make_Tat_File();//TATLib에 없음

        [DllImport("TATLib.dll")]
        public static extern int TAT_Make_Data_File(int handle, byte* fname, int* frame_cnt, ref byte gps_data, char tat, ref char fps, ref int width, ref int height);

        [DllImport("TATLib.dll")]
        public static extern bool TAT_Set_Config_Data(int handle, byte* data, int* size);

        [DllImport("TATLib.dll")]
        public static extern void TAT_Get_Config_Data(int handle, byte* data, int* size);

        [DllImport("TATLib.dll")]
        public static extern void TAT_Get_Device_Name();//TATLib에 없음

        [DllImport("TATLib.dll")]
        public static extern void TAT_Make_Picture_File();//TATLib에 없음

        
        /// <summary>
        /// TAT 관련 영상들이 어떤 드라이브에 있는지를 리턴
        /// </summary>
        /// <returns>드라이브명</returns>
        private string TAT_device()
        {
            bool result = false;
            //int handle = 0;
            byte dev_num = 0;
            string path = null;
            handle = TAT_Create();
            result = TAT_Check_Tat_Device(handle, &dev_num);//원래 ref dev_num
            MessageBox.Show(result.ToString());
            MessageBox.Show(dev_num.ToString());

            if (dev_num == 2)
                path = "D\\: 에 TAT파일이 있습니다.";
            else if (dev_num == 3)
                path = "E\\: 에 TAT파일이 있습니다.";
            else if (dev_num == 4)
                path = "F\\: 에 TAT파일이 있습니다.";
            else
                MessageBox.Show("TAT file doesn't exist");
            return path;
        }

        private void TAT_showlist()
        {
            //listView.Clear();
            listView.Items.Clear();
            int mode_0 = 254, mode_1 = 254, mode_2 = 254, mode_3 = 254, mode = 254, file_num=1, file_cnt;
            unsafe
            {
                fixed (char* a = &Eevent)
                {
                    fixed (char* b = &Nnormal)
                    {
                        fixed (char* c = &Pparking)
                        {
                            fixed (char* d = &Rreserve)
                                TAT_Get_File_Flag(0, a, b, c, d);
                        }
                    }
                }
            }
            mode_0 = TAT_Get_File_Cnt(handle, (char)0);
            mode_1 = TAT_Get_File_Cnt(handle, (char)1);
            mode_2 = TAT_Get_File_Cnt(handle, (char)2);
            mode_3 = TAT_Get_File_Cnt(handle, (char)3);
            file_cnt = mode_0 + mode_1 + mode_2 + mode_3;
            byte[] list_name_arr = new byte[40 * mode_0];
            int[] list_index_arr = new int[sizeof(int) * mode_0];
            int[] list_size_arr = new int[sizeof(int) * mode_0];
            int[] list_time_arr = new int[sizeof(int) * mode_0];

            byte[] list_name_arr1 = new byte[40 * mode_1];
            int[] list_index_arr1 = new int[sizeof(int) * mode_1];
            int[] list_size_arr1 = new int[sizeof(int) * mode_1];
            int[] list_time_arr1 = new int[sizeof(int) * mode_1];

            byte[] list_name_arr2 = new byte[40 * file_cnt];
            int[] list_index_arr2 = new int[sizeof(int) * file_cnt];
            int[] list_size_arr2 = new int[sizeof(int) * file_cnt];
            int[] list_time_arr2 = new int[sizeof(int) * file_cnt];

            byte[] list_name_arr3 = new byte[40 * file_cnt];
            int[] list_index_arr3 = new int[sizeof(int) * file_cnt];
            int[] list_size_arr3 = new int[sizeof(int) * file_cnt];
            int[] list_time_arr3 = new int[sizeof(int) * file_cnt];
            //위에 있는 byte형 포인터 1개와 int형포인터 3개를 변환할 배열

            file_sum += TAT_Get_File_List_tt(handle, (char)0, mode_0, list_name_arr, list_index_arr, list_size_arr, list_time_arr);
            file_sum += TAT_Get_File_List_tt(handle, (char)1, mode_1, list_name_arr1, list_index_arr1, list_size_arr1, list_time_arr1);
            file_sum += TAT_Get_File_List_tt(handle, (char)2, mode_2, list_name_arr2, list_index_arr2, list_size_arr2, list_time_arr2);
            file_sum += TAT_Get_File_List_tt(handle, (char)3, mode_3, list_name_arr3, list_index_arr3, list_size_arr3, list_time_arr3);
            ///////
            //문자열 배열 테스트
            string[] name = new string[mode_0];
            string[] Only_name = new string[mode_0];
            string[] name1 = new string[mode_1+1];
            string[] Only_name1 = new string[mode_1+1];
            string[] name2 = new string[file_cnt];
            string[] Only_name2 = new string[file_cnt];
            string[] name3 = new string[file_cnt];
            string[] Only_name3 = new string[file_cnt];
            int k = 0, k1=0, k2=0, k3=0;
            string temp = null;
            //////
            for (int i = 0; i < list_name_arr.Length; i++)
            {
                temp +=Convert.ToChar(list_name_arr[i]);
                
                if (i == file_num * 40 - 1)
                {
                    file_num++;
                    name[k] = temp;
                    k++;
                    temp = null;
                }
            }
            for (int i = 0; i < list_name_arr1.Length; i++)
            {
                temp += Convert.ToChar(list_name_arr1[i]);

                if (i == file_num * 40 - 1)
                {
                    file_num++;
                    name1[k1] = temp;
                    k1++;
                    temp = null;
                }
            }
            for (int i = 0; i < list_name_arr2.Length; i++)
            {
                temp += Convert.ToChar(list_name_arr2[i]);

                if (i == file_num * 40 - 1)
                {
                    file_num++;
                    name2[k2] = temp;
                    k2++;
                    temp = null;
                }
            }
            for (int i = 0; i < list_name_arr3.Length; i++)
            {
                temp += Convert.ToChar(list_name_arr3[i]);

                if (i == file_num * 40 - 1)
                {
                    file_num++;
                    name3[k3] = temp;
                    k3++;
                    temp = null;
                }
            }

            for (int i = 0; i < mode_0; i++)
            {
                if (name[i] != null)
                {
                    Only_name[i] = name[i].Substring(1, 16);//확장자 전까지 자름
                    Console.WriteLine(i + "번째 E 파일 : " + Only_name[i]);
                    if (E_check)
                    {
                        ListViewItem lvi = new ListViewItem(Only_name[i]);//첫번째 인자는 파일의 이름(확장자 제외)
                                                                          //ListViewItem lvi = new ListViewItem(Only_name[jj]+"avi");//첫번째 인자는 파일의 이름(확장자 포함)
                        lvi.SubItems.Add((list_size_arr[i] / (1024 * 1024)) + "M".ToString());//파일크기
                        lvi.SubItems.Add(list_time_arr[i].ToString());//확장자
                        lvi.SubItems.Add("nnnn");//절대경로
                        lvi.ImageIndex = 0;
                        listView.Items.Add(lvi);
                    }
                }
            }
            for (int i = 0; i < mode_1; i++)
            {
                if(name1[i] != null)
                { 
                    Only_name1[i] = name1[i].Substring(1, 16);//확장자 전까지 자름
                    Console.WriteLine(i + "번째 I 파일 : " + Only_name1[i]);
                    if (N_check)
                    {
                        ListViewItem lvi = new ListViewItem(Only_name1[i]);//첫번째 인자는 파일의 이름(확장자 제외)
                                                                           //ListViewItem lvi = new ListViewItem(Only_name[jj]+"avi");//첫번째 인자는 파일의 이름(확장자 포함)
                        lvi.SubItems.Add((list_size_arr1[i] / (1024 * 1024)) + "M".ToString());//파일크기
                        lvi.SubItems.Add(list_time_arr1[i].ToString());//확장자
                        lvi.SubItems.Add("nnnn");//절대경로
                        lvi.ImageIndex = 0;
                        listView.Items.Add(lvi);
                    }
                }
            }
            for (int i = 0; i < mode_2; i++)
            {
                if (name2[i] != null)
                {
                    Only_name2[i] = name2[i].Substring(1, 16);//확장자 전까지 자름
                    Console.WriteLine(i + "번째 P 파일 : " + Only_name2[i]);
                    if (P_check)
                    {
                        ListViewItem lvi = new ListViewItem(Only_name2[i]);//첫번째 인자는 파일의 이름(확장자 제외)
                                                                           //ListViewItem lvi = new ListViewItem(Only_name[jj]+"avi");//첫번째 인자는 파일의 이름(확장자 포함)
                        lvi.SubItems.Add((list_size_arr2[i] / (1024 * 1024)) + "M".ToString());//파일크기
                        lvi.SubItems.Add(list_time_arr2[i].ToString());//확장자
                        lvi.SubItems.Add("nnnn");//절대경로
                        lvi.ImageIndex = 0;
                        listView.Items.Add(lvi);
                    }
                }
            }
            for (int i = 0; i < mode_3; i++)
            {
                if (name3[i] != null)
                {
                    Only_name3[i] = name3[i].Substring(1, 16);//확장자 전까지 자름
                    Console.WriteLine(i + "번째 M 파일 : " + Only_name3[i]);
                    if (M_check)
                    {
                        ListViewItem lvi = new ListViewItem(Only_name3[i]);//첫번째 인자는 파일의 이름(확장자 제외)
                                                                           //ListViewItem lvi = new ListViewItem(Only_name[jj]+"avi");//첫번째 인자는 파일의 이름(확장자 포함)
                        lvi.SubItems.Add((list_size_arr3[i] / (1024 * 1024)) + "M".ToString());//파일크기
                        lvi.SubItems.Add(list_time_arr3[i].ToString());//확장자
                        lvi.SubItems.Add("nnnn");//절대경로
                        lvi.ImageIndex = 0;
                        listView.Items.Add(lvi);
                    }
                }
            }
            //이름만 추출
            /*
            for (int jj = 0; jj < file_cnt; jj++)
            {
                if (mode == 0)
                {
                    ListViewItem lvi = new ListViewItem(Only_name[jj]);//첫번째 인자는 파일의 이름(확장자 제외)
                    //ListViewItem lvi = new ListViewItem(Only_name[jj]+"avi");//첫번째 인자는 파일의 이름(확장자 포함)
                    lvi.SubItems.Add((list_size_arr[jj] / (1024 * 1024)) + "M".ToString());//파일크기
                    lvi.SubItems.Add(list_time_arr[jj].ToString());//확장자
                    lvi.SubItems.Add("nnnn");//절대경로
                    lvi.ImageIndex = 0;
                    listView.Items.Add(lvi);
                }
                else if (mode == 1)
                {
                    ListViewItem lvi = new ListViewItem(Only_name[jj]);//첫번째 인자는 파일의 이름(확장자 제외)
                    lvi.SubItems.Add((list_size_arr1[jj] / (1024 * 1024)) + "M".ToString());//파일크기
                    lvi.SubItems.Add(list_time_arr1[jj].ToString());//확장자
                    lvi.SubItems.Add("nnnn");//절대경로
                    lvi.ImageIndex = 0;
                    listView.Items.Add(lvi);
                }
                else if (mode == 2)
                {
                    ListViewItem lvi = new ListViewItem(Only_name[jj]);//첫번째 인자는 파일의 이름(확장자 제외)
                    lvi.SubItems.Add((list_size_arr2[jj] / (1024 * 1024)) + "M".ToString());//파일크기
                    lvi.SubItems.Add(list_time_arr2[jj].ToString());//확장자
                    lvi.SubItems.Add("nnnn");//절대경로
                    lvi.ImageIndex = 0;
                    listView.Items.Add(lvi);
                }
                else if (mode == 3)
                {
                    ListViewItem lvi = new ListViewItem(Only_name[jj]);//첫번째 인자는 파일의 이름(확장자 제외)
                    lvi.SubItems.Add((list_size_arr3[jj] / (1024 * 1024)) + "M".ToString());//파일크기
                    lvi.SubItems.Add(list_time_arr3[jj].ToString());//확장자
                    lvi.SubItems.Add("nnnn");//절대경로
                    lvi.ImageIndex = 0;
                    listView.Items.Add(lvi);
                }
                
                
            }
            */
            listView.Update();
            listView.EndUpdate();
        }

        private void initFileList(string curdir)
        {
            DirectoryInfo di = new DirectoryInfo(curdir);
            FileInfo[] files = di.GetFiles();
            listView.BeginUpdate();
            listView.View = View.Details;
            string f_name, f_extention;
            foreach(var fi in files)
            {
                f_name = Path.GetFileNameWithoutExtension(fi.ToString());
                f_extention = Path.GetExtension(fi.ToString());

                if (f_extention == ".zip")
                    continue;
                //일단 zip파일만 거르게 해놓았음
                //추가로 확장자를 넣어주면 됨
                ListViewItem lvi = new ListViewItem(f_name);//첫번째 인자는 파일의 이름(확장자 제외)

                lvi.SubItems.Add(fi.Length.ToString());//파일크기
                lvi.SubItems.Add(f_extention);//확장자
                lvi.SubItems.Add(fi.FullName);//절대경로
                lvi.ImageIndex = 0;
                listView.Items.Add(lvi);
            }
            listView.EndUpdate();
        }
        
        private void Video_Stop()
        {
            
        }

        private void Video_Capture()
        {
            
        }

        private void Video_Play()
        {
            vid.Size = video_panel.Size;
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
        }
        
        public MainForm()
        {
            InitializeComponent();
            //디바이스 옵션
            PresentParameters present_params = new PresentParameters();
            present_params.Windowed = true;
            present_params.SwapEffect = SwapEffect.Discard;
            //디바이스 생성
            _device = new Device(0, DeviceType.Hardware,
                this, CreateFlags.HardwareVertexProcessing,
                present_params);

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

            timer1.Interval = 1;
            timer1.Enabled = true;
        }
        
       private void StartTimer()
        {
            timer1.Interval = 33;
            timer1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GSensor_Chart();
            TAT_device();
            TAT_showlist();
            this.listView.View = View.Details;
            this.listView.Columns.Add("파일이름", 130, HorizontalAlignment.Center);
            this.listView.Columns.Add("파일크기", 60, HorizontalAlignment.Center);
            this.listView.Columns.Add("재생시간", 60, HorizontalAlignment.Center);
            this.listView.Columns.Add("상대경로", 80, HorizontalAlignment.Center);
        }
        public void SetData(String Data)
        {
            video_path = Data;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(video_path);    //setting 폼에 영상path 넘겨줌       
            setting.ShowDialog();
        }

        private void LeftRight_Scroll(object sender, EventArgs e)
        {
            
        }

        private void UpDown_Scroll(object sender, EventArgs e)
        {

        }

        private void audio_step_forward_Click(object sender, EventArgs e)
        {
            System.Drawing.Size Panel_Size;
            Panel_Size = video_panel.Size;

            if (listView.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listView.SelectedItems;
                ListView.SelectedIndexCollection indexes = this.listView.SelectedIndices;
                var SelectedItem = listView.SelectedItems[0];
                int selectedIndex = listView.Items.IndexOf(SelectedItem);
                listView.Items[selectedIndex].Selected = false;
                listView.Items[selectedIndex + 1].Selected = true;
                listView.Select();
                audio_play_Click(null, null);
            }
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
                audio_stop.Enabled = true;
                audio_stop.Visible = true;

                audio_play.Enabled = false;
                audio_play.Visible = false;

                audio_pause.Enabled = true;
                audio_pause.Visible = true;
                
                Video_Timer_Enable = true;

                Video_Play();//비디오의 총 길이 반환
                vid.Play();
            }
            else
            {
                MessageBox.Show("Double click Video");
            }
        }

        private void audio_step_back_Click(object sender, EventArgs e)
        {
            
        }

        private void Marker_Click(object sender, EventArgs e)
        {
            String city = "Seoul";
            String state = "";
            String country = "";
            StringBuilder add = new StringBuilder("http://");
            add.Append(city);
            add.Append(state);
            add.Append(country);
            webBrowser.Navigate(add.ToString());
            webBrowser.Navigate("http://52.78.22.120:5000/map");
        }

        private void folder_open_Click(object sender, EventArgs e)
        {
            string curdir;
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.SelectedPath = @"D:\testvideo\";//deafult 디렉토리 설정

            if (fd.ShowDialog() == DialogResult.OK) // 확인을 눌렀을 때
            {
                curdir = fd.SelectedPath;
                initFileList(curdir);
            }
            else
            {
                MessageBox.Show("Select Folder");
            }
        }
        int file_sum = 0;
        char Eevent = (char)0;

        unsafe private void Camera_Click(object sender, EventArgs e)
        {
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            //TAT_Make_Avi_File(handle, )
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

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            System.Drawing.Size Panel_Size;
            Panel_Size = video_panel.Size;
            /*
            try
            {
                if (listView.SelectedItems.Count == 1)
                {
                    ListView.SelectedListViewItemCollection items = listView.SelectedItems;
                    ListViewItem lvItem = items[0];
                    string add = lvItem.SubItems[0].Text;
                    video_path = listView.FocusedItem.SubItems[3].Text;
                    MessageBox.Show(video_path);

                    if (vid != null)
                        vid.Dispose();
                    vid = new Microsoft.DirectX.AudioVideoPlayback.Video(video_path);
                    vid.Owner = this.video_panel;
                    video_panel.Size = Panel_Size;

                    audio_play_Click(null, null);
                }
            }
            catch(Exception exa)
            {
                MessageBox.Show(exa.Message);
            }
            */
            /////기존 avi를 재생할때의 코드


            ///tat재생
            ///
            try
            {
                if (listView.SelectedItems.Count == 1)
                {
                    ListView.SelectedListViewItemCollection items = listView.SelectedItems;
                    ListViewItem lvItem = items[0];
                    string add = lvItem.SubItems[0].Text;
                    
                    string fname;
                    fname = listView.FocusedItem.SubItems[0].Text;
                    TAT_Make_Avi_File(handle, fname);

                    video_path =Application.StartupPath +@"./" + fname;
                    if (vid != null)
                        vid.Dispose();
                    vid = new Microsoft.DirectX.AudioVideoPlayback.Video(video_path);
                    vid.Owner = this.video_panel;
                    video_panel.Size = Panel_Size;

                    audio_play_Click(null, null);
                }
            }
            catch (Exception exa)
            {
                MessageBox.Show(exa.Message);
            }
        }
        private void GSensor_Chart()
        {
            Gsensor.ChartAreas.Add("Gsensor");
            Gsensor.ChartAreas["Xaxis"].AxisX.Minimum = 0;
            Gsensor.ChartAreas["Xaxis"].AxisX.Maximum = 100;
            Gsensor.ChartAreas["Yaxis"].AxisY.Minimum = 0;
            Gsensor.ChartAreas["Yaxis"].AxisY.Maximum = 100;
            Gsensor.Series.Add("Xaxis");
            Gsensor.Series["Xaxis"].ChartArea = "Gsensor";
            Gsensor.Series["Xaxis"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            Gsensor.Series.Add("Yaxis");
            Gsensor.Series["Yaxis"].ChartArea = "Gsensor";
            Gsensor.Series["Yaxis"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            Gsensor.Series.Add("Zaxis");
            Gsensor.Series["Zaxis"].ChartArea = "Gsensor";
            Gsensor.Series["Zaxis"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            Gsensor.ChartAreas["Xaxis"].AxisX.Minimum = 0;
            Gsensor.ChartAreas["Xaxis"].AxisX.Maximum = 100;
            Gsensor.ChartAreas["Yaxis"].AxisY.Minimum = 0;
            Gsensor.ChartAreas["Yaxis"].AxisY.Maximum = 100;

            Random rand = new Random();

            for(int i=0; i<100; i++)
            {
                Gsensor.Series["Xaxis"].Points.Add(rand.Next(500));
                Gsensor.Series["Yaxis"].Points.Add(rand.Next(500));
                Gsensor.Series["Zaxis"].Points.Add(rand.Next(500));
            }
      
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Volume_Bar.Visible = true;
        }

        private void Volume_MouseLeave(object sender, EventArgs e)
        {
        }

        private void Volume_Bar_MouseEnter(object sender, EventArgs e)
        {
            Volume_Bar.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void Volume_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void Volume_Bar_MouseLeave(object sender, EventArgs e)
        {
            Volume_Bar.Visible = false;
        }

        private void videoSpeed_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void videoSpeed_bar_MouseLeave(object sender, EventArgs e)
        {
            videoSpeed_bar.Visible = false;
        }

        private void videoSpeed_MouseMove(object sender, MouseEventArgs e)
        {
            videoSpeed_bar.Visible = true;
        }

        private void Dirve_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Dirve_btn.Checked)
            { 
                MessageBox.Show("drive checked");
                N_check = true;
            }
            else if (!Dirve_btn.Checked)
            { 
                MessageBox.Show("drive unchecked");
                N_check = false;
            }
            else
                MessageBox.Show("drive button error");
            TAT_showlist();
        }

        private void Event_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Event_btn.Checked)
            { 
                MessageBox.Show("Event checked");
                E_check = true;
            }
            else if (!Event_btn.Checked)
            { 
                MessageBox.Show("Event unchecked");
                E_check = false;
            }
            else
                MessageBox.Show("drive button error");
            TAT_showlist();
        }

        private void Parking_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Parking_btn.Checked)
            { 
                MessageBox.Show("Parking checked");
                P_check = true;
            }
            else if (!Parking_btn.Checked)
            { 
                MessageBox.Show("parking uncheked");
                P_check = false;
            }
            else
                MessageBox.Show("drive button error");
            TAT_showlist();
        }

        private void Camera_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Camera_btn.Checked)
            { 
                MessageBox.Show("camera checked");
                M_check = true;
            }
            else if (!Camera_btn.Checked)
            { 
                MessageBox.Show("camera unchecked");
                M_check = false;
            }
            else
                MessageBox.Show("camera button error");
            TAT_showlist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Size Panel_Size;
            Panel_Size = video_panel.Size;

            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                if (vid != null)
                    vid.Dispose();
                vid = new Microsoft.DirectX.AudioVideoPlayback.Video(of.FileName);
                vid.Owner = this.video_panel;
                video_panel.Size = Panel_Size;
            }
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
                if (Path.GetExtension(VideoFile) == ".avi")
                    Valid_FileType = true;
                /*
                if (VideoFile.EndsWith(".avi") || VideoFile.EndsWith(".wmv"))
                    Valid_FileType = true;
                    */
            }
        }
    }
}