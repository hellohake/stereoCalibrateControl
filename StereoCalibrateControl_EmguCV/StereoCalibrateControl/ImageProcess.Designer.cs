namespace StereoCalibrateControl
{
    partial class ImageProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageProcess));
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noblurRadioBtn = new System.Windows.Forms.RadioButton();
            this.gaussianBlurRadioBtn = new System.Windows.Forms.RadioButton();
            this.medianBlurRadioBtn = new System.Windows.Forms.RadioButton();
            this.blurRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button12.Location = new System.Drawing.Point(8, 17);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(88, 29);
            this.button12.TabIndex = 11;
            this.button12.TabStop = false;
            this.button12.Text = "捕获当前图片";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(6, 20);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(107, 29);
            this.button14.TabIndex = 3;
            this.button14.TabStop = false;
            this.button14.Text = "固定阈值化";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(140, 20);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(106, 29);
            this.button15.TabIndex = 4;
            this.button15.TabStop = false;
            this.button15.Text = "自适应阈值化";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noblurRadioBtn);
            this.groupBox1.Controls.Add(this.gaussianBlurRadioBtn);
            this.groupBox1.Controls.Add(this.medianBlurRadioBtn);
            this.groupBox1.Controls.Add(this.blurRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像滤波";
            // 
            // noblurRadioBtn
            // 
            this.noblurRadioBtn.AutoSize = true;
            this.noblurRadioBtn.Location = new System.Drawing.Point(22, 24);
            this.noblurRadioBtn.Name = "noblurRadioBtn";
            this.noblurRadioBtn.Size = new System.Drawing.Size(83, 16);
            this.noblurRadioBtn.TabIndex = 3;
            this.noblurRadioBtn.Text = "不使用滤波";
            this.noblurRadioBtn.UseVisualStyleBackColor = true;
            this.noblurRadioBtn.CheckedChanged += new System.EventHandler(this.blurRadioBtn_CheckedChanged);
            // 
            // gaussianBlurRadioBtn
            // 
            this.gaussianBlurRadioBtn.AutoSize = true;
            this.gaussianBlurRadioBtn.Location = new System.Drawing.Point(166, 49);
            this.gaussianBlurRadioBtn.Name = "gaussianBlurRadioBtn";
            this.gaussianBlurRadioBtn.Size = new System.Drawing.Size(71, 16);
            this.gaussianBlurRadioBtn.TabIndex = 2;
            this.gaussianBlurRadioBtn.Text = "高斯滤波";
            this.gaussianBlurRadioBtn.UseVisualStyleBackColor = true;
            this.gaussianBlurRadioBtn.CheckedChanged += new System.EventHandler(this.blurRadioBtn_CheckedChanged);
            // 
            // medianBlurRadioBtn
            // 
            this.medianBlurRadioBtn.AutoSize = true;
            this.medianBlurRadioBtn.Location = new System.Drawing.Point(22, 49);
            this.medianBlurRadioBtn.Name = "medianBlurRadioBtn";
            this.medianBlurRadioBtn.Size = new System.Drawing.Size(71, 16);
            this.medianBlurRadioBtn.TabIndex = 1;
            this.medianBlurRadioBtn.Text = "中值滤波";
            this.medianBlurRadioBtn.UseVisualStyleBackColor = true;
            this.medianBlurRadioBtn.CheckedChanged += new System.EventHandler(this.blurRadioBtn_CheckedChanged);
            // 
            // blurRadioBtn
            // 
            this.blurRadioBtn.AutoSize = true;
            this.blurRadioBtn.Location = new System.Drawing.Point(166, 24);
            this.blurRadioBtn.Name = "blurRadioBtn";
            this.blurRadioBtn.Size = new System.Drawing.Size(71, 16);
            this.blurRadioBtn.TabIndex = 0;
            this.blurRadioBtn.Text = "均值滤波";
            this.blurRadioBtn.UseVisualStyleBackColor = true;
            this.blurRadioBtn.CheckedChanged += new System.EventHandler(this.blurRadioBtn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Location = new System.Drawing.Point(311, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 61);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "阈值化";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(311, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 60);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "边缘检测";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 29);
            this.button2.TabIndex = 6;
            this.button2.TabStop = false;
            this.button2.Text = "Sobel边缘检测";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "Canny边缘检测";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button16);
            this.groupBox5.Controls.Add(this.button13);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(311, 173);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 92);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "轮廓提取";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(168, 55);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(79, 29);
            this.button16.TabIndex = 11;
            this.button16.TabStop = false;
            this.button16.Text = "质心计算";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(8, 55);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(86, 29);
            this.button13.TabIndex = 10;
            this.button13.TabStop = false;
            this.button13.Text = "最小外接矩形";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(168, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 29);
            this.button5.TabIndex = 9;
            this.button5.TabStop = false;
            this.button5.Text = "保存轮廓";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(87, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 29);
            this.button4.TabIndex = 8;
            this.button4.TabStop = false;
            this.button4.Text = "绘制轮廓";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 29);
            this.button3.TabIndex = 7;
            this.button3.TabStop = false;
            this.button3.Text = "发现轮廓";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.trackBar3);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.trackBar2);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.trackBar1);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(25, 225);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(263, 186);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "颜色追踪";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(65, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 29);
            this.button6.TabIndex = 12;
            this.button6.TabStop = false;
            this.button6.Text = "Track";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "255";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(65, 101);
            this.trackBar3.Maximum = 180;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(154, 45);
            this.trackBar3.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(32, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(21, 21);
            this.textBox3.TabIndex = 9;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "V:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "255";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(65, 64);
            this.trackBar2.Maximum = 180;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(154, 45);
            this.trackBar2.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(21, 21);
            this.textBox2.TabIndex = 5;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "S:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(21, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "180";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(65, 20);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(154, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "H:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button18);
            this.groupBox7.Controls.Add(this.button17);
            this.groupBox7.Controls.Add(this.button10);
            this.groupBox7.Controls.Add(this.button9);
            this.groupBox7.Controls.Add(this.button7);
            this.groupBox7.Location = new System.Drawing.Point(25, 118);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(263, 96);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "特征点提取";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(184, 55);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(70, 29);
            this.button18.TabIndex = 16;
            this.button18.TabStop = false;
            this.button18.Text = "保存角点";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(100, 55);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(78, 29);
            this.button17.TabIndex = 15;
            this.button17.TabStop = false;
            this.button17.Text = "SURF特征点";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 55);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(88, 29);
            this.button10.TabIndex = 14;
            this.button10.TabStop = false;
            this.button10.Text = "SIFT特征点";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(100, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 29);
            this.button9.TabIndex = 13;
            this.button9.TabStop = false;
            this.button9.Text = "Shi-Tomasi角点";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 20);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 29);
            this.button7.TabIndex = 12;
            this.button7.TabStop = false;
            this.button7.Text = "Harris角点";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Location = new System.Drawing.Point(310, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 52);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "功能键";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button8.Location = new System.Drawing.Point(159, 17);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 29);
            this.button8.TabIndex = 12;
            this.button8.TabStop = false;
            this.button8.Text = "Pause";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button21);
            this.groupBox8.Controls.Add(this.button20);
            this.groupBox8.Controls.Add(this.button19);
            this.groupBox8.Controls.Add(this.button11);
            this.groupBox8.Location = new System.Drawing.Point(312, 270);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(255, 87);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "图像分割";
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button21.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button21.Location = new System.Drawing.Point(7, 21);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(70, 29);
            this.button21.TabIndex = 15;
            this.button21.TabStop = false;
            this.button21.Text = "Pause";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button20.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button20.Location = new System.Drawing.Point(7, 54);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(70, 29);
            this.button20.TabIndex = 14;
            this.button20.TabStop = false;
            this.button20.Text = "WaterShed";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button19.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button19.Location = new System.Drawing.Point(175, 20);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(70, 29);
            this.button19.TabIndex = 13;
            this.button19.TabStop = false;
            this.button19.Text = "FloodFill";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button11.Location = new System.Drawing.Point(99, 21);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(62, 29);
            this.button11.TabIndex = 12;
            this.button11.TabStop = false;
            this.button11.Text = "GrabCut";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // ImageProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 423);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageProcess";
            this.Text = "图像处理";
            this.Load += new System.EventHandler(this.ImageProcess_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton gaussianBlurRadioBtn;
        private System.Windows.Forms.RadioButton medianBlurRadioBtn;
        private System.Windows.Forms.RadioButton blurRadioBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.RadioButton noblurRadioBtn;
    }
}