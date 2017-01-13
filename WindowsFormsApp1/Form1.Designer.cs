namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.zero_dot_two_btn = new System.Windows.Forms.Button();
            this.zero_dot_five_btn = new System.Windows.Forms.Button();
            this.one_dot_zero_btn = new System.Windows.Forms.Button();
            this.one_dot_five_btn = new System.Windows.Forms.Button();
            this.two_dot_zero_btn = new System.Windows.Forms.Button();
            this.Speed_tbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Volume_Bar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Marker = new System.Windows.Forms.Button();
            this.folder_open = new System.Windows.Forms.Button();
            this.Camera = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.audio_step_forward = new System.Windows.Forms.Button();
            this.audio_stop = new System.Windows.Forms.Button();
            this.audio_play = new System.Windows.Forms.Button();
            this.audio_step_back = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.LeftRight = new System.Windows.Forms.TrackBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.UpDown = new System.Windows.Forms.TrackBar();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.curTime = new System.Windows.Forms.TextBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VideoTime = new System.Windows.Forms.TextBox();
            this.Dirve_btn = new System.Windows.Forms.CheckBox();
            this.Event_btn = new System.Windows.Forms.CheckBox();
            this.Parking_btn = new System.Windows.Forms.CheckBox();
            this.Camera_btn = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.audio_pause = new System.Windows.Forms.Button();
            this.video_panel = new System.Windows.Forms.Panel();
            this.Video_Timer = new System.Windows.Forms.Timer(this.components);
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("문체부 제목 돋음체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIEWER";
            // 
            // zero_dot_two_btn
            // 
            this.zero_dot_two_btn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.zero_dot_two_btn.Location = new System.Drawing.Point(14, 846);
            this.zero_dot_two_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zero_dot_two_btn.Name = "zero_dot_two_btn";
            this.zero_dot_two_btn.Size = new System.Drawing.Size(69, 50);
            this.zero_dot_two_btn.TabIndex = 1;
            this.zero_dot_two_btn.Text = "x 0.2";
            this.zero_dot_two_btn.UseVisualStyleBackColor = true;
            this.zero_dot_two_btn.Click += new System.EventHandler(this.zero_dot_two_btn_Click);
            // 
            // zero_dot_five_btn
            // 
            this.zero_dot_five_btn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.zero_dot_five_btn.Location = new System.Drawing.Point(89, 846);
            this.zero_dot_five_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zero_dot_five_btn.Name = "zero_dot_five_btn";
            this.zero_dot_five_btn.Size = new System.Drawing.Size(69, 50);
            this.zero_dot_five_btn.TabIndex = 2;
            this.zero_dot_five_btn.Text = "x 0.5";
            this.zero_dot_five_btn.UseVisualStyleBackColor = true;
            this.zero_dot_five_btn.Click += new System.EventHandler(this.zero_dot_five_btn_Click);
            // 
            // one_dot_zero_btn
            // 
            this.one_dot_zero_btn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.one_dot_zero_btn.Location = new System.Drawing.Point(165, 846);
            this.one_dot_zero_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.one_dot_zero_btn.Name = "one_dot_zero_btn";
            this.one_dot_zero_btn.Size = new System.Drawing.Size(69, 50);
            this.one_dot_zero_btn.TabIndex = 3;
            this.one_dot_zero_btn.Text = "x 1.0";
            this.one_dot_zero_btn.UseVisualStyleBackColor = true;
            this.one_dot_zero_btn.Click += new System.EventHandler(this.one_dot_zero_btn_Click);
            // 
            // one_dot_five_btn
            // 
            this.one_dot_five_btn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.one_dot_five_btn.Location = new System.Drawing.Point(240, 846);
            this.one_dot_five_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.one_dot_five_btn.Name = "one_dot_five_btn";
            this.one_dot_five_btn.Size = new System.Drawing.Size(69, 50);
            this.one_dot_five_btn.TabIndex = 4;
            this.one_dot_five_btn.Text = "x 1.5";
            this.one_dot_five_btn.UseVisualStyleBackColor = true;
            this.one_dot_five_btn.Click += new System.EventHandler(this.one_dot_five_btn_Click);
            // 
            // two_dot_zero_btn
            // 
            this.two_dot_zero_btn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.two_dot_zero_btn.Location = new System.Drawing.Point(315, 846);
            this.two_dot_zero_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.two_dot_zero_btn.Name = "two_dot_zero_btn";
            this.two_dot_zero_btn.Size = new System.Drawing.Size(69, 50);
            this.two_dot_zero_btn.TabIndex = 5;
            this.two_dot_zero_btn.Text = "x 2.0";
            this.two_dot_zero_btn.UseVisualStyleBackColor = true;
            this.two_dot_zero_btn.Click += new System.EventHandler(this.two_dot_zero_btn_Click);
            // 
            // Speed_tbox
            // 
            this.Speed_tbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Speed_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Speed_tbox.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Speed_tbox.Location = new System.Drawing.Point(8, 74);
            this.Speed_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Speed_tbox.Name = "Speed_tbox";
            this.Speed_tbox.Size = new System.Drawing.Size(78, 41);
            this.Speed_tbox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(93, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "km/h";
            // 
            // Volume_Bar
            // 
            this.Volume_Bar.LargeChange = 1;
            this.Volume_Bar.Location = new System.Drawing.Point(221, 74);
            this.Volume_Bar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Volume_Bar.Maximum = 100;
            this.Volume_Bar.Name = "Volume_Bar";
            this.Volume_Bar.Size = new System.Drawing.Size(175, 45);
            this.Volume_Bar.TabIndex = 18;
            this.Volume_Bar.Value = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(14, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "G 센서";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Audio;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(185, 68);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 56);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.testimage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 65);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Marker
            // 
            this.Marker.BackColor = System.Drawing.Color.Transparent;
            this.Marker.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Marker;
            this.Marker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Marker.Location = new System.Drawing.Point(1015, 846);
            this.Marker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Marker.Name = "Marker";
            this.Marker.Size = new System.Drawing.Size(69, 50);
            this.Marker.TabIndex = 14;
            this.Marker.UseVisualStyleBackColor = false;
            this.Marker.Click += new System.EventHandler(this.Marker_Click);
            // 
            // folder_open
            // 
            this.folder_open.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.folder_open;
            this.folder_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.folder_open.Location = new System.Drawing.Point(1090, 846);
            this.folder_open.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.folder_open.Name = "folder_open";
            this.folder_open.Size = new System.Drawing.Size(69, 50);
            this.folder_open.TabIndex = 13;
            this.folder_open.UseVisualStyleBackColor = true;
            this.folder_open.Click += new System.EventHandler(this.folder_open_Click);
            // 
            // Camera
            // 
            this.Camera.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Camera;
            this.Camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Camera.Location = new System.Drawing.Point(1166, 846);
            this.Camera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(69, 50);
            this.Camera.TabIndex = 12;
            this.Camera.UseVisualStyleBackColor = true;
            this.Camera.Click += new System.EventHandler(this.Camera_Click);
            // 
            // save
            // 
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.Location = new System.Drawing.Point(1241, 846);
            this.save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(69, 50);
            this.save.TabIndex = 11;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Settings
            // 
            this.Settings.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Settings;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settings.Location = new System.Drawing.Point(1317, 846);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(69, 50);
            this.Settings.TabIndex = 10;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // audio_step_forward
            // 
            this.audio_step_forward.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.audio_step_forward;
            this.audio_step_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.audio_step_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audio_step_forward.ForeColor = System.Drawing.SystemColors.Control;
            this.audio_step_forward.Location = new System.Drawing.Point(824, 846);
            this.audio_step_forward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.audio_step_forward.Name = "audio_step_forward";
            this.audio_step_forward.Size = new System.Drawing.Size(69, 50);
            this.audio_step_forward.TabIndex = 9;
            this.audio_step_forward.UseVisualStyleBackColor = true;
            this.audio_step_forward.Click += new System.EventHandler(this.audio_step_forward_Click);
            // 
            // audio_stop
            // 
            this.audio_stop.BackColor = System.Drawing.SystemColors.Control;
            this.audio_stop.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.audio_stop;
            this.audio_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.audio_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audio_stop.ForeColor = System.Drawing.SystemColors.Control;
            this.audio_stop.Location = new System.Drawing.Point(749, 846);
            this.audio_stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.audio_stop.Name = "audio_stop";
            this.audio_stop.Size = new System.Drawing.Size(69, 50);
            this.audio_stop.TabIndex = 8;
            this.audio_stop.UseVisualStyleBackColor = true;
            this.audio_stop.Click += new System.EventHandler(this.audio_stop_Click);
            // 
            // audio_play
            // 
            this.audio_play.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.audio_play;
            this.audio_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.audio_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audio_play.ForeColor = System.Drawing.SystemColors.Control;
            this.audio_play.Location = new System.Drawing.Point(598, 846);
            this.audio_play.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.audio_play.Name = "audio_play";
            this.audio_play.Size = new System.Drawing.Size(69, 50);
            this.audio_play.TabIndex = 7;
            this.audio_play.UseVisualStyleBackColor = true;
            this.audio_play.Click += new System.EventHandler(this.audio_play_Click);
            // 
            // audio_step_back
            // 
            this.audio_step_back.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.audio_step_back;
            this.audio_step_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.audio_step_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audio_step_back.ForeColor = System.Drawing.SystemColors.Control;
            this.audio_step_back.Location = new System.Drawing.Point(522, 846);
            this.audio_step_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.audio_step_back.Name = "audio_step_back";
            this.audio_step_back.Size = new System.Drawing.Size(69, 50);
            this.audio_step_back.TabIndex = 6;
            this.audio_step_back.UseVisualStyleBackColor = true;
            this.audio_step_back.Click += new System.EventHandler(this.audio_step_back_Click);
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(1015, 64);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(370, 375);
            this.listView.TabIndex = 33;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // LeftRight
            // 
            this.LeftRight.Location = new System.Drawing.Point(483, 74);
            this.LeftRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LeftRight.Maximum = 1;
            this.LeftRight.Name = "LeftRight";
            this.LeftRight.Size = new System.Drawing.Size(119, 45);
            this.LeftRight.TabIndex = 34;
            this.LeftRight.Scroll += new System.EventHandler(this.LeftRight_Scroll);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.UnitedArrowUpDown_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(430, 68);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 58);
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // UpDown
            // 
            this.UpDown.Location = new System.Drawing.Point(686, 74);
            this.UpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpDown.Maximum = 1;
            this.UpDown.Name = "UpDown";
            this.UpDown.Size = new System.Drawing.Size(119, 45);
            this.UpDown.TabIndex = 36;
            this.UpDown.Scroll += new System.EventHandler(this.UpDown_Scroll);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.UnitedArrowUpDown;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(634, 68);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 56);
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // curTime
            // 
            this.curTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.curTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.curTime.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.curTime.Location = new System.Drawing.Point(802, 8);
            this.curTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.curTime.Name = "curTime";
            this.curTime.Size = new System.Drawing.Size(103, 15);
            this.curTime.TabIndex = 39;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(0, 8);
            this.trackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 1);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(805, 45);
            this.trackBar.TabIndex = 40;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            this.trackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseDown);
            this.trackBar.MouseEnter += new System.EventHandler(this.trackBar_MouseEnter);
            this.trackBar.MouseLeave += new System.EventHandler(this.trackBar_MouseLeave);
            this.trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.VideoTime);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.curTime);
            this.groupBox1.Controls.Add(this.Speed_tbox);
            this.groupBox1.Controls.Add(this.trackBar);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.UpDown);
            this.groupBox1.Controls.Add(this.Volume_Bar);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.LeftRight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 511);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1003, 138);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // VideoTime
            // 
            this.VideoTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VideoTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VideoTime.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VideoTime.Location = new System.Drawing.Point(901, 8);
            this.VideoTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VideoTime.Name = "VideoTime";
            this.VideoTime.Size = new System.Drawing.Size(102, 15);
            this.VideoTime.TabIndex = 41;
            // 
            // Dirve_btn
            // 
            this.Dirve_btn.AutoSize = true;
            this.Dirve_btn.Checked = true;
            this.Dirve_btn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Dirve_btn.Font = new System.Drawing.Font("굴림", 12F);
            this.Dirve_btn.Location = new System.Drawing.Point(1016, 31);
            this.Dirve_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dirve_btn.Name = "Dirve_btn";
            this.Dirve_btn.Size = new System.Drawing.Size(59, 20);
            this.Dirve_btn.TabIndex = 42;
            this.Dirve_btn.Text = "상시";
            this.Dirve_btn.UseVisualStyleBackColor = true;
            this.Dirve_btn.CheckedChanged += new System.EventHandler(this.Dirve_btn_CheckedChanged);
            // 
            // Event_btn
            // 
            this.Event_btn.AutoSize = true;
            this.Event_btn.Checked = true;
            this.Event_btn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Event_btn.Font = new System.Drawing.Font("굴림", 12F);
            this.Event_btn.Location = new System.Drawing.Point(1101, 31);
            this.Event_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Event_btn.Name = "Event_btn";
            this.Event_btn.Size = new System.Drawing.Size(75, 20);
            this.Event_btn.TabIndex = 43;
            this.Event_btn.Text = "이벤트";
            this.Event_btn.UseVisualStyleBackColor = true;
            this.Event_btn.CheckedChanged += new System.EventHandler(this.Event_btn_CheckedChanged);
            // 
            // Parking_btn
            // 
            this.Parking_btn.AutoSize = true;
            this.Parking_btn.Checked = true;
            this.Parking_btn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Parking_btn.Font = new System.Drawing.Font("굴림", 12F);
            this.Parking_btn.Location = new System.Drawing.Point(1206, 31);
            this.Parking_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Parking_btn.Name = "Parking_btn";
            this.Parking_btn.Size = new System.Drawing.Size(59, 20);
            this.Parking_btn.TabIndex = 44;
            this.Parking_btn.Text = "주차";
            this.Parking_btn.UseVisualStyleBackColor = true;
            this.Parking_btn.CheckedChanged += new System.EventHandler(this.Parking_btn_CheckedChanged);
            // 
            // Camera_btn
            // 
            this.Camera_btn.AutoSize = true;
            this.Camera_btn.Checked = true;
            this.Camera_btn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Camera_btn.Font = new System.Drawing.Font("굴림", 12F);
            this.Camera_btn.Location = new System.Drawing.Point(1294, 31);
            this.Camera_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Camera_btn.Name = "Camera_btn";
            this.Camera_btn.Size = new System.Drawing.Size(75, 20);
            this.Camera_btn.TabIndex = 45;
            this.Camera_btn.Text = "카메라";
            this.Camera_btn.UseVisualStyleBackColor = true;
            this.Camera_btn.CheckedChanged += new System.EventHandler(this.Camera_btn_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 58);
            this.button1.TabIndex = 48;
            this.button1.Text = "Select Video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // audio_pause
            // 
            this.audio_pause.BackColor = System.Drawing.SystemColors.Control;
            this.audio_pause.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.audio_pause;
            this.audio_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.audio_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audio_pause.ForeColor = System.Drawing.SystemColors.Control;
            this.audio_pause.Location = new System.Drawing.Point(673, 846);
            this.audio_pause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.audio_pause.Name = "audio_pause";
            this.audio_pause.Size = new System.Drawing.Size(69, 50);
            this.audio_pause.TabIndex = 49;
            this.audio_pause.UseVisualStyleBackColor = false;
            this.audio_pause.Click += new System.EventHandler(this.audio_pause_Click);
            // 
            // video_panel
            // 
            this.video_panel.Location = new System.Drawing.Point(89, 31);
            this.video_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.video_panel.Name = "video_panel";
            this.video_panel.Size = new System.Drawing.Size(920, 472);
            this.video_panel.TabIndex = 46;
            // 
            // Video_Timer
            // 
            this.Video_Timer.Tick += new System.EventHandler(this.Video_Timer_Tick);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(1015, 446);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webBrowser.MinimumSize = new System.Drawing.Size(23, 25);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(361, 385);
            this.webBrowser.TabIndex = 50;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(5, 105);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(114, 62);
            this.pictureBox6.TabIndex = 51;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(5, 176);
            this.pictureBoxIpl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(114, 62);
            this.pictureBoxIpl1.TabIndex = 52;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1393, 911);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.audio_pause);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.video_panel);
            this.Controls.Add(this.Camera_btn);
            this.Controls.Add(this.Parking_btn);
            this.Controls.Add(this.Event_btn);
            this.Controls.Add(this.Dirve_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Marker);
            this.Controls.Add(this.folder_open);
            this.Controls.Add(this.Camera);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.audio_step_forward);
            this.Controls.Add(this.audio_stop);
            this.Controls.Add(this.audio_play);
            this.Controls.Add(this.audio_step_back);
            this.Controls.Add(this.two_dot_zero_btn);
            this.Controls.Add(this.one_dot_five_btn);
            this.Controls.Add(this.one_dot_zero_btn);
            this.Controls.Add(this.zero_dot_five_btn);
            this.Controls.Add(this.zero_dot_two_btn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "BB Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zero_dot_two_btn;
        private System.Windows.Forms.Button zero_dot_five_btn;
        private System.Windows.Forms.Button one_dot_zero_btn;
        private System.Windows.Forms.Button one_dot_five_btn;
        private System.Windows.Forms.Button two_dot_zero_btn;
        private System.Windows.Forms.Button audio_step_back;
        private System.Windows.Forms.Button audio_play;
        private System.Windows.Forms.Button audio_stop;
        private System.Windows.Forms.Button audio_step_forward;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Camera;
        private System.Windows.Forms.Button folder_open;
        private System.Windows.Forms.Button Marker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Speed_tbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Volume_Bar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TrackBar LeftRight;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TrackBar UpDown;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox curTime;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Dirve_btn;
        private System.Windows.Forms.CheckBox Event_btn;
        private System.Windows.Forms.CheckBox Parking_btn;
        private System.Windows.Forms.CheckBox Camera_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button audio_pause;
        private System.Windows.Forms.Panel video_panel;
        private System.Windows.Forms.Timer Video_Timer;
        private System.Windows.Forms.TextBox VideoTime;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.PictureBox pictureBox6;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.Timer timer1;
    }
}

