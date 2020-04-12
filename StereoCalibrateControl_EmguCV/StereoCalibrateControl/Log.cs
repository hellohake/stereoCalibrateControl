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
    public partial class Log : Form
    {
        public string LogstringLast = null;
        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            //窗体加载时设置总是置顶
            this.checkBox1.Checked = true;
            this.TopMost = true;
            this.timer1.Start();
            this.LogstringLast = Data.LogString;
        }
        /// <summary>
        /// 设置是否总是置顶
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBox1.Checked)
            {
                this.TopMost = true;
            }
            else if(!this.checkBox1.Checked)
            {
                this.TopMost = false;
            }
        }
        /// <summary>
        /// 清空logTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Data.LogString = null;
            this.logTextBox.Text = null;
        }
        /// <summary>
        /// 定时更新日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Data.LogString != this.LogstringLast)
            {
                this.LogstringLast = Data.LogString;
                this.logTextBox.AppendText(Data.LogString + "\r\n");
            }else
            {
                this.LogstringLast = Data.LogString;
            }
        }
        /// <summary>
        /// 保存日志文件至本地
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}