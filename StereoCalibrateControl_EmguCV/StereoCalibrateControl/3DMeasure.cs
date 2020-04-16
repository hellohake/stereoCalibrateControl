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


namespace StereoCalibrateControl
{
    public partial class _3DMeasure : Form
    {
        //BM              
        private StereoBM bm;
        private Mat bm_lsrc      = new Mat();
        private Mat bm_rsrc      = new Mat();
        private Mat bm_distImg   = new Mat();
        private Mat bm_distImg8U = new Mat();
        private int BM_NumOfDis = 0;
        private int BM_BlockSize = 0;
        //Contours        
        private Mat contourSrc = new Mat();
        private Mat contourImg = new Mat(240, 320, DepthType.Cv8U, 3);
        private Mat grayImg = new Mat();
        private Mat cannyImg = new Mat();
        private VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
        private VectorOfRect hierarchy = new VectorOfRect();
        //Corners
        private GFTTDetector gFTT;                                        //Shi-Tomasi角点检测               
        //Timer        
        private System.Threading.Timer SGBMdispTimer;
        private System.Threading.Timer ObjectPointsCal_Timer;        
        //SGBM        
        private StereoSGBM sgbm;        
        //FLAG
        private bool BM_CAL_FLAG = false;
        private bool SHOWCONTOURS_FLAG = false;
        private bool OBJPOINTS_CAL_FLAG = false;        
        //坐标                
        private VectorOfPoint3D32F objXYZ = new VectorOfPoint3D32F();
        private MKeyPoint[] cornerPoints;                                 //存储检测角点
        private VectorOfPoint3D32F cornerPoints_vec = new VectorOfPoint3D32F(); //存储[x,y,d]
        private Image<Bgr, Single> bm_image3D = new Image<Bgr, Single>(320,240,new Bgr(0,0,0));

