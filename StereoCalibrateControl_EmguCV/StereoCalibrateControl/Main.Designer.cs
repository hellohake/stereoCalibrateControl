namespace StereoCalibrateControl
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.main_skinEngine = new Sunisoft.IrisSkin.SkinEngine();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.compositeImage = new Emgu.CV.UI.ImageBox();
            this.图像处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.立体视觉标定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三维测量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBB机器人运动控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.leftImage = new Emgu.CV.UI.ImageBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rightImage = new Emgu.CV.UI.ImageBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compositeImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_skinEngine
            // 
            this.main_skinEngine.@__DrawButtonFocusRectangle = true;
            this.main_skinEngine.Active = false;
            this.main_skinEngine.DefaultButtonStyle = Sunisoft.IrisSkin.DefaultButtonStyle.FocusRectangle;
            this.main_skinEngine.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.main_skinEngine.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.main_skinEngine.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.main_skinEngine.SerialNumber = "";
            this.main_skinEngine.SkinFile = null;
            this.main_skinEngine.SkinFormOnly = true;
            this.main_skinEngine.SkinScrollBar = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.compositeImage);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(686, 268);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Composite Image";
            // 
            // compositeImage
            // 
            this.compositeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compositeImage.Location = new System.Drawing.Point(10, 18);
            this.compositeImage.Name = "compositeImage";
            this.compositeImage.Size = new System.Drawing.Size(640, 240);
            this.compositeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.compositeImage.TabIndex = 2;
            this.compositeImage.TabStop = false;
            // 
            // 图像处理ToolStripMenuItem
            // 
            this.图像处理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.图像处理ToolStripMenuItem.ForeColor = System.Drawing.Color.LightCoral;
            this.图像处理ToolStripMenuItem.Name = "图像处理ToolStripMenuItem";
            this.图像处理ToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.图像处理ToolStripMenuItem.Text = "图像处理";
            this.图像处理ToolStripMenuItem.Click += new System.EventHandler(this.图像处理ToolStripMenuItem_Click);
            // 
            // 立体视觉标定ToolStripMenuItem
            // 
            this.立体视觉标定ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.立体视觉标定ToolStripMenuItem.ForeColor = System.Drawing.Color.LightCoral;
            this.立体视觉标定ToolStripMenuItem.Name = "立体视觉标定ToolStripMenuItem";
            this.立体视觉标定ToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.立体视觉标定ToolStripMenuItem.Text = "立体视觉标定";
            this.立体视觉标定ToolStripMenuItem.Click += new System.EventHandler(this.立体视觉标定ToolStripMenuItem_Click);
            // 
            // 三维测量ToolStripMenuItem
            // 
            this.三维测量ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.三维测量ToolStripMenuItem.ForeColor = System.Drawing.Color.LightCoral;
            this.三维测量ToolStripMenuItem.Name = "三维测量ToolStripMenuItem";
            this.三维测量ToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.三维测量ToolStripMenuItem.Text = "三维测量";
            this.三维测量ToolStripMenuItem.Click += new System.EventHandler(this.三维测量ToolStripMenuItem_Click);
            // 
            // aBB机器人运动控制ToolStripMenuItem
            // 
            this.aBB机器人运动控制ToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBB机器人运动控制ToolStripMenuItem.ForeColor = System.Drawing.Color.LightCoral;
            this.aBB机器人运动控制ToolStripMenuItem.Name = "aBB机器人运动控制ToolStripMenuItem";
            this.aBB机器人运动控制ToolStripMenuItem.Size = new System.Drawing.Size(153, 23);
            this.aBB机器人运动控制ToolStripMenuItem.Text = "ABB机器人运动控制";
            this.aBB机器人运动控制ToolStripMenuItem.Click += new System.EventHandler(this.aBB机器人运动控制ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图像处理ToolStripMenuItem,
            this.立体视觉标定ToolStripMenuItem,
            this.三维测量ToolStripMenuItem,
            this.aBB机器人运动控制ToolStripMenuItem,
            this.openCameraToolStripMenuItem,
            this.closeCameraToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.logToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 27);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openCameraToolStripMenuItem
            // 
            this.openCameraToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCameraToolStripMenuItem.Name = "openCameraToolStripMenuItem";
            this.openCameraToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.openCameraToolStripMenuItem.Text = "Open Camera";
            this.openCameraToolStripMenuItem.Click += new System.EventHandler(this.openCameraToolStripMenuItem_Click);
            // 
            // closeCameraToolStripMenuItem
            // 
            this.closeCameraToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeCameraToolStripMenuItem.Name = "closeCameraToolStripMenuItem";
            this.closeCameraToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.closeCameraToolStripMenuItem.Text = "Close Camera";
            this.closeCameraToolStripMenuItem.Click += new System.EventHandler(this.closeCameraToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.leftImage);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 270);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Left Camera";
            // 
            // leftImage
            // 
            this.leftImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftImage.Location = new System.Drawing.Point(10, 18);
            this.leftImage.Name = "leftImage";
            this.leftImage.Size = new System.Drawing.Size(320, 240);
            this.leftImage.TabIndex = 2;
            this.leftImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rightImage);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(358, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 270);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Right Camera";
            // 
            // rightImage
            // 
            this.rightImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightImage.Location = new System.Drawing.Point(10, 18);
            this.rightImage.Name = "rightImage";
            this.rightImage.Size = new System.Drawing.Size(320, 240);
            this.rightImage.TabIndex = 2;
            this.rightImage.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(712, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "Version1.0.0";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(42, 23);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel2.Text = "就绪...";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(712, 607);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RobotVisionControl";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compositeImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine main_skinEngine;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem 图像处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 立体视觉标定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三维测量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBB机器人运动控制ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem openCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCameraToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private Emgu.CV.UI.ImageBox compositeImage;
        private Emgu.CV.UI.ImageBox leftImage;
        private Emgu.CV.UI.ImageBox rightImage;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

