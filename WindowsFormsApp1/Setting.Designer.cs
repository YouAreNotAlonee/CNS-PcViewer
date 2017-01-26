namespace WindowsFormsApp1
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Shiness_plus = new System.Windows.Forms.Button();
            this.Shiness_label = new System.Windows.Forms.Label();
            this.Shiness_minus = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Exposure_plus = new System.Windows.Forms.Button();
            this.Exposure_label = new System.Windows.Forms.Label();
            this.Exposure_minus = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Shade_plus = new System.Windows.Forms.Button();
            this.Shade_label = new System.Windows.Forms.Label();
            this.Shade_minus = new System.Windows.Forms.Button();
            this.Setting_save = new System.Windows.Forms.Button();
            this.Setting_default = new System.Windows.Forms.Button();
            this.Setting_cancel = new System.Windows.Forms.Button();
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flip_X = new System.Windows.Forms.CheckBox();
            this.flip_Y = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flip_Y);
            this.groupBox1.Controls.Add(this.flip_X);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(418, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "영상품질";
            // 
            // radioButton2
            // 
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton2.Location = new System.Drawing.Point(226, 16);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "HD+HD";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton1.Location = new System.Drawing.Point(91, 16);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "FHD+HD";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton13);
            this.groupBox2.Controls.Add(this.radioButton12);
            this.groupBox2.Controls.Add(this.radioButton11);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(418, 48);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "화이트밸런스";
            // 
            // radioButton13
            // 
            this.radioButton13.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton13.Location = new System.Drawing.Point(352, 16);
            this.radioButton13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(62, 27);
            this.radioButton13.TabIndex = 4;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "흐림";
            this.radioButton13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton12.Location = new System.Drawing.Point(284, 16);
            this.radioButton12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(62, 27);
            this.radioButton12.TabIndex = 3;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "밝음";
            this.radioButton12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton11.Location = new System.Drawing.Point(217, 16);
            this.radioButton11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(62, 27);
            this.radioButton11.TabIndex = 2;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "형광등";
            this.radioButton11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton3.Location = new System.Drawing.Point(150, 16);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 27);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "백열등";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton4.Location = new System.Drawing.Point(82, 16);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(62, 27);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "자동";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Shiness_plus);
            this.groupBox3.Controls.Add(this.Shiness_label);
            this.groupBox3.Controls.Add(this.Shiness_minus);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 96);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(418, 48);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "밝기 (1 ~ 7)";
            // 
            // Shiness_plus
            // 
            this.Shiness_plus.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.More;
            this.Shiness_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Shiness_plus.Location = new System.Drawing.Point(182, 20);
            this.Shiness_plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Shiness_plus.Name = "Shiness_plus";
            this.Shiness_plus.Size = new System.Drawing.Size(28, 18);
            this.Shiness_plus.TabIndex = 2;
            this.Shiness_plus.Text = "+";
            this.Shiness_plus.UseVisualStyleBackColor = true;
            this.Shiness_plus.Click += new System.EventHandler(this.Shiness_plus_Click);
            // 
            // Shiness_label
            // 
            this.Shiness_label.AutoSize = true;
            this.Shiness_label.Location = new System.Drawing.Point(164, 23);
            this.Shiness_label.Name = "Shiness_label";
            this.Shiness_label.Size = new System.Drawing.Size(11, 12);
            this.Shiness_label.TabIndex = 1;
            this.Shiness_label.Text = "6";
            // 
            // Shiness_minus
            // 
            this.Shiness_minus.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Less;
            this.Shiness_minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Shiness_minus.Location = new System.Drawing.Point(130, 20);
            this.Shiness_minus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Shiness_minus.Name = "Shiness_minus";
            this.Shiness_minus.Size = new System.Drawing.Size(28, 18);
            this.Shiness_minus.TabIndex = 0;
            this.Shiness_minus.Text = "-";
            this.Shiness_minus.UseVisualStyleBackColor = true;
            this.Shiness_minus.Click += new System.EventHandler(this.Shiness_minus_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Exposure_plus);
            this.groupBox4.Controls.Add(this.Exposure_label);
            this.groupBox4.Controls.Add(this.Exposure_minus);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 144);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(418, 48);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "노출 (-3 ~ +3)";
            // 
            // Exposure_plus
            // 
            this.Exposure_plus.Location = new System.Drawing.Point(182, 19);
            this.Exposure_plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exposure_plus.Name = "Exposure_plus";
            this.Exposure_plus.Size = new System.Drawing.Size(28, 18);
            this.Exposure_plus.TabIndex = 5;
            this.Exposure_plus.Text = "+";
            this.Exposure_plus.UseVisualStyleBackColor = true;
            this.Exposure_plus.Click += new System.EventHandler(this.Exposure_plus_Click);
            // 
            // Exposure_label
            // 
            this.Exposure_label.AutoSize = true;
            this.Exposure_label.Location = new System.Drawing.Point(164, 22);
            this.Exposure_label.Name = "Exposure_label";
            this.Exposure_label.Size = new System.Drawing.Size(11, 12);
            this.Exposure_label.TabIndex = 4;
            this.Exposure_label.Text = "0";
            // 
            // Exposure_minus
            // 
            this.Exposure_minus.Location = new System.Drawing.Point(130, 19);
            this.Exposure_minus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exposure_minus.Name = "Exposure_minus";
            this.Exposure_minus.Size = new System.Drawing.Size(28, 18);
            this.Exposure_minus.TabIndex = 3;
            this.Exposure_minus.Text = "-";
            this.Exposure_minus.UseVisualStyleBackColor = true;
            this.Exposure_minus.Click += new System.EventHandler(this.Exposure_minus_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Shade_plus);
            this.groupBox5.Controls.Add(this.Shade_label);
            this.groupBox5.Controls.Add(this.Shade_minus);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 192);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(418, 48);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "명암";
            // 
            // Shade_plus
            // 
            this.Shade_plus.Location = new System.Drawing.Point(182, 19);
            this.Shade_plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Shade_plus.Name = "Shade_plus";
            this.Shade_plus.Size = new System.Drawing.Size(28, 18);
            this.Shade_plus.TabIndex = 8;
            this.Shade_plus.Text = "+";
            this.Shade_plus.UseVisualStyleBackColor = true;
            this.Shade_plus.Click += new System.EventHandler(this.Shade_plus_Click);
            // 
            // Shade_label
            // 
            this.Shade_label.AutoSize = true;
            this.Shade_label.Location = new System.Drawing.Point(164, 22);
            this.Shade_label.Name = "Shade_label";
            this.Shade_label.Size = new System.Drawing.Size(11, 12);
            this.Shade_label.TabIndex = 7;
            this.Shade_label.Text = "0";
            // 
            // Shade_minus
            // 
            this.Shade_minus.Location = new System.Drawing.Point(130, 19);
            this.Shade_minus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Shade_minus.Name = "Shade_minus";
            this.Shade_minus.Size = new System.Drawing.Size(28, 18);
            this.Shade_minus.TabIndex = 6;
            this.Shade_minus.Text = "-";
            this.Shade_minus.UseVisualStyleBackColor = true;
            this.Shade_minus.Click += new System.EventHandler(this.Shade_minus_Click);
            // 
            // Setting_save
            // 
            this.Setting_save.Location = new System.Drawing.Point(10, 245);
            this.Setting_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Setting_save.Name = "Setting_save";
            this.Setting_save.Size = new System.Drawing.Size(96, 30);
            this.Setting_save.TabIndex = 8;
            this.Setting_save.Text = "저장";
            this.Setting_save.UseVisualStyleBackColor = true;
            this.Setting_save.Click += new System.EventHandler(this.Setting_save_Click);
            // 
            // Setting_default
            // 
            this.Setting_default.Location = new System.Drawing.Point(158, 245);
            this.Setting_default.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Setting_default.Name = "Setting_default";
            this.Setting_default.Size = new System.Drawing.Size(96, 30);
            this.Setting_default.TabIndex = 9;
            this.Setting_default.Text = "기본값으로";
            this.Setting_default.UseVisualStyleBackColor = true;
            this.Setting_default.Click += new System.EventHandler(this.Setting_default_Click);
            // 
            // Setting_cancel
            // 
            this.Setting_cancel.Location = new System.Drawing.Point(312, 245);
            this.Setting_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Setting_cancel.Name = "Setting_cancel";
            this.Setting_cancel.Size = new System.Drawing.Size(96, 30);
            this.Setting_cancel.TabIndex = 10;
            this.Setting_cancel.Text = "취소";
            this.Setting_cancel.UseVisualStyleBackColor = true;
            this.Setting_cancel.Click += new System.EventHandler(this.Setting_cancel_Click);
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(11, 280);
            this.pictureBoxIpl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(396, 134);
            this.pictureBoxIpl1.TabIndex = 11;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flip_X
            // 
            this.flip_X.AutoSize = true;
            this.flip_X.Location = new System.Drawing.Point(295, 20);
            this.flip_X.Name = "flip_X";
            this.flip_X.Size = new System.Drawing.Size(44, 16);
            this.flip_X.TabIndex = 2;
            this.flip_X.Text = "X축";
            this.flip_X.UseVisualStyleBackColor = true;
            this.flip_X.CheckedChanged += new System.EventHandler(this.flip_X_CheckedChanged);
            // 
            // flip_Y
            // 
            this.flip_Y.AutoSize = true;
            this.flip_Y.Location = new System.Drawing.Point(352, 19);
            this.flip_Y.Name = "flip_Y";
            this.flip_Y.Size = new System.Drawing.Size(44, 16);
            this.flip_Y.TabIndex = 3;
            this.flip_Y.Text = "Y축";
            this.flip_Y.UseVisualStyleBackColor = true;
            this.flip_Y.CheckedChanged += new System.EventHandler(this.flip_Y_CheckedChanged);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 423);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Controls.Add(this.Setting_cancel);
            this.Controls.Add(this.Setting_default);
            this.Controls.Add(this.Setting_save);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Shiness_plus;
        private System.Windows.Forms.Label Shiness_label;
        private System.Windows.Forms.Button Shiness_minus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Exposure_plus;
        private System.Windows.Forms.Label Exposure_label;
        private System.Windows.Forms.Button Exposure_minus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Shade_plus;
        private System.Windows.Forms.Label Shade_label;
        private System.Windows.Forms.Button Shade_minus;
        private System.Windows.Forms.Button Setting_save;
        private System.Windows.Forms.Button Setting_default;
        private System.Windows.Forms.Button Setting_cancel;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox flip_Y;
        private System.Windows.Forms.CheckBox flip_X;
    }
}