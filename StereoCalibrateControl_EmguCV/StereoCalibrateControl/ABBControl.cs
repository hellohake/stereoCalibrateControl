using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.Discovery;
using ABB.Robotics.Controllers.RapidDomain;
using ABB.Robotics.Controllers.MotionDomain;
using ABB.Robotics.Controllers.EventLogDomain;

namespace StereoCalibrateControl
{
    public partial class ABBControl : Form
    {
        //定义变量
        private Controller abbcontroller = null;
        private NetworkScanner abbscanner = null;
        private NetworkWatcher abbnetworkWatcher = null;
        private ABB.Robotics.Controllers.RapidDomain.Task abbtask = null;
        private EventLog abblog = null;
        private EventLogCategory abbcat = null;
        private RobTarget gripper_Loc;          //机械抓坐标
        private RobTarget rd_p1;                //坐标点数据
        private RobTarget rd_p2;                //坐标点数据
        private RobTarget rd_p3;                //坐标点数据
        private RobTarget rd_p4;                //坐标点数据
        private bool Timer_ON = false; 
        
        public ABBControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化相关参数
        /// </summary>
        private void ABBControl_Load(object sender, EventArgs e)
        {            
            this.abbscanner = new NetworkScanner();
            this.abbscanner.Scan();                   //扫描控制器
            ControllerInfoCollection controllerInfos = this.abbscanner.Controllers;
            ListViewItem item = null;
            foreach (ControllerInfo controllerInfo in controllerInfos)
            {
                item = new ListViewItem(controllerInfo.IPAddress.ToString());
                item.SubItems.Add(controllerInfo.SystemName);
                item.SubItems.Add(controllerInfo.ControllerName);
                item.SubItems.Add(controllerInfo.Availability.ToString());
                item.SubItems.Add(controllerInfo.Id);
                item.SubItems.Add(controllerInfo.IsVirtual.ToString());
                item.SubItems.Add(controllerInfo.VersionName);
                this.listView1.Items.Add(item);
                item.Tag = controllerInfo;
                //组合框控件添加控制器
                this.controllerscomboBox.Items.Add(controllerInfo.IPAddress.ToString() + @"/" + controllerInfo.ControllerName);
            }
            this.abbnetworkWatcher = new NetworkWatcher(this.abbscanner.Controllers);
            this.abbnetworkWatcher.Found += AbbnetworkWatcher_Found;        //添加订阅，发现新设备
            this.abbnetworkWatcher.Lost += AbbnetworkWatcher_Lost;
            this.abbnetworkWatcher.EnableRaisingEvents = true;              //使能监控器
            this.abbscanner = null;
            //更新Table UI 控件
            this.Invoke(new EventHandler(UpdateUI), new Object[] { this, e });
            this.timer1.Start();                                            //启动定时器
            this.comboBox2.SelectedIndex = 2;                               //设置默认选择项            
        }
        private void UpdateUI(object sender, EventArgs e)
        {            
        }

        private void AbbnetworkWatcher_Lost(object sender, NetworkWatcherEventArgs e)
        {
            Data.LogString = "设备连接丢失" + e.Controller.IPAddress.ToString();
        }
        private void AbbnetworkWatcher_Found(object sender, NetworkWatcherEventArgs e)
        {
            this.Invoke(new EventHandler<NetworkWatcherEventArgs>(AddControllerToListView), new Object[] { this, e });
        }
        private void AddControllerToListView(object sender, NetworkWatcherEventArgs e)
        {
            ControllerInfo controllerInfo = e.Controller;
            ListViewItem item = new ListViewItem(controllerInfo.IPAddress.ToString());
            item.SubItems.Add(controllerInfo.SystemName);
            item.SubItems.Add(controllerInfo.ControllerName);
            item.SubItems.Add(controllerInfo.Availability.ToString());
            item.SubItems.Add(controllerInfo.Id);
            item.SubItems.Add(controllerInfo.IsVirtual.ToString());
            item.SubItems.Add(controllerInfo.VersionName);
            this.listView1.Items.Add(item);
            item.Tag = controllerInfo;
        }

