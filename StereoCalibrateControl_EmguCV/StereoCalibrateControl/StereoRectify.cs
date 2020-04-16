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
using System.IO;
using System.Threading;

namespace StereoCalibrateControl
{
    public partial class StereoRectify : Form
    {
        /////存储文件路径信息
        public DirectoryInfo rootDir;
        public string root;
        /////标定用数据
        public Size patternSize;               //棋盘格角点数           等待写入
        public int SquareSize = 0;             //标定用棋盘格实际尺寸大小 

        public Mat srcImg = new Mat();
        public Mat grayImg = new Mat();       
        public VectorOfPointF corners = new VectorOfPointF();                           //临时存储一幅图像角点坐标
        public VectorOfVectorOfPointF left_corners_set  = new VectorOfVectorOfPointF(); //存储左相机棋盘格角点坐标
        public VectorOfVectorOfPointF right_corners_set = new VectorOfVectorOfPointF(); //存储右相机棋盘格角点坐标
        /******************还是得使用objectpoints************************/
        public VectorOfVectorOfPoint3D32F objectpoints = new VectorOfVectorOfPoint3D32F();       //存储棋盘格角点三维空间坐标       
        public Mat leftCamMatrix  = new Mat(3, 3, DepthType.Cv32F, 1);       //相机内参矩阵
        public Mat rightCamMatrix = new Mat(3, 3, DepthType.Cv32F, 1);
        public Mat leftDistCoeffs = new Mat(1, 5, DepthType.Cv32F, 1);      //相机畸变向量
        public Mat rightDistCoeffs = new Mat(1, 5, DepthType.Cv32F, 1); 
        public VectorOfMat leftRvecs = new VectorOfMat();           //左相机所有相对于摄像机坐标系的旋转向量 3 * 1
        public VectorOfMat leftTvecs = new VectorOfMat();           //左相机所有相对于摄像机坐标系的平移向量
        public VectorOfMat rightRvecs = new VectorOfMat();          //左相机所有相对于摄像机坐标系的旋转向量
        public VectorOfMat rightTvecs = new VectorOfMat();          //左相机所有相对于摄像机坐标系的平移向量
        /////相机内参标定结果使用参数        
        public double err = 0.0;
        public double total_err = 0.0;
        VectorOfPoint3D32F objtemp = new VectorOfPoint3D32F();
        VectorOfPointF imgtemp = new VectorOfPointF();
        VectorOfPointF projecttemp = new VectorOfPointF();
        /// <summary>
        /// 立体标定使用参数
        /// </summary>
        public Mat R = new Mat(3, 3, DepthType.Cv32F, 1);       //旋转矩阵
        public Mat T = new Mat(3, 1, DepthType.Cv32F, 1);       //平移向量，注意：3 * 1
        public Mat E = new Mat(3, 3, DepthType.Cv32F, 1);       //本质矩阵E
        public Mat F = new Mat(3, 3, DepthType.Cv32F, 1);       //基础矩阵
        public Mat R1 = new Mat();
        public Mat R2 = new Mat();
        public Mat P1 = new Mat();
        public Mat P2 = new Mat();
        public Mat Q = new Mat();
        public Rectangle leftROI  = new Rectangle();
        public Rectangle rightROI = new Rectangle();

        public Mat leftMap1 = new Mat();
        public Mat leftMap2 = new Mat();
        public Mat rightMap1 = new Mat();
        public Mat rightMap2 = new Mat();

        /// <summary>
        /// 相机内参结果标定评价
        /// </summary>
        public double dist_err = 0;

