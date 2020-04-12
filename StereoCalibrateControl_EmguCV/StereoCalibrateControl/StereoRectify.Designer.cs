namespace StereoCalibrateControl
{
    partial class StereoRectify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StereoRectify));
            this.imagecap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createFile = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDeleteLast = new System.Windows.Forms.Button();
            this.imgnum1 = new System.Windows.Forms.Label();
            this.btnSavedata = new System.Windows.Forms.Button();
            this.btnEst = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calRectifymapBtn = new System.Windows.Forms.Button();
            this.bogutBtn = new System.Windows.Forms.Button();
            this.showRectifyImgBtn = new System.Windows.Forms.Button();
            this.stereoCalQuanlityBtn = new System.Windows.Forms.Button();
            this.btnSaveData2 = new System.Windows.Forms.Button();
            this.stereoCalbtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.imgnum2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.btnTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagecap
            // 
            this.imagecap.Location = new System.Drawing.Point(6, 31);
            this.imagecap.Name = "imagecap";
            this.imagecap.Size = new System.Drawing.Size(97, 31);
            this.imagecap.TabIndex = 8;
            this.imagecap.TabStop = false;
            this.imagecap.Text = "采集图片";
            this.imagecap.UseVisualStyleBackColor = true;
            this.imagecap.Click += new System.EventHandler(this.imagecap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createFile);
            this.groupBox1.Controls.Add(this.btnDeleteAll);
            this.groupBox1.Controls.Add(this.btnDeleteLast);
            this.groupBox1.Controls.Add(this.imgnum1);
            this.groupBox1.Controls.Add(this.btnSavedata);
            this.groupBox1.Controls.Add(this.btnEst);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCal);
            this.groupBox1.Controls.Add(this.imagecap);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "相机内参标定";
            // 
            // createFile
            // 
            this.createFile.Location = new System.Drawing.Point(6, 68);
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(97, 31);
            this.createFile.TabIndex = 19;
            this.createFile.TabStop = false;
            this.createFile.Text = "创建文件";
            this.createFile.UseVisualStyleBackColor = true;
            this.createFile.Click += new System.EventHandler(this.createFile_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(212, 31);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(97, 31);
            this.btnDeleteAll.TabIndex = 18;
            this.btnDeleteAll.TabStop = false;
            this.btnDeleteAll.Text = "删除所有";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDeleteLast
            // 
            this.btnDeleteLast.Location = new System.Drawing.Point(109, 31);
            this.btnDeleteLast.Name = "btnDeleteLast";
            this.btnDeleteLast.Size = new System.Drawing.Size(97, 31);
            this.btnDeleteLast.TabIndex = 17;
            this.btnDeleteLast.TabStop = false;
            this.btnDeleteLast.Text = "删除图片";
            this.btnDeleteLast.UseVisualStyleBackColor = true;
            this.btnDeleteLast.Click += new System.EventHandler(this.btnDeleteLast_Click);
            // 
            // imgnum1
            // 
            this.imgnum1.AutoSize = true;
            this.imgnum1.Location = new System.Drawing.Point(375, 40);
            this.imgnum1.Name = "imgnum1";
            this.imgnum1.Size = new System.Drawing.Size(11, 12);
            this.imgnum1.TabIndex = 16;
            this.imgnum1.Text = "0";
            // 
            // btnSavedata
            // 
            this.btnSavedata.Location = new System.Drawing.Point(315, 68);
            this.btnSavedata.Name = "btnSavedata";
            this.btnSavedata.Size = new System.Drawing.Size(97, 31);
            this.btnSavedata.TabIndex = 11;
            this.btnSavedata.TabStop = false;
            this.btnSavedata.Text = "保存数据";
            this.btnSavedata.UseVisualStyleBackColor = true;
            this.btnSavedata.Click += new System.EventHandler(this.btnSavedata_Click);
            // 
            // btnEst
            // 
            this.btnEst.Location = new System.Drawing.Point(212, 68);
            this.btnEst.Name = "btnEst";
            this.btnEst.Size = new System.Drawing.Size(97, 31);
            this.btnEst.TabIndex = 10;
            this.btnEst.TabStop = false;
            this.btnEst.Text = "标定结果评价";
            this.btnEst.UseVisualStyleBackColor = true;
            this.btnEst.Click += new System.EventHandler(this.btnEst_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "NUM: ";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(109, 68);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(97, 31);
            this.btnCal.TabIndex = 9;
            this.btnCal.TabStop = false;
            this.btnCal.Text = "标定计算";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.calRectifymapBtn);
            this.groupBox2.Controls.Add(this.bogutBtn);
            this.groupBox2.Controls.Add(this.showRectifyImgBtn);
            this.groupBox2.Controls.Add(this.stereoCalQuanlityBtn);
            this.groupBox2.Controls.Add(this.btnSaveData2);
            this.groupBox2.Controls.Add(this.stereoCalbtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "立体标定";
            // 
            // calRectifymapBtn
            // 
            this.calRectifymapBtn.Location = new System.Drawing.Point(212, 20);
            this.calRectifymapBtn.Name = "calRectifymapBtn";
            this.calRectifymapBtn.Size = new System.Drawing.Size(97, 31);
            this.calRectifymapBtn.TabIndex = 17;
            this.calRectifymapBtn.TabStop = false;
            this.calRectifymapBtn.Text = "校正映射";
            this.calRectifymapBtn.UseVisualStyleBackColor = true;
            this.calRectifymapBtn.Click += new System.EventHandler(this.calRectifymapBtn_Click);
            // 
            // bogutBtn
            // 
            this.bogutBtn.Location = new System.Drawing.Point(109, 20);
            this.bogutBtn.Name = "bogutBtn";
            this.bogutBtn.Size = new System.Drawing.Size(97, 31);
            this.bogutBtn.TabIndex = 14;
            this.bogutBtn.TabStop = false;
            this.bogutBtn.Text = "Bougut立体校正";
            this.bogutBtn.UseVisualStyleBackColor = true;
            this.bogutBtn.Click += new System.EventHandler(this.bogutBtn_Click);
            // 
            // showRectifyImgBtn
            // 
            this.showRectifyImgBtn.Location = new System.Drawing.Point(109, 57);
            this.showRectifyImgBtn.Name = "showRectifyImgBtn";
            this.showRectifyImgBtn.Size = new System.Drawing.Size(130, 31);
            this.showRectifyImgBtn.TabIndex = 16;
            this.showRectifyImgBtn.TabStop = false;
            this.showRectifyImgBtn.Text = "显示共面行对准图像";
            this.showRectifyImgBtn.UseVisualStyleBackColor = true;
            this.showRectifyImgBtn.Click += new System.EventHandler(this.showRectifyImgBtn_Click);
            // 
            // stereoCalQuanlityBtn
            // 
            this.stereoCalQuanlityBtn.Location = new System.Drawing.Point(315, 20);
            this.stereoCalQuanlityBtn.Name = "stereoCalQuanlityBtn";
            this.stereoCalQuanlityBtn.Size = new System.Drawing.Size(97, 31);
            this.stereoCalQuanlityBtn.TabIndex = 13;
            this.stereoCalQuanlityBtn.TabStop = false;
            this.stereoCalQuanlityBtn.Text = "标定结果评价";
            this.stereoCalQuanlityBtn.UseVisualStyleBackColor = true;
            this.stereoCalQuanlityBtn.Click += new System.EventHandler(this.stereoCalQuanlityBtn_Click);
            // 
            // btnSaveData2
            // 
            this.btnSaveData2.Location = new System.Drawing.Point(6, 57);
            this.btnSaveData2.Name = "btnSaveData2";
            this.btnSaveData2.Size = new System.Drawing.Size(97, 31);
            this.btnSaveData2.TabIndex = 12;
            this.btnSaveData2.TabStop = false;
            this.btnSaveData2.Text = "保存数据";
            this.btnSaveData2.UseVisualStyleBackColor = true;
            this.btnSaveData2.Click += new System.EventHandler(this.btnSaveData2_Click);
            // 
            // stereoCalbtn
            // 
            this.stereoCalbtn.Location = new System.Drawing.Point(6, 20);
            this.stereoCalbtn.Name = "stereoCalbtn";
            this.stereoCalbtn.Size = new System.Drawing.Size(97, 31);
            this.stereoCalbtn.TabIndex = 12;
            this.stereoCalbtn.TabStop = false;
            this.stereoCalbtn.Text = "立体标定计算";
            this.stereoCalbtn.UseVisualStyleBackColor = true;
            this.stereoCalbtn.Click += new System.EventHandler(this.stereoCalbtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button17);
            this.groupBox3.Controls.Add(this.button16);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.imgnum2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Location = new System.Drawing.Point(12, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 98);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "手眼标定";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(212, 20);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(97, 31);
            this.button17.TabIndex = 19;
            this.button17.TabStop = false;
            this.button17.Text = "删除所有";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(109, 20);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(97, 31);
            this.button16.TabIndex = 18;
            this.button16.TabStop = false;
            this.button16.Text = "删除上一幅图片";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(109, 57);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(97, 31);
            this.button10.TabIndex = 12;
            this.button10.TabStop = false;
            this.button10.Text = "显示并保存数据";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 57);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 31);
            this.button9.TabIndex = 12;
            this.button9.TabStop = false;
            this.button9.Text = "标定计算";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // imgnum2
            // 
            this.imgnum2.AutoSize = true;
            this.imgnum2.Location = new System.Drawing.Point(375, 29);
            this.imgnum2.Name = "imgnum2";
            this.imgnum2.Size = new System.Drawing.Size(11, 12);
            this.imgnum2.TabIndex = 14;
            this.imgnum2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "NUM: ";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 31);
            this.button8.TabIndex = 12;
            this.button8.TabStop = false;
            this.button8.Text = "采集图片";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 64);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "标定板参数设置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "写入";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(269, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 21);
            this.textBox3.TabIndex = 5;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 21);
            this.textBox2.TabIndex = 4;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width:";
            // 
            // StereoRectify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 420);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StereoRectify";
            this.Text = "立体视觉标定";
            this.Load += new System.EventHandler(this.StereoRectify_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button imagecap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSavedata;
        private System.Windows.Forms.Button btnEst;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveData2;
        private System.Windows.Forms.Button stereoCalbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label imgnum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button showRectifyImgBtn;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDeleteLast;
        private System.Windows.Forms.Label imgnum1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.ToolTip btnTip;
        private System.Windows.Forms.Button createFile;
        private System.Windows.Forms.Button stereoCalQuanlityBtn;
        private System.Windows.Forms.Button bogutBtn;
        private System.Windows.Forms.Button calRectifymapBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}