        /// <summary>
        /// 连接控制器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connectBtn_Click(object sender, EventArgs e)
        {
            if(this.connectBtn.Text == "连接")
            {                
                if(this.controllerscomboBox.SelectedItem == null)
                {
                    Data.LogString = "[msg]  请选择一个控制器";
                    return;
                }
                //字符串分割
                string[] controllerString = ((string)this.controllerscomboBox.SelectedItem).Split('/');
                //找到控制器
                ListViewItem item = this.listView1.FindItemWithText(controllerString[0]);
                if (item.Tag != null)
                {
                    try
                    {
                        ControllerInfo controllerInfo = (ControllerInfo)item.Tag;
                        if (this.abbcontroller != null)
                        {
                            this.abbcontroller.Logoff();
                            this.abbcontroller.Dispose();
                            this.abbcontroller = null;
                        }
                        this.abbcontroller = ControllerFactory.CreateFrom(controllerInfo);
                        this.abbcontroller.Logon(UserInfo.DefaultUser);             //连接到控制器

                        this.abbtask = this.abbcontroller.Rapid.GetTask("T_ROB1");  //初始化abbTask
                        this.abblog = this.abbcontroller.EventLog;                  //初始化abblog
                        this.logcomboBox.SelectedIndex = 0;
                        this.abblog.MessageWritten += Abblog_MessageWritten;        //给abblog添加订阅事件                                                                                   

                        this.connectBtn.Text = "断开连接";
                        this.connectBtn.BackColor = Color.Green;
                        Timer_ON = true;                                //启动定时器更新状态信息
                        Data.LogString = "ABB 机器人控制器连接成功";
                    }
                    catch (Exception exception)
                    {
                        Data.LogString = exception.Message;
                    }
                }
                else
                {
                    this.abblog.MessageWritten -= Abblog_MessageWritten;        //取消订阅
                    Data.LogString = "选择的控制器无效";
                }
            }
            else if(this.connectBtn.Text == "断开连接")
            {
                if (this.abbcontroller != null)         //断开控制器连接
                {
                    this.abbcontroller.Logoff();
                    this.abbcontroller.Dispose();
                    this.abbcontroller = null;
                }
                //更新控件
                this.connectBtn.Text = "连接";
                this.connectBtn.BackColor = Color.Transparent;
                Timer_ON = false;                       //停止机器人状态更新
                Data.LogString = "ABB机器人连接断开";
            }
        }
        /// <summary>
        /// 更新日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Abblog_MessageWritten(object sender, MessageWrittenEventArgs e)
        {
            this.Invoke(new EventHandler<MessageWrittenEventArgs>(UpdateAbblog), new Object[] { this, e });
        }

        private void UpdateAbblog(object sender, MessageWrittenEventArgs e)
        {
            abbcat = abblog.GetCategory(CategoryType.Common);
            foreach (EventLogMessage emsg in abbcat.Messages)
            {
                //设置log输出格式
                this.logtextBox.AppendText(string.Format("{2,-30:yyyy-MM-dd hh:mm:ss}{0,-10}{1,-40}", emsg.SequenceNumber, emsg.Title,emsg.Timestamp)
                                                + "\r\n");
            }           
        }


        /// <summary>
        /// 重新扫描控制器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scanBtn_Click(object sender, EventArgs e)
        {            
            //断开控制器连接     待实现
            //...
            this.abbscanner = new NetworkScanner();
            this.abbscanner.Scan();                   //扫描控制器
            ControllerInfoCollection controllerInfos = this.abbscanner.Controllers;
            ListViewItem item = null;
            this.listView1.Items.Clear();             //移除所有项重新扫描
            this.controllerscomboBox.Items.Clear();   //移除所有项重新扫描
            this.listView1.BeginUpdate();             //更新数据，直到EndUpdate()
            foreach (ControllerInfo controllerInfo in controllerInfos)
            {
                item = new ListViewItem(controllerInfo.IPAddress.ToString());
                item.SubItems.Add(controllerInfo.SystemName);
                item.SubItems.Add(controllerInfo.ControllerName);
                item.SubItems.Add(controllerInfo.Availability.ToString());
                item.SubItems.Add(controllerInfo.Id);
                item.SubItems.Add(controllerInfo.IsVirtual.ToString());
                item.SubItems.Add(controllerInfo.VersionName);
                this.listView1.Items.Add(item);
                item.Tag = controllerInfo;
                //组合框控件添加控制器
                this.controllerscomboBox.Items.Add(controllerInfo.IPAddress.ToString() + @"/" + controllerInfo.ControllerName);
            }
            this.listView1.EndUpdate();           //结束数据处理，一次绘制UI
            Data.LogString = "扫描完成";
        }
        /// <summary>
        /// Rapid程序执行1次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excOnceBtn_Click(object sender, EventArgs e)
        {
            using (Mastership mr = Mastership.Request(abbcontroller.Rapid))
            {
                abbcontroller.Rapid.Start(RegainMode.Continue, ExecutionMode.Continuous, ExecutionCycle.Once);
            }
            this.cyclelabel.Text = "Once";
            Data.LogString = "[msg]  operationmode: Once";
        }
        /// <summary>
        /// Rapid程序一直运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excForeverBtn_Click(object sender, EventArgs e)
        {
            using (Mastership mr = Mastership.Request(abbcontroller.Rapid))
            {
                abbcontroller.Rapid.Start(RegainMode.Continue, ExecutionMode.Continuous, ExecutionCycle.Forever);
            }
            this.cyclelabel.Text = "Forever";
            Data.LogString = "[msg]  operationmode: Forever";
        }
        /// <summary>
        /// Rapid程序立刻停止
        /// </summary>        
        private void stopRightBtn_Click(object sender, EventArgs e)
        {
            using (Mastership mr = Mastership.Request(abbcontroller.Rapid))
            {
                abbcontroller.Rapid.Stop(StopMode.Immediate);       //立刻停止
            }
        }

