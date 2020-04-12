#region 
/*----------------------------------------------------------------
* 项目名称 ：StereoCalibrateControl
* 项目描述 ：
* 类 名 称 ：Data
* 类 描 述 ：
* 所在的域 ：DESKTOP-43OU7EB
* 命名空间 ：StereoCalibrateControl
* 机器名称 ：DESKTOP-43OU7EB
* CLR 版本 ：4.0.30319.42000
* 作    者 ：hello
* 创建时间 ：2020/4/2 16:07:27
* 更新时间 ：2020/4/2 16:07:27
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ hello 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using System.Drawing;

namespace StereoCalibrateControl
{
    class Data
    {
        public static Mat compositeImg = new Mat();
        public static Mat rightImg = new Mat();
        public static Mat leftImg = new Mat();
        /// <summary>
        /// 可以优化成结构体，减少变量数
        /// </summary>
        public static bool CAMERA_OPEN       = false;
        public static bool BLUR_FLAG         = false;
        public static bool MEDIANBLUR_FLAG   = false;
        public static bool GAUSSIANBLUR_FLAG = false;
        public static bool NOBLUR_FLAG = true;
        ///校正参数
        public static Mat leftMap1 = new Mat();
        public static Mat leftMap2 = new Mat();
        public static Mat rightMap1 = new Mat();
        public static Mat rightMap2 = new Mat();
        public static Mat Q = new Mat();
        //ROI区域
        public static Rectangle leftROI  = new Rectangle();
        public static Rectangle rightROI = new Rectangle();
        //Log
        public static string LogString = "就绪...";
    }
}
