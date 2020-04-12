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
using Emgu.CV.Features2D;
using System.Threading;

//using OpenCvSharp;      //BM算法，SGBM算法使用OpenCVSharp实现


namespace StereoCalibrateControl
{
    public partial class _3DMeasure : Form
    {
        //定义变量
        //public OpenCvSharp.StereoBM bm;
        public StereoBM bm;
        public StereoSGBM sgbm;
        public Emgu.CV.Mat lsrc = new Emgu.CV.Mat();
        public Emgu.CV.Mat rsrc = new Emgu.CV.Mat();
        public Emgu.CV.Mat distImg = new Emgu.CV.Mat();
        public Emgu.CV.Mat distImg8U;
        //Contours
        public System.Threading.Timer contoursTimer;
        public Mat contoursImg = new Mat(240, 320, DepthType.Cv8U, 3);
        public Mat leftsrc = new Mat();
        public Mat grayImg = new Mat();
        public Mat cannyImg = new Mat();
        public VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
        public VectorOfRect hierarchy = new VectorOfRect();
        //Corners
        public System.Threading.Timer cornerCalTimer;
        public GFTTDetector gFTT;                       //Shi-Tomasi角点检测
        public Mat leftsrc2 = new Mat();
        public Mat grayImg2 = new Mat();
        public MKeyPoint[] cornerPoints;                //存储检测角点
        //Timer
        public System.Threading.Timer BMdispTimer;
        public System.Threading.Timer SGBMdispTimer;
        //计算顶点的三维坐标
        private bool CalCoordinate_Flag = false;
        private MCvPoint3D32f[] objXYZ = new MCvPoint3D32f[4];
        public _3DMeasure()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化相关参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _3DMeasure_Load(object sender, EventArgs e)
        {
            bm = new StereoBM(64, 15);
            sgbm = new StereoSGBM(0, 64, 15, 0, 0, 1, 60, 10,100,32);
            gFTT = new GFTTDetector(4, 0.01, 1, 3, false, 0.04);                  //初始化GFTT
            contoursImg.SetTo(new MCvScalar(0, 0, 0));                            //置0

            BMdispTimer = new System.Threading.Timer(BM_CAL, null, -1, 100);      //初始化BM定时器
            SGBMdispTimer = new System.Threading.Timer(SGBM_CAL, null, -1, 200);  //初始化SGBM定时器
            contoursTimer = new System.Threading.Timer(Calshow_Contours, null, -1, 100);
            cornerCalTimer = new System.Threading.Timer(Calshow_Corners, null, -1, 100);
        }        

        private void SGBM_CAL(object state)
        {
            lsrc = Data.leftImg;
            rsrc = Data.rightImg;
            //CvInvoke.CvtColor(lsrc, lsrc, ColorConversion.Bgr2Gray);
            //CvInvoke.CvtColor(rsrc, rsrc, ColorConversion.Bgr2Gray);
            sgbm.Compute(lsrc, rsrc, distImg);
            CvInvoke.Normalize(distImg, distImg8U, 0, 255, NormType.MinMax, DepthType.Cv8U);
            this.imageBox1.Image = distImg;
        }

        private void BM_CAL(object state)
        {
            //获取原图  全拷贝
            Data.leftImg.CopyTo(lsrc);
            Data.rightImg.CopyTo(rsrc);
            //转换为灰度图
            CvInvoke.CvtColor(lsrc, lsrc, ColorConversion.Bgr2Gray);
            CvInvoke.CvtColor(rsrc, rsrc, ColorConversion.Bgr2Gray);
            bm.Compute(lsrc, rsrc, distImg);    //BM算法只能处理灰度图
            distImg.ConvertTo(distImg, DepthType.Cv32F, 1.0 / 16); //除16得到真正的视差图
            distImg8U = new Mat(distImg.Size, DepthType.Cv8U, 1);
            CvInvoke.Normalize(distImg, distImg, 0, 255, NormType.MinMax, DepthType.Cv8U);
            this.imageBox1.Image = distImg;
        }

