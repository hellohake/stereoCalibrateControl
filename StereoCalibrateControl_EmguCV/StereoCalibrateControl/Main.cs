using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using System.Threading;

namespace StereoCalibrateControl
{
    public partial class Main : Form
    {
        //定义全部变量
        private static int CAMERA_ID = 0;
        private System.Threading.Timer camTim;
        private VideoCapture cap = new VideoCapture(CAMERA_ID);   //必须在这里初始化
        private Image<Bgr, Byte> frame;
        private Mat resizeImg = new Mat();
        private Mat leftImg;
        private Mat rightImg;
        //定义标志位
        private bool CAMERA_OPEN  = false;

        //定义各个窗体变量        
        private Log logForm;
        private ImageProcess imgProForm;
        private StereoRectify srForm;
        private _3DMeasure _3DForm;
        private ABBControl abbForm;
        public Main()
        {
            InitializeComponent();
            this.main_skinEngine.SkinFile = "Calmness.ssk";   //加载一个背景            
        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Alignment = ToolStripItemAlignment.Right;
            this.cap.Stop();            
        }
        /// <summary>
        /// 使用线程定时器
        /// </summary>
        public void CamTim(object state)
        {
            frame = cap.QueryFrame().ToImage<Bgr, Byte>();
            if(frame == null)
            {
                return;
            }
            if(CAMERA_OPEN)         //相机打开
            {
                //图像预处理
                if (Data.BLUR_FLAG)
                {
                    CvInvoke.Blur(frame, frame, new Size(3, 3), new Point(-1, -1));
                }
                else if (Data.GAUSSIANBLUR_FLAG)
                {
                    CvInvoke.GaussianBlur(frame, frame, new Size(3, 3), 0, 0);
                }
                else if (Data.MEDIANBLUR_FLAG)
                {
                    CvInvoke.MedianBlur(frame, frame, 3);
                }
                else if(Data.NOBLUR_FLAG)
                {
                    //不处理
                }
                Data.compositeImg = frame.Mat;          //存储信息
                CvInvoke.Resize(frame, resizeImg, new Size(640, 240), 0, 0, Inter.Area);
                this.compositeImage.Image = resizeImg;
                leftImg = new Mat(resizeImg, new Rectangle(0, 0, 320, 240));
                this.leftImage.Image = leftImg;
                Data.leftImg = leftImg;
                rightImg = new Mat(resizeImg, new Rectangle(320, 0, 320, 240));
                this.rightImage.Image = rightImg;
                Data.rightImg = rightImg;
            }
        }
        /// <summary>
        /// 打开摄像头
        /// </summary>
        private void openCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAMERA_OPEN  = true;
            Data.CAMERA_OPEN = true;
            Data.LogString = "camera open...";
            camTim = new System.Threading.Timer(CamTim, this, 0, 50);  //启用定时器
        }        
        /// <summary>
        /// 关闭摄像头
        /// </summary>       
        private void closeCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.compositeImage.Image = null;
            this.rightImage.Image = null;
            this.leftImage.Image = null;
            CAMERA_OPEN = false;
            Data.CAMERA_OPEN = false;
            Data.LogString = "camera close...";
            cap.Stop();                 //停止抓图线程                
            camTim.Change(-1, 50);      //停止定时器            
        }
        /// <summary>
        /// 采集图像暂停
        /// </summary>       
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAMERA_OPEN = false;     
            Data.CAMERA_OPEN = false;
            Data.LogString = "camera capture pause...";
            cap.Pause();                //暂停抓图线程
            camTim.Change(-1, 50);      //停止定时器
        }
        /// <summary>
        /// 打开图像处理对话框
        /// </summary>        
        private void 图像处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开窗体
            Data.LogString = "Open ImageProcess Dialog...";
            imgProForm = GenericSingleleton<ImageProcess>.CreateInstance();
            imgProForm.Show();
        }
        /// <summary>
        /// 打开立体视觉标定对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 立体视觉标定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开窗体
            Data.LogString = "Open StereoRectify Dialog...";
            srForm = GenericSingleleton<StereoRectify>.CreateInstance();
            srForm.Show();
        }
        /// <summary>
        /// 打开三维测量对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 三维测量ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Data.LogString = "Open 3D measure Dialog...";
            _3DForm = GenericSingleleton<_3DMeasure>.CreateInstance();
            _3DForm.Show();
        }
        /// <summary>
        /// 打开ABB机器人运动控制对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aBB机器人运动控制ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Data.LogString = "Open ABBRobotControl Dialog...";
            abbForm = GenericSingleleton<ABBControl>.CreateInstance();
            abbForm.Show();
        }
        /// <summary>
        /// 打开 日志窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.LogString = "Open LogView Dialog...";
            logForm = GenericSingleleton<Log>.CreateInstance();
            logForm.Show();
        }
    }
}
