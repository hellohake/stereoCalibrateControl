namespace StereoCalibrateControl
{
    partial class _3DMeasure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_3DMeasure));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.calBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.p4textBox = new System.Windows.Forms.TextBox();
            this.p3textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p2textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.p1textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sgbmBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.showCon_Btn = new System.Windows.Forms.Button();
            this.button_writeBM = new System.Windows.Forms.Button();
            this.textBox_BlockSize = new System.Windows.Forms.TextBox();
            this.textBox_NumOfDis = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.bmBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabControl1);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.showCon_Btn);
            this.groupBox5.Controls.Add(this.button_writeBM);
            this.groupBox5.Controls.Add(this.textBox_BlockSize);
            this.groupBox5.Controls.Add(this.textBox_NumOfDis);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.closeBtn);
            this.groupBox5.Controls.Add(this.pauseBtn);
            this.groupBox5.Controls.Add(this.bmBtn);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Location = new System.Drawing.Point(12, 288);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(686, 263);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "立体视觉测量";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 157);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.calBtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.p4textBox);
            this.tabPage1.Controls.Add(this.p3textBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.p2textBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.p1textBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 131);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "视觉动态测量";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // calBtn
            // 
            this.calBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.calBtn.Location = new System.Drawing.Point(451, 58);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(114, 23);
            this.calBtn.TabIndex = 27;
            this.calBtn.Text = "实时计算三维坐标";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "角点的实时三维坐标：";
            // 
            // p4textBox
            // 
            this.p4textBox.Location = new System.Drawing.Point(113, 104);
            this.p4textBox.Name = "p4textBox";
            this.p4textBox.ReadOnly = true;
            this.p4textBox.Size = new System.Drawing.Size(230, 21);
            this.p4textBox.TabIndex = 26;
            this.p4textBox.TabStop = false;
            // 
            // p3textBox
            // 
            this.p3textBox.Location = new System.Drawing.Point(113, 79);
            this.p3textBox.Name = "p3textBox";
            this.p3textBox.ReadOnly = true;
            this.p3textBox.Size = new System.Drawing.Size(230, 21);
            this.p3textBox.TabIndex = 25;
            this.p3textBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(85, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "P4：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(84, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "P3：";
            // 
            // p2textBox
            // 
            this.p2textBox.Location = new System.Drawing.Point(113, 54);
            this.p2textBox.Name = "p2textBox";
            this.p2textBox.ReadOnly = true;
            this.p2textBox.Size = new System.Drawing.Size(230, 21);
            this.p2textBox.TabIndex = 22;
            this.p2textBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(85, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "P2：";
            // 
            // p1textBox
            // 
            this.p1textBox.Location = new System.Drawing.Point(113, 29);
            this.p1textBox.Name = "p1textBox";
            this.p1textBox.ReadOnly = true;
            this.p1textBox.Size = new System.Drawing.Size(230, 21);
            this.p1textBox.TabIndex = 20;
            this.p1textBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(85, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "P1：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.sgbmBtn);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(660, 131);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "视觉静态测量";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(344, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 28);
            this.button2.TabIndex = 36;
            this.button2.TabStop = false;
            this.button2.Text = "选择已有图片计算工件坐标";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(194, 21);
            this.textBox1.TabIndex = 18;
            this.textBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(194, 21);
            this.textBox2.TabIndex = 17;
            this.textBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(74, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "P4：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(74, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "P3：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(194, 21);
            this.textBox3.TabIndex = 10;
            this.textBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(74, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "P2：";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(106, 26);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(194, 21);
            this.textBox8.TabIndex = 8;
            this.textBox8.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(74, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "P1：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(15, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "工件角点的三维坐标：";
            // 
            // sgbmBtn
            // 
            this.sgbmBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sgbmBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sgbmBtn.Location = new System.Drawing.Point(344, 60);
            this.sgbmBtn.Name = "sgbmBtn";
            this.sgbmBtn.Size = new System.Drawing.Size(161, 28);
            this.sgbmBtn.TabIndex = 25;
            this.sgbmBtn.TabStop = false;
            this.sgbmBtn.Text = "显示SGBM视差图";
            this.sgbmBtn.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(14, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(659, 24);
            this.label12.TabIndex = 41;
            this.label12.Text = "NOTE: 实时坐标点的坐标系为当前摄像机坐标系，坐标点单位为像素(pixel)非毫米(mm)，根据摄像机坐标系与工件坐标系的\r\n四元数方向余弦矩阵与平移向量转换" +
    "可得到工件坐标系下的实时坐标";
            // 
            // showCon_Btn
            // 
            this.showCon_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showCon_Btn.Location = new System.Drawing.Point(494, 20);
            this.showCon_Btn.Name = "showCon_Btn";
            this.showCon_Btn.Size = new System.Drawing.Size(95, 26);
            this.showCon_Btn.TabIndex = 39;
            this.showCon_Btn.Text = "显示轮廓角点";
            this.showCon_Btn.UseVisualStyleBackColor = true;
            this.showCon_Btn.Click += new System.EventHandler(this.showCon_Btn_Click);
            // 
            // button_writeBM
            // 
            this.button_writeBM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_writeBM.Location = new System.Drawing.Point(263, 20);
            this.button_writeBM.Name = "button_writeBM";
            this.button_writeBM.Size = new System.Drawing.Size(49, 26);
            this.button_writeBM.TabIndex = 38;
            this.button_writeBM.Text = "写入";
            this.button_writeBM.UseVisualStyleBackColor = true;
            this.button_writeBM.Click += new System.EventHandler(this.button_writeBM_Click);
            // 
            // textBox_BlockSize
            // 
            this.textBox_BlockSize.Location = new System.Drawing.Point(220, 24);
            this.textBox_BlockSize.Name = "textBox_BlockSize";
            this.textBox_BlockSize.Size = new System.Drawing.Size(25, 21);
            this.textBox_BlockSize.TabIndex = 4;
            this.textBox_BlockSize.TabStop = false;
            this.textBox_BlockSize.Text = "19";
            // 
            // textBox_NumOfDis
            // 
            this.textBox_NumOfDis.Location = new System.Drawing.Point(113, 24);
            this.textBox_NumOfDis.Name = "textBox_NumOfDis";
            this.textBox_NumOfDis.Size = new System.Drawing.Size(25, 21);
            this.textBox_NumOfDis.TabIndex = 3;
            this.textBox_NumOfDis.TabStop = false;
            this.textBox_NumOfDis.Text = "64";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(147, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 37;
            this.label13.Text = "BlockSize:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "NumOfDisparities:";
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.closeBtn.Location = new System.Drawing.Point(637, 20);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(42, 26);
            this.closeBtn.TabIndex = 33;
            this.closeBtn.TabStop = false;
            this.closeBtn.Text = "关闭";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pauseBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pauseBtn.Location = new System.Drawing.Point(592, 20);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(42, 26);
            this.pauseBtn.TabIndex = 32;
            this.pauseBtn.TabStop = false;
            this.pauseBtn.Text = "暂停";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // bmBtn
            // 
            this.bmBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bmBtn.Location = new System.Drawing.Point(313, 20);
            this.bmBtn.Name = "bmBtn";
            this.bmBtn.Size = new System.Drawing.Size(72, 26);
            this.bmBtn.TabIndex = 24;
            this.bmBtn.TabStop = false;
            this.bmBtn.Text = "BM视差图";
            this.bmBtn.UseVisualStyleBackColor = true;
            this.bmBtn.Click += new System.EventHandler(this.bmBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 270);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disparity Image";
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(10, 20);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(320, 240);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imageBox2);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(358, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 270);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contours Image";
            // 
            // imageBox2
            // 
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(10, 20);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(320, 240);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(344, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 28);
            this.button1.TabIndex = 37;
            this.button1.TabStop = false;
            this.button1.Text = "显示工件角点坐标";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // _3DMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_3DMeasure";
            this.Text = "三维测量";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._3DMeasure_FormClosing);
            this.Load += new System.EventHandler(this._3DMeasure_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bmBtn;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button sgbmBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_BlockSize;
        private System.Windows.Forms.TextBox textBox_NumOfDis;
        private System.Windows.Forms.Button button_writeBM;
        private System.Windows.Forms.Button showCon_Btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox p4textBox;
        private System.Windows.Forms.TextBox p3textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox p2textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox p1textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Button button1;
    }
}