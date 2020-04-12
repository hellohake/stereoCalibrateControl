using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StereoCalibrateControl
{
    public partial class ImageProcess : Form
    {
        public ImageProcess()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageProcess_Load(object sender, EventArgs e)
        {
            //初始化不选中
            this.blurRadioBtn.Checked = false;
            this.medianBlurRadioBtn.Checked = false;
            this.gaussianBlurRadioBtn.Checked = false;
        }
        /// <summary>
        /// 滤波方式选择
        /// </summary>
        private void blurRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(this.blurRadioBtn.Checked==true)
            {
                Data.BLUR_FLAG = true;
                Data.LogString = "blur radio button chosed...";
            }
            else if(this.gaussianBlurRadioBtn.Checked==true)
            {
                Data.GAUSSIANBLUR_FLAG = true;
                Data.LogString = "gaussian blur radio button chosed...";
            }
            else if(this.medianBlurRadioBtn.Checked==true)
            {
                Data.MEDIANBLUR_FLAG = true;
                Data.LogString = "median blur radio button chosed...";
            }
            else if(this.noblurRadioBtn.Checked == true)
            {
                Data.NOBLUR_FLAG = true;
                Data.LogString = "no blur radio button chosed...";
            }
        }
    }
}