        public delegate void UpdateTextBox();                             //定义一个更新UI控件的委托

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
            sgbm = new StereoSGBM(0, 64, 15, 0, 0, 1, 60, 10,100,32);   
            gFTT = new GFTTDetector(4, 0.01, 1, 3, false, 0.04);                               //初始化GFTT                        
            ObjectPointsCal_Timer = new System.Threading.Timer(ObjectPointsCal, null, 0, 100); //初始化并启动定时器
        }
        private void ObjectPointsCal(object state)
        {
            if(BM_CAL_FLAG)                                //BM视差图计算
            {
                //获取原图  
                Data.leftImg.CopyTo(bm_lsrc);
                Data.rightImg.CopyTo(bm_rsrc);
                //转换为灰度图
                CvInvoke.CvtColor(bm_lsrc, bm_lsrc, ColorConversion.Bgr2Gray);
                CvInvoke.CvtColor(bm_rsrc, bm_rsrc, ColorConversion.Bgr2Gray);
                bm.Compute(bm_lsrc, bm_rsrc, bm_distImg);                       //BM算法只能处理灰度图
                bm_distImg.ConvertTo(bm_distImg, DepthType.Cv32F, 1.0 / 16);    //除16得到真正的视差图 -----这里的数据需要再次使用
                bm_distImg8U = new Mat(bm_distImg.Size, DepthType.Cv8U, 1);
                CvInvoke.Normalize(bm_distImg, bm_distImg8U, 0, 255, NormType.MinMax, DepthType.Cv8U); //归一化后显示
                this.imageBox1.Image = bm_distImg8U;
            }
            if(SHOWCONTOURS_FLAG)                         //轮廓角点计算
            {
                contourImg.SetTo(new MCvScalar(0, 0, 0));
                Data.leftImg.CopyTo(contourSrc);
                CvInvoke.CvtColor(contourSrc, grayImg, ColorConversion.Bgr2Gray);
                CvInvoke.Canny(grayImg, cannyImg, 100, 200, 3, false);               //转换为二值图
                CvInvoke.FindContours(cannyImg, contours, hierarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);
                CvInvoke.DrawContours(contourImg, contours, -1, new MCvScalar(255, 255, 255), 2);  //绘制所有轮廓
                cornerPoints = gFTT.Detect(grayImg);            //计算角点
                for(int i = 0; i < cornerPoints.Length; i++)
                {
                    Point pt = new Point();                    
                    pt.X = (int)cornerPoints[i].Point.X;
                    pt.Y = (int)cornerPoints[i].Point.Y;                                        
                    CvInvoke.Circle(contourImg, pt, 3, new MCvScalar(0, 0, 255), -1);   //绘制所有角点
                }
                this.imageBox2.Image = contourImg;                                      //显示图像
            }
            if(OBJPOINTS_CAL_FLAG)                      //计算角点的三维坐标在TextBox中显示
            {
                //2种方法
                Image<Gray, Single> bm_distImg_C = bm_distImg.ToImage<Gray, Single>();
                try
                {
                    for (int i = 0; i < cornerPoints.Length; i++)
                    {
                        MCvPoint3D32f[] ptf = new MCvPoint3D32f[1];                          //转换计算得到的角点，记得清空
                        ptf[0].X = cornerPoints[i].Point.X;
                        ptf[0].Y = cornerPoints[i].Point.Y;
                        if (ptf[0].X > bm_distImg_C.Width)                               //数组越界检查
                        {
                            ptf[0].X = bm_distImg_C.Width - 1;
                        }
                        if (ptf[0].Y > bm_distImg_C.Height)
                        {
                            ptf[0].Y = bm_distImg_C.Height - 1;
                        }
                        ptf[0].Z = bm_distImg_C.Data[(int)ptf[0].X, (int)ptf[0].Y, 0];        //获取角点在视差图中的深度值（单位是像素）                    
                        cornerPoints_vec.Push(ptf);                                          //存储转换好后的值                                        
                    }
                    CvInvoke.PerspectiveTransform(cornerPoints_vec, objXYZ, Data.Q);        //透视变换，得到稀疏特征点在摄像机坐标系下的坐标
                    //方法2  
                    //CvInvoke.ReprojectImageTo3D(bm_distImg, bm_image3D, Data.Q, true);
                    //for(int i = 0; i < cornerPoints.Length; i++)
                    //{
                    //    MCvPoint3D32f[] ptf = new MCvPoint3D32f[1];
                    //    //需要处理数组越界问题
                    //    ptf[0].X = this.bm_image3D.Data[(int)cornerPoints[i].Point.X, (int)cornerPoints[i].Point.Y, 0];
                    //    ptf[0].Y = this.bm_image3D.Data[(int)cornerPoints[i].Point.X, (int)cornerPoints[i].Point.Y, 1];
                    //    ptf[0].Z = this.bm_image3D.Data[(int)cornerPoints[i].Point.X, (int)cornerPoints[i].Point.Y, 2];
                    //    objXYZ.Push(ptf);               //存储计算好的空间坐标点
                    //}
                    //写入数据  必须调用Invoke方法
                    this.Invoke(new UpdateTextBox(UpdateTextBoxFunc), new object[] { });
                }
                catch (Exception e)
                {
                    Data.LogString = "[error]  " + e.Message;
                }                                                              
            }           
            cornerPoints_vec.Clear();                        //清空元素,Vector会一直叠加
        }   
        private void UpdateTextBoxFunc()                     //异步线程，更新UI线程
        {
            this.p1textBox.Text = "[" + objXYZ[0].X.ToString() + "," + objXYZ[0].Y.ToString() + "," + objXYZ[0].Z.ToString() + "]";
            this.p2textBox.Text = "[" + objXYZ[1].X.ToString() + "," + objXYZ[1].Y.ToString() + "," + objXYZ[1].Z.ToString() + "]";
            this.p3textBox.Text = "[" + objXYZ[2].X.ToString() + "," + objXYZ[2].Y.ToString() + "," + objXYZ[2].Z.ToString() + "]";
            this.p4textBox.Text = "[" + objXYZ[3].X.ToString() + "," + objXYZ[3].Y.ToString() + "," + objXYZ[3].Z.ToString() + "]";
        }
        /// <summary>
        /// 写入BM参数
        /// </summary>        
        private void button_writeBM_Click(object sender, EventArgs e)
        {
            if (this.textBox_BlockSize.Text != null && this.textBox_NumOfDis.Text != null)
            {
                this.BM_NumOfDis = int.Parse(this.textBox_NumOfDis.Text);
                this.BM_BlockSize = int.Parse(this.textBox_BlockSize.Text);
                Data.LogString = "[msg]  写入成功";
            }
            else
            {
                Data.LogString = "[msg]  请写入数据";
            }
        }       
        /// <summary>
        /// BM算法
        /// </summary>        
        private void bmBtn_Click(object sender, EventArgs e)
        {
            if(BM_NumOfDis == 0 || BM_BlockSize == 0)
            {
                Data.LogString = "[error]  BM初始化参数错误";
                return;
            }
            bm = new StereoBM(BM_NumOfDis,BM_BlockSize);    //初始化BM类
            BM_CAL_FLAG = true;           
        }
        /// <summary>
        /// 显示轮廓角点
        /// </summary>        
        private void showCon_Btn_Click(object sender, EventArgs e)
        {
            this.SHOWCONTOURS_FLAG = true;
        }
        

        /// <summary>
        /// 暂停视差图计算、轮廓角点计算
        /// </summary>        
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            this.BM_CAL_FLAG = false;
            this.SHOWCONTOURS_FLAG = false;
            this.OBJPOINTS_CAL_FLAG = false;
        }
        /// <summary>
        /// 关闭
        /// </summary>        
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.BM_CAL_FLAG = false;
            this.SHOWCONTOURS_FLAG = false;
            this.OBJPOINTS_CAL_FLAG = false;
            this.imageBox1.Image = null;
            this.imageBox2.Image = null;
        }
        /// <summary>
        /// 窗体关闭时释放资源
        /// </summary>       
        private void _3DMeasure_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        /// <summary>
        /// 实时计算工件三维坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calBtn_Click(object sender, EventArgs e)
        {
            this.OBJPOINTS_CAL_FLAG = true;
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