        private void stopLaterBtn_Click(object sender, EventArgs e)
        {
            using (Mastership mr = Mastership.Request(abbcontroller.Rapid))
            {
                abbcontroller.Rapid.Stop(StopMode.Cycle);       //执行完当前循环后停止
            }
        }
        /// <summary>
        /// 读入Rapid中robtarget数据至ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readPointsBtn_Click(object sender, EventArgs e)
        {
            abbtask = abbcontroller.Rapid.GetTask("T_ROB1");        //获取任务
            if(abbtask == null)
            {
                return;
            }
            //获得RobTarget数据
            rd_p1 = (RobTarget)abbtask.GetRapidData("MainModule", "p1").Value;
            rd_p2 = (RobTarget)abbtask.GetRapidData("MainModule", "p2").Value;
            rd_p3 = (RobTarget)abbtask.GetRapidData("MainModule", "p3").Value;            
            string[] rd_p_strings = new string[] { rd_p1.ToString(), rd_p2.ToString(), rd_p3.ToString() };
            string[] points = new string[] { "p1", "p2", "p3" };
            ListViewItem item = null;
            this.pointslistView.BeginUpdate();
            for (int i = 0; i < points.Length;i++)
            {
                item = new ListViewItem(points[i]);
                item.SubItems.Add(rd_p_strings[i]);
                this.pointslistView.Items.Add(item);        //添加元素
            }
            this.pointslistView.EndUpdate();                //更新控件
            Data.LogString = "坐标点数据读入完毕`";
        }
        /// <summary>
        /// 清空pointsListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            if(this.pointslistView.Items != null)
            {
                this.pointslistView.Items.Clear();
            }
        }
        /// <summary>
        /// 定时器更新机器人状态信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Timer_ON)
            {                
                if (this.comboBox2.Text.Contains("工件坐标"))
                {
                    gripper_Loc = abbcontroller.MotionSystem.ActiveMechanicalUnit.GetPosition(CoordinateSystemType.WorkObject);//读取当前坐标系
                    this.x_label.Text = gripper_Loc.Trans.X.ToString();
                    this.y_label.Text = gripper_Loc.Trans.Y.ToString();
                    this.z_label.Text = gripper_Loc.Trans.Z.ToString();
                    this.q1_label.Text = gripper_Loc.Rot.Q1.ToString();
                    this.q2_label.Text = gripper_Loc.Rot.Q2.ToString();
                    this.q3_label.Text = gripper_Loc.Rot.Q3.ToString();
                    this.q4_label.Text = gripper_Loc.Rot.Q4.ToString();                    
                }
                this.speedlabel.Text = this.abbcontroller.MotionSystem.SpeedRatio.ToString() + "%";
                this.cyclelabel.Text = this.abbcontroller.Rapid.Cycle.ToString();
                this.modelabel.Text = this.abbcontroller.OperatingMode.ToString();                                
            }
            else
            {
            }
        }
        /// <summary>
        /// 机器人电机上电
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void motorsONBtn_Click(object sender, EventArgs e)
        {
            this.abbcontroller.State = ControllerState.MotorsOn;    //设置状态
            this.motorsOffBtn.Enabled = true;                       //互锁
            this.motorsONBtn.Enabled = false;
            this.motorStatelabel.Text = "MotorsOn";
            this.motorStatelabel.ForeColor = Color.Green;           //设置颜色
        }
        /// <summary>
        /// 机器人电机下电
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void motorsOffBtn_Click(object sender, EventArgs e)
        {
            this.abbcontroller.State = ControllerState.MotorsOff;
            this.motorsOffBtn.Enabled = false;
            this.motorsONBtn.Enabled = true;
            this.motorStatelabel.Text = "MotorsOff";
            this.motorStatelabel.ForeColor = Color.Black;
        }

        private void excStartBtn_Click(object sender, EventArgs e)
        {
            using (Mastership mr = Mastership.Request(this.abbcontroller.Rapid))
            {
                this.abbcontroller.Rapid.Start();
            }
        }

        /// <summary>
        /// PP移至main
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptm_Btn_Click(object sender, EventArgs e)
        {
            this.abbtask.ResetProgramPointer();  //重置程序指针至Main
        }
        /// <summary>
        /// 读取Rapid程序至上位机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getBtn_Click(object sender, EventArgs e)
        {
            if(this.abbcontroller.State == ControllerState.MotorsOff)
            {
                string dir = this.abbcontroller.FileSystem.RemoteDirectory;
                abbtask.SaveProgramToFile(dir);                 //保存程序文件至当前目录
                StreamReader sr = new StreamReader(dir + @"\" + "MainModule.mod");
                string proData = sr.ReadToEnd();
                sr.Close();
                this.textBox1.Text = proData;
                Data.LogString = "[msg]  获取成功";
            }
            else
            {
                Data.LogString = "[msg]  请先停止机器人运动(电机下电)~";
            }
            
        }
        /// <summary>
        /// 窗体关闭释放资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ABBControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.abbcontroller != null)
            {
                this.abbcontroller.Logoff();
                this.abbcontroller.Dispose();
                this.abbcontroller = null;
            }
        }

        private void clearLogBtn_Click(object sender, EventArgs e)
        {
            this.logtextBox.Text = null;
        }
    }
}