        /// <summary>
        /// BM算法
        /// </summary>        
        private void bmBtn_Click(object sender, EventArgs e)
        {
            SGBMdispTimer.Change(-1, 100); //关闭SGBM算法
            BMdispTimer.Change(0, 100);    //启动BM算法
        }        
        /// <summary>
        /// SGBM算法
        /// </summary>        
        private void sgbmBtn_Click(object sender, EventArgs e)
        {
            BMdispTimer.Change(-1, 100);    //关闭BM算法
            SGBMdispTimer.Change(0, 100);   //启动SGBM算法
        }
        /// <summary>
        /// 计算显示轮廓
        /// </summary>        
        private void drawContoursBtn_Click(object sender, EventArgs e)
        {
            contoursTimer.Change(0, 100);
        }
        private void Calshow_Contours(object state)
        {
            Data.leftImg.CopyTo(leftsrc);               //获取原图
            contoursImg.SetTo(new MCvScalar(0,0,0));  //清空图像
            CvInvoke.CvtColor(leftsrc, grayImg, ColorConversion.Bgr2Gray);
            CvInvoke.Canny(grayImg, cannyImg, 100, 200, 3); //计算得到二值图
            CvInvoke.FindContours(cannyImg, contours, hierarchy, RetrType.External, ChainApproxMethod.ChainApproxNone); //发现轮廓
            CvInvoke.DrawContours(contoursImg, contours, -1, new MCvScalar(255,255,255), 2);                            //以白色点绘制
            this.imageBox2.Image = contoursImg;                 //显示轮廓图
        }
        /// <summary>
        /// 计算角点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calCornersBtn_Click(object sender, EventArgs e)
        {
            cornerCalTimer.Change(0, 100);      //启动定时器进行计算
        }
        private void Calshow_Corners(object state)
        {
            Data.leftImg.CopyTo(leftsrc2);
            CvInvoke.CvtColor(leftsrc2, grayImg2, ColorConversion.Bgr2Gray);
            cornerPoints = gFTT.Detect(grayImg2);               //计算4个特征角点
            for(int i = 0; i < cornerPoints.Length; i++)
            {
                Point pt = new Point();
                pt.X = (int)cornerPoints[i].Point.X;
                pt.Y = (int)cornerPoints[i].Point.Y;
                CvInvoke.Circle(contoursImg, pt, 3, new MCvScalar(0, 0, 255), -1);      //绘制实心圆
            }
            this.imageBox2.Image = contoursImg;                 //显示角点图
            //计算角点反向投影
            if(CalCoordinate_Flag)
            {
                //for (int i = 0; i < cornerPoints.Length; i++)
                //{
                //    PointF pt = new PointF();
                //    pt.X = cornerPoints[i].Point.X;
                //    pt.Y = cornerPoints[i].Point.Y;
                //    CvInvoke.ReprojectImageTo3D(pt, objXYZ[i], Data.Q);
                //}
            }
           
        }

        /// <summary>
        /// 计算顶点的三维坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _3DcalBtn_Click(object sender, EventArgs e)
        {
            CalCoordinate_Flag = true;
        }
        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            BMdispTimer.Change(-1, 100);
            SGBMdispTimer.Change(-1, 100);
            contoursTimer.Change(-1, 100);
            cornerCalTimer.Change(-1, 100);

        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            BMdispTimer.Change(-1, 100);
            SGBMdispTimer.Change(-1, 100);
            contoursTimer.Change(-1, 100);
            cornerCalTimer.Change(-1, 100);
            this.imageBox1.Image = null;
            this.imageBox2.Image = null;
        }
        /// <summary>
        /// 窗体关闭时释放资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _3DMeasure_FormClosing(object sender, FormClosingEventArgs e)
        {
            BMdispTimer.Change(-1, 100);
            SGBMdispTimer.Change(-1, 100);
            contoursTimer.Change(-1, 100);
            cornerCalTimer.Change(-1, 100);
        }

    }
}

/*********bm参数配置***********/
//bm = OpenCvSharp.StereoBM.Create(64, 15); //最大视差(numDisparites) 64 ， SAD窗口大小(blockSize)15
//            bm.MinDisparity = 0;   //最小视差点
//            bm.UniquenessRatio = 10; //最佳匹配与第二好匹配之间的差异程度（5-15）
//            OpenCvSharp.Rect rect1 = new Rect(Data.leftROI.X, Data.leftROI.Y, Data.leftROI.Width, Data.leftROI.Height);
//bm.ROI1 = rect1;
//            OpenCvSharp.Rect rect2 = new Rect(Data.rightROI.X, Data.rightROI.Y, Data.rightROI.Width, Data.rightROI.Height);
//bm.ROI2 = rect2;
//            bm.NumDisparities = 32;
//            bm.Disp12MaxDiff = -1;   //左视图与右视图最大容许差异
//            bm.PreFilterCap = 31;   //预过滤饱和度阈值
//            bm.PreFilterSize = 15;  //预过滤窗口大小
//            bm.SpeckleRange = 32;   //视差变化阈值
//            bm.SpeckleWindowSize = 200;  //散斑窗口大小
//            bm.TextureThreshold = 50;  //纹理阈值