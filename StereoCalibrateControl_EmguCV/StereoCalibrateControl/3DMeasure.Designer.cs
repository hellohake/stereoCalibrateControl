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
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p4textBox = new System.Windows.Forms.TextBox();
            this.p3textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p2textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.p1textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calCornersBtn = new System.Windows.Forms.Button();
            this.drawContoursBtn = new System.Windows.Forms.Button();
            this.sgbmBtn = new System.Windows.Forms.Button();
            this.bmBtn = new System.Windows.Forms.Button();
            this._3DcalBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.closeBtn);
            this.groupBox5.Controls.Add(this.pauseBtn);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Controls.Add(this.calCornersBtn);
            this.groupBox5.Controls.Add(this.drawContoursBtn);
            this.groupBox5.Controls.Add(this.sgbmBtn);
            this.groupBox5.Controls.Add(this.bmBtn);
            this.groupBox5.Controls.Add(this._3DcalBtn);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Location = new System.Drawing.Point(12, 288);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(672, 194);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "立体视觉测量";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(361, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 35;
            this.button2.TabStop = false;
            this.button2.Text = "选择已有图片计算工件坐标";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(462, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 109);
            this.panel2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(64, 21);
            this.textBox1.TabIndex = 18;
            this.textBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(64, 21);
            this.textBox2.TabIndex = 17;
            this.textBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(102, 75);
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
            this.label7.Location = new System.Drawing.Point(4, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "P3：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(64, 21);
            this.textBox3.TabIndex = 10;
            this.textBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(102, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "P2：";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(32, 35);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(64, 21);
            this.textBox8.TabIndex = 8;
            this.textBox8.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(4, 39);
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
            this.label10.Location = new System.Drawing.Point(4, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "工件角点的三维坐标：";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button4.Location = new System.Drawing.Point(6, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 28);
            this.button4.TabIndex = 34;
            this.button4.TabStop = false;
            this.button4.Text = "保存三维坐标";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.closeBtn.Location = new System.Drawing.Point(561, 20);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(58, 28);
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
            this.pauseBtn.Location = new System.Drawing.Point(480, 20);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(73, 28);
            this.pauseBtn.TabIndex = 32;
            this.pauseBtn.TabStop = false;
            this.pauseBtn.Text = "暂停";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(6, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 31;
            this.button1.TabStop = false;
            this.button1.Text = "捕获当前图像";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.p4textBox);
            this.panel1.Controls.Add(this.p3textBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.p2textBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.p1textBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(118, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 110);
            this.panel1.TabIndex = 29;
            // 
            // p4textBox
            // 
            this.p4textBox.Location = new System.Drawing.Point(130, 71);
            this.p4textBox.Name = "p4textBox";
            this.p4textBox.ReadOnly = true;
            this.p4textBox.Size = new System.Drawing.Size(64, 21);
            this.p4textBox.TabIndex = 18;
            this.p4textBox.TabStop = false;
            // 
            // p3textBox
            // 
            this.p3textBox.Location = new System.Drawing.Point(32, 71);
            this.p3textBox.Name = "p3textBox";
            this.p3textBox.ReadOnly = true;
            this.p3textBox.Size = new System.Drawing.Size(64, 21);
            this.p3textBox.TabIndex = 17;
            this.p3textBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(102, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "P4：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(4, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "P3：";
            // 
            // p2textBox
            // 
            this.p2textBox.Location = new System.Drawing.Point(130, 35);
            this.p2textBox.Name = "p2textBox";
            this.p2textBox.ReadOnly = true;
            this.p2textBox.Size = new System.Drawing.Size(64, 21);
            this.p2textBox.TabIndex = 10;
            this.p2textBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(102, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "P2：";
            // 
            // p1textBox
            // 
            this.p1textBox.Location = new System.Drawing.Point(32, 35);
            this.p1textBox.Name = "p1textBox";
            this.p1textBox.ReadOnly = true;
            this.p1textBox.Size = new System.Drawing.Size(64, 21);
            this.p1textBox.TabIndex = 8;
            this.p1textBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "P1：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "实时角点三维坐标：";
            // 
            // calCornersBtn
            // 
            this.calCornersBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calCornersBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.calCornersBtn.Location = new System.Drawing.Point(361, 20);
            this.calCornersBtn.Name = "calCornersBtn";
            this.calCornersBtn.Size = new System.Drawing.Size(106, 28);
            this.calCornersBtn.TabIndex = 28;
            this.calCornersBtn.TabStop = false;
            this.calCornersBtn.Text = "计算显示角点";
            this.calCornersBtn.UseVisualStyleBackColor = true;
            this.calCornersBtn.Click += new System.EventHandler(this.calCornersBtn_Click);
            // 
            // drawContoursBtn
            // 
            this.drawContoursBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drawContoursBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.drawContoursBtn.Location = new System.Drawing.Point(249, 20);
            this.drawContoursBtn.Name = "drawContoursBtn";
            this.drawContoursBtn.Size = new System.Drawing.Size(106, 28);
            this.drawContoursBtn.TabIndex = 27;
            this.drawContoursBtn.TabStop = false;
            this.drawContoursBtn.Text = "计算显示轮廓";
            this.drawContoursBtn.UseVisualStyleBackColor = true;
            this.drawContoursBtn.Click += new System.EventHandler(this.drawContoursBtn_Click);
            // 
            // sgbmBtn
            // 
            this.sgbmBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sgbmBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sgbmBtn.Location = new System.Drawing.Point(118, 20);
            this.sgbmBtn.Name = "sgbmBtn";
            this.sgbmBtn.Size = new System.Drawing.Size(106, 28);
            this.sgbmBtn.TabIndex = 25;
            this.sgbmBtn.TabStop = false;
            this.sgbmBtn.Text = "SGBM算法视差图";
            this.sgbmBtn.UseVisualStyleBackColor = true;
            this.sgbmBtn.Click += new System.EventHandler(this.sgbmBtn_Click);
            // 
            // bmBtn
            // 
            this.bmBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bmBtn.Location = new System.Drawing.Point(6, 20);
            this.bmBtn.Name = "bmBtn";
            this.bmBtn.Size = new System.Drawing.Size(106, 28);
            this.bmBtn.TabIndex = 24;
            this.bmBtn.TabStop = false;
            this.bmBtn.Text = "BM算法视差图";
            this.bmBtn.UseVisualStyleBackColor = true;
            this.bmBtn.Click += new System.EventHandler(this.bmBtn_Click);
            // 
            // _3DcalBtn
            // 
            this._3DcalBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._3DcalBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this._3DcalBtn.Location = new System.Drawing.Point(6, 102);
            this._3DcalBtn.Name = "_3DcalBtn";
            this._3DcalBtn.Size = new System.Drawing.Size(106, 28);
            this._3DcalBtn.TabIndex = 5;
            this._3DcalBtn.TabStop = false;
            this._3DcalBtn.Text = "计算三维坐标";
            this._3DcalBtn.UseVisualStyleBackColor = true;
            this._3DcalBtn.Click += new System.EventHandler(this._3DcalBtn_Click);
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
            this.imageBox1.Location = new System.Drawing.Point(6, 20);
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
            this.imageBox2.Location = new System.Drawing.Point(6, 20);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(320, 240);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // _3DMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 492);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button _3DcalBtn;
        private System.Windows.Forms.TextBox p4textBox;
        private System.Windows.Forms.TextBox p3textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox p2textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox p1textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sgbmBtn;
        private System.Windows.Forms.Button bmBtn;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button calCornersBtn;
        private System.Windows.Forms.Button drawContoursBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
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
    }
}