        public StereoRectify()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载初始化函数
        /// </summary>
        private void StereoRectify_Load(object sender, EventArgs e)
        {
            //注意文件夹目录关系
            rootDir = Directory.GetParent(Environment.CurrentDirectory); //定位到bin目录
            root = rootDir.Parent.Parent.FullName + @"\CameraPicture";//定位到项目文件夹的CameraPicture文件夹下(完整目录)
            int fileNum = Directory.GetFiles(root, "*.jpg").Length;         //获取jpg文件的总数
            this.imgnum1.Text = ((int)fileNum / 3).ToString();              //更新照片数
            //设置tooltip提示
            this.btnTip.SetToolTip(this.imagecap, "采集左右相机图片，建议左右各14张");
            this.btnTip.SetToolTip(this.btnDeleteLast, "删除上一幅采集图片");
            this.btnTip.SetToolTip(this.btnDeleteAll, "删除所有的图片");
            this.btnTip.SetToolTip(this.createFile, "创建文件calibrationImg.yaml");
        }
        /// <summary>
        /// 采集并保存相机内参标定用的图片
        /// </summary>
        private void imagecap_Click(object sender, EventArgs e)
        {
            if(Data.CAMERA_OPEN)                    //如果摄像头打开
            {
                imgnum1.Text = (int.Parse(imgnum1.Text) + 1).ToString();        //计数加1
                //获取原始图像
                Mat compositeImg = Data.compositeImg;
                Mat leftimg = Data.leftImg;
                Mat rightImg = Data.rightImg;
                //设置相片存储格式                       
                string filename_comImg = root + @"\comImg_" + imgnum1.Text + ".jpg";
                string filename_leftImg = root + @"\leftImg_" + imgnum1.Text + ".jpg";
                string filename_rightImg = root + @"\rightImg_" + imgnum1.Text + ".jpg";
                //保存图片
                CvInvoke.Imwrite(filename_comImg, compositeImg);
                CvInvoke.Imwrite(filename_leftImg, leftimg);
                CvInvoke.Imwrite(filename_rightImg, rightImg);
                //打印消息
                Data.LogString = "[msg]  采集图像成功~ ，现有：" + imgnum1.Text + "张标定图片";
            }
            else
            {
                Data.LogString = "[error]  摄像头未打开，采集图像失败";
                return;
            }
        }
        /// <summary>
        /// 删除上一幅图片
        /// </summary>
        private void btnDeleteLast_Click(object sender, EventArgs e)
        {
            if(int.Parse(imgnum1.Text) != 0)        //图片数不为0时
            {
                string filename_comImg = root + @"\comImg_" + imgnum1.Text + ".jpg";
                string filename_leftImg = root + @"\leftImg_" + imgnum1.Text + ".jpg";
                string filename_rightImg = root + @"\rightImg_" + imgnum1.Text + ".jpg";
                File.Delete(filename_comImg);
                File.Delete(filename_rightImg);
                File.Delete(filename_leftImg);
                imgnum1.Text = (int.Parse(imgnum1.Text) - 1).ToString();        //计数减1
                Data.LogString = "[msg]  删除图像成功，现有：" + imgnum1.Text + "张图片";
            }
            else
            {
                Data.LogString = "[msg]  图片已清空";
                return;
            }
        }
        /// <summary>
        /// 删除所有图片
        /// </summary>       
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(root);
                FileInfo[] file = directory.GetFiles();         //获取当前目录下所有文件
                foreach (var item in file)
                {
                    File.Delete(item.FullName);
                }
                imgnum1.Text = (0).ToString();        //更新数据
                Data.LogString = "图片已全部删除~";
            }
            catch (Exception exc)
            {
                Data.LogString = exc.Message;
            }
        }
        /// <summary>
        /// 相机内参标定计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCal_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(CameraIntrinsicCalculate);
            Thread t = new Thread(ts);
            t.Start();
        }
        /// <summary>
        /// 相机内参计算函数
        /// </summary>
        void CameraIntrinsicCalculate()
        {
            string[] allimgfiles = File.ReadAllLines(root + @"\calibrationImg.txt");    //读取文件中所有图片名称
            string imgfile = root + @"\" + allimgfiles[0];                              //必须是完整的路径
            try
            {
                for (int i = 0; i < allimgfiles.Length; i++)            
                {
                    imgfile = root + @"\" + allimgfiles[i];
                    if (imgfile.Contains("leftImg"))                 //提取左相机图片角点
                    {
                        srcImg = CvInvoke.Imread(imgfile, ImreadModes.Color);
                        CvInvoke.CvtColor(srcImg, grayImg, ColorConversion.Bgr2Gray);
                        if (false == CvInvoke.FindChessboardCorners(grayImg, patternSize, corners))
                        {
                            throw new Exception("左相机采集图片未识别到所有角点~，请重新采集~");
                        }
                        else
                        {
                            CvInvoke.Find4QuadCornerSubpix(grayImg, corners, new Size(11, 11));//亚像素级角点精确化
                            left_corners_set.Push(corners);                                    //存储提取的角点坐标
                        }
                    }
                    else if(imgfile.Contains("rightImg"))           //提取右相机图片角点
                    {
                        srcImg = CvInvoke.Imread(imgfile, ImreadModes.Color);
                        CvInvoke.CvtColor(srcImg, grayImg, ColorConversion.Bgr2Gray);
                        if (false == CvInvoke.FindChessboardCorners(grayImg, patternSize, corners))
                        {
                            throw new Exception("右相机采集图片未识别到所有角点~，请重新采集~");
                        }
                        else
                        {
                            CvInvoke.Find4QuadCornerSubpix(grayImg, corners, new Size(11, 11));//亚像素级角点精确化
                            right_corners_set.Push(corners);                                   //存储提取的角点坐标
                        }
                    }
                    CvInvoke.WaitKey(10);
                }            
                for (int k = 0; k < left_corners_set.Size; k++)
                {
                    VectorOfPoint3D32F tempPoint = new VectorOfPoint3D32F();
                    for (int i = 0; i < patternSize.Height; i++)
                    {
                        for (int j = 0; j < patternSize.Width; j++)
                        {
                            MCvPoint3D32f[] objPoint = new MCvPoint3D32f[1];
                            objPoint[0].X = j * SquareSize;
                            objPoint[0].Y = i * SquareSize;
                            objPoint[0].Z = 0;
                            tempPoint.Push(objPoint);
                        }
                    }
                    objectpoints.Push(tempPoint);
                }                       
                //左相机内参标定
                CvInvoke.CalibrateCamera(objectpoints, left_corners_set, new Size(320, 240),
                            leftCamMatrix, leftDistCoeffs, leftRvecs, leftTvecs, CalibType.Default, new MCvTermCriteria(30, 0.00001));
                //右相机内参标定
                CvInvoke.CalibrateCamera(objectpoints, right_corners_set, new Size(320, 240),
                            rightCamMatrix, rightDistCoeffs, rightRvecs, rightTvecs, CalibType.Default, new MCvTermCriteria(30, 0.00001));               
                Data.LogString = "相机内参标定完成，请保存数据~~";
            }
            catch (Exception e)
            {
                Data.LogString = e.Message;
            }
        }
        /// <summary>
        /// 创建calibrationImg.txt
        /// </summary>
        private void createFile_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(root);
            FileInfo[] leftfiles = directory.GetFiles("left*.jpg");         //获取特定文件
            FileInfo[] rightfiles = directory.GetFiles("right*.jpg");       //获取特定文件
            StreamWriter fs = File.CreateText(root + @"\calibrationImg.txt");   //创建文件
            foreach (var leftimgfile in leftfiles)
            {
                fs.WriteLine(leftimgfile.Name);
            }
            foreach (var rightimgfile in rightfiles)
            {
                fs.WriteLine(rightimgfile.Name);
            }
            fs.Close();
            Data.LogString = "calibrationImg.txt 创建成功";
        }
        /// <summary>
        /// 保存左右相机内参与畸变系数、内参标定像素误差 至 CameraCalResult.yaml
        /// </summary>       
        private void btnSavedata_Click(object sender, EventArgs e)
        {
            string filepath = root + @"\" + "CameraCalResult.yaml";
            //创建文件
            FileStorage fs = new FileStorage("CameraCalResult.yaml", FileStorage.Mode.Write);
            //写入数据
            fs.Write(leftCamMatrix, "leftCamMatrix");
            fs.Write(leftDistCoeffs, "leftDistCoeffs");
            fs.Write(rightCamMatrix, "rightCamMatrix");
            fs.Write(rightDistCoeffs, "rightDistCoeffs");
            fs.Write(total_err, "CameraIntrinsicError");
            //释放
            fs.ReleaseAndGetString();
            File.Copy("CameraCalResult.yaml", filepath, true);      //copy文件
            Data.LogString = "保存成功~";
        }
        /// <summary>
        /// 相机内参标定结果评价
        /// </summary>
        private void btnEst_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < left_corners_set.Size; i++)         //计算左相机标定误差
                {
                    objtemp = objectpoints[i];
                    CvInvoke.ProjectPoints(objtemp, leftRvecs[i], leftTvecs[i],
                                            leftCamMatrix, leftDistCoeffs, projecttemp); //空间点反向投影
                    imgtemp = left_corners_set[i];
                    //转换为矩阵存储方式：  需要再想！！！
                    Image<Bgr, Single> prot = new Image<Bgr, float>(projecttemp.Size, 1);
                    Image<Bgr, Single> imgt = new Image<Bgr, float>(imgtemp.Size, 1);
                    for (int j = 0; j < projecttemp.Size; j++)
                    {
                        prot.Data[0, j, 0] = projecttemp[j].X;
                        prot.Data[0, j, 1] = projecttemp[j].Y;
                        prot.Data[0, j, 2] = 0;
                    }
                    for (int j = 0; j < imgtemp.Size; j++)
                    {
                        imgt.Data[0, j, 0] = imgtemp[j].X;
                        imgt.Data[0, j, 1] = imgtemp[j].Y;
                        imgt.Data[0, j, 2] = 0;
                    }
                    err = CvInvoke.Norm(prot, imgt, NormType.L2);  //计算误差
                    total_err += (err /= (patternSize.Width * patternSize.Height));
                }
                for (int i = 0; i < right_corners_set.Size; i++)                 //计算右相机标定误差
                {
                    objtemp = objectpoints[i];
                    CvInvoke.ProjectPoints(objtemp, rightRvecs[i], rightTvecs[i],
                                            rightCamMatrix, rightDistCoeffs, projecttemp); //空间点反向投影
                    imgtemp = right_corners_set[i];
                    //转换为矩阵存储方式：  需要再想！！！
                    Image<Bgr, Single> prot = new Image<Bgr, float>(projecttemp.Size, 1);
                    Image<Bgr, Single> imgt = new Image<Bgr, float>(imgtemp.Size, 1);
                    for (int j = 0; j < projecttemp.Size; j++)
                    {
                        prot.Data[0, j, 0] = projecttemp[j].X;
                        prot.Data[0, j, 1] = projecttemp[j].Y;
                        prot.Data[0, j, 2] = 0;
                    }
                    for (int j = 0; j < imgtemp.Size; j++)
                    {
                        imgt.Data[0, j, 0] = imgtemp[j].X;
                        imgt.Data[0, j, 1] = imgtemp[j].Y;
                        imgt.Data[0, j, 2] = 0;
                    }
                    err = CvInvoke.Norm(prot, imgt, NormType.L2);  //计算误差
                    total_err += (err /= (patternSize.Width * patternSize.Height));
                }
                total_err /= (left_corners_set.Size + right_corners_set.Size);      //取均值                
                Data.LogString = "相机内参标定平均误差：" + total_err.ToString() + "\n请保存数据~";
            }
            catch (Exception exc)
            {
                Data.LogString = exc.Message;
            }           
            
        }
        /// <summary>
        /// 立体标定
        /// </summary>
        private void stereoCalbtn_Click(object sender, EventArgs e)
        {
            //立体标定，求解R，T, E, F
            CvInvoke.StereoCalibrate(objectpoints, left_corners_set, right_corners_set, leftCamMatrix, leftDistCoeffs,
                rightCamMatrix, rightDistCoeffs, new Size(320, 240), R, T, E, F, CalibType.FixIntrinsic, new MCvTermCriteria(30, 0.000001));            
            Data.LogString = "一共计算" + objectpoints.Size.ToString() + "幅图像~\n立体标定计算完毕，请进行立体校正~";
        }
        /// <summary>
        /// Bogut立体校正
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bogutBtn_Click(object sender, EventArgs e)
        {
            //Bouguet算法
            CvInvoke.StereoRectify(leftCamMatrix, leftDistCoeffs, rightCamMatrix, rightDistCoeffs, new Size(320, 240), R, T,
                            R1, R2, P1, P2, Q, StereoRectifyType.CalibZeroDisparity, 0, new Size(320, 240), ref leftROI, ref rightROI);
            //传递数据
            Data.leftROI = this.leftROI;
            Data.rightROI = this.rightROI;
            Data.Q = this.Q;                    //备份Q!!!
            Data.LogString = "立体校正计算完毕，请进行校正映射计算~";
        }
        /// <summary>
        /// 校正映射计算
        /// </summary>
        private void calRectifymapBtn_Click(object sender, EventArgs e)
        {
            //计算左相机视图校正映射
            CvInvoke.InitUndistortRectifyMap(leftCamMatrix, leftDistCoeffs, R1, P1, new Size(320, 240),DepthType.Cv32F, leftMap1, leftMap2);
            //计算右相机视图校正映射
            CvInvoke.InitUndistortRectifyMap(rightCamMatrix, rightDistCoeffs, R2, P2, new Size(320, 240), DepthType.Cv32F, rightMap1, rightMap2);
            //保存数据
            Data.leftMap1  = this.leftMap1;
            Data.leftMap2  = this.leftMap2;
            Data.rightMap1 = this.rightMap1;
            Data.rightMap2 = this.rightMap2;
            Data.LogString = "校正映射计算完毕，可以显示共面行对准图像了";
        }
        /// <summary>
        /// 打开新的窗体 显示共面行对准图像
        /// </summary>
        private void showRectifyImgBtn_Click(object sender, EventArgs e)
        {
            RectifyImage rectifyimage = new RectifyImage();
            Data.LogString = "共面行对准图像窗口已打开~";
            rectifyimage.Show();
        }
        /// <summary>
        /// 立体校正效果评价计算
        /// </summary>        
        private void stereoCalQuanlityBtn_Click(object sender, EventArgs e)
        {
            System.Threading.ThreadStart ts = new ThreadStart(Stereo_Calib_Quanlity_Check);
            System.Threading.Thread t = new Thread(ts);
            t.Start();
            t.Join();
            Data.LogString = "立体校正平均偏移距离：" + dist_err.ToString();
        }
        /// <summary>
        /// 立体校正评价函数
        /// </summary>
        private void Stereo_Calib_Quanlity_Check()
        {
            int board_n = patternSize.Width * patternSize.Height;
            float a = 0, b = 0, c = 0;
            float x = 0, y = 0;
            double err = 0;
            double allerr = 0;
            VectorOfPoint3D32F leftLines = new VectorOfPoint3D32F();
            VectorOfPoint3D32F rightLines = new VectorOfPoint3D32F();
            //存储校正映射后点集
            VectorOfVectorOfPointF leftpoints_rectify  = new VectorOfVectorOfPointF();
            VectorOfVectorOfPointF rightpoints_rectify = new VectorOfVectorOfPointF();
            VectorOfPointF tempPoints = new VectorOfPointF();
            VectorOfPointF rimgPoints_temp = new VectorOfPointF();
            VectorOfPointF limgPoints_temp = new VectorOfPointF();
            for(int i = 0; i < left_corners_set.Size; i++)
            {
                //稀疏点校正，参考Learning OpenCV3
                CvInvoke.UndistortPoints(left_corners_set[i], tempPoints, leftCamMatrix, leftDistCoeffs, null, leftCamMatrix);
                leftpoints_rectify.Push(tempPoints);
            }
            for(int i = 0; i < right_corners_set.Size; i++)
            {
                //稀疏点校正，参考Learning OpenCV3
                CvInvoke.UndistortPoints(right_corners_set[i], tempPoints, rightCamMatrix, rightDistCoeffs, null, rightCamMatrix);
                rightpoints_rectify.Push(tempPoints);
            }
            //计算左相机图像点与极线的距离
            for(int i = 0; i < left_corners_set.Size;i++)
            {
                rimgPoints_temp = rightpoints_rectify[i];
                limgPoints_temp = leftpoints_rectify[i];
                CvInvoke.ComputeCorrespondEpilines(rimgPoints_temp, 2, F, leftLines);  //计算极线
                for(int j = 0; j < board_n; j++)
                {
                    //读取存储的数据
                    a = leftLines[j].X;
                    b = leftLines[j].Y;
                    c = leftLines[j].Z;
                    x = limgPoints_temp[j].X;
                    y = limgPoints_temp[j].Y;
                    //计算每个点到直线的距离    (点到直线距离公式)
                    err = Math.Abs(a * x + b * y + c) / Math.Sqrt(a * a + b * b);
                    allerr += err;
                }
            }
            //计算右相机图像点与极线的距离
            for (int i = 0; i < right_corners_set.Size; i++)
            {
                rimgPoints_temp = rightpoints_rectify[i];
                limgPoints_temp = leftpoints_rectify[i];
                CvInvoke.ComputeCorrespondEpilines(limgPoints_temp, 1, F, rightLines);  //计算极线
                for (int j = 0; j < board_n; j++)
                {
                    //读取存储的数据
                    a = rightLines[j].X;
                    b = rightLines[j].Y;
                    c = rightLines[j].Z;
                    x = rimgPoints_temp[j].X;
                    y = rimgPoints_temp[j].Y;
                    //计算每个点到直线的距离    (点到直线距离公式)
                    err = Math.Abs(a * x + b * y + c) / Math.Sqrt(a * a + b * b);
                    allerr += err;
                }
            }
            dist_err = allerr / (2 * (left_corners_set.Size + right_corners_set.Size) * board_n);
        }
        /// <summary>
        /// 保存立体标定数据
        /// </summary>       
        private void btnSaveData2_Click(object sender, EventArgs e)
        {
            string filepath = root + @"\" + "CameraCalResult.yaml";
            //打开文件追加内容
            FileStorage fs = new FileStorage("CameraCalResult.yaml", FileStorage.Mode.Append);
            fs.Write(R, "R");
            fs.Write(T, "T");
            fs.Write(E, "E");
            fs.Write(F, "F");
            fs.Write(Q, "Q");
            //fs.Write(leftMap1, "leftMap1");
            //fs.Write(leftMap2, "leftMap2");
            //fs.Write(rightMap1, "rightMap1");
            //fs.Write(rightMap2, "rightMap2");
            fs.Write(dist_err, "StereoRectifyQuanlity");            //保存立体校正误差
            fs.ReleaseAndGetString();
            File.Copy("CameraCalResult.yaml", filepath, true);      //copy文件
            Data.LogString = "保存成功";
        }
        /// <summary>
        /// 设置textbox只能输入正数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void width_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键，Backspace键，则取消该输入
            if(!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// 写入棋盘格参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wpBtn_Click(object sender, EventArgs e)
        {
            this.patternSize = new Size(int.Parse(this.width_textBox.Text), int.Parse(this.height_textBox.Text));
            this.SquareSize = int.Parse(this.size_textBox.Text);
            Data.LogString = "[msg]  棋盘格参数写入成功";
        }
    }
}
