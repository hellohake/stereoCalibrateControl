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
    public partial class RectifyImage : Form
    {
        //定义变量
        public System.Threading.Timer Imgtimer;
        public Mat leftsrc = new Mat();
        public Mat rightsrc = new Mat();
        public Mat leftpart;
        public Mat rightpart;
        public static Mat dst = new Mat(240, 640, DepthType.Cv8U, 3);           //注意尺寸 


        public RectifyImage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化相关参数
        /// </summary>
        private void RectifyImage_Load(object sender, EventArgs e)
        {
            Imgtimer = new System.Threading.Timer(ImgTimerCallBack, this, 0, 55);  //创建并启动定时器
        }
        /// <summary>
        /// 定时器函数
        private void ImgTimerCallBack(object state)
        {
            try
            {
                dst.SetTo(new MCvScalar(0, 0, 0));
                //获取原图像
                this.leftsrc = Data.leftImg;
                this.rightsrc = Data.rightImg;
                //设置ROI
                leftpart = new Mat(dst, new Rectangle(0, 0, 320, 240));
                rightpart = new Mat(dst, new Rectangle(320, 0, 320, 240));
                //重映射
                CvInvoke.Remap(leftsrc, leftsrc, Data.leftMap1, Data.leftMap2, Inter.Linear);
                CvInvoke.Remap(rightsrc, rightsrc, Data.rightMap1, Data.rightMap2, Inter.Linear);
                //Resize
                CvInvoke.Resize(leftsrc, leftpart, leftpart.Size, 0, 0, Inter.Linear);
                CvInvoke.Resize(rightsrc, rightpart, rightpart.Size, 0, 0, Inter.Linear);
                //绘制扫描线
                for (int i = 20; i < dst.Rows; i += 20)
                {
                    CvInvoke.Line(dst, new Point(0, i), new Point(dst.Cols, i), new MCvScalar(0, 255, 0), 1);
                }
                //显示矫正图
                this.imageBox1.Image = dst;
                //CvInvoke.WaitKey(10);
            }
            catch (Exception ex)
            {
                Data.LogString = ex.Message;
            }
            
        }
        /// <summary>
        /// 启动定时器显示图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBtn_Click(object sender, EventArgs e)
        {
            Imgtimer.Change(0, 50);
        }
        /// <summary>
        /// 暂停显示图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopBtn_Click(object sender, EventArgs e)
        {
            Imgtimer.Change(-1, 50);//暂停定时器
        }
        /// <summary>
        /// 关闭图像显示
        /// </summary>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Imgtimer.Change(-1, 50);        //暂停定时器
            this.imageBox1.Image = null;    //清除图像
        }
    }
}
