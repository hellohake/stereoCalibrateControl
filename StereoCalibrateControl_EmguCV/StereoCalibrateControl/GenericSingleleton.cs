#region 
/*----------------------------------------------------------------
* 项目名称 ：StereoCalibrateControl
* 项目描述 ：
* 类 名 称 ：GenericSingleleton
* 类 描 述 ：
* 所在的域 ：DESKTOP-43OU7EB
* 命名空间 ：StereoCalibrateControl
* 机器名称 ：DESKTOP-43OU7EB
* CLR 版本 ：4.0.30319.42000
* 作    者 ：hello
* 创建时间 ：2020/4/12 18:16:19
* 更新时间 ：2020/4/12 18:16:19
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
using System.Windows.Forms;             //添加窗体类

namespace StereoCalibrateControl
{
    //声明一个公共泛型
    public class GenericSingleleton<T> where T : Form,new()         //设置泛型约束
    {
        private static T t = null;
        public static T CreateInstance()
        {
            if(t == null || t.IsDisposed)
            {
                t = new T();
            }
            return t;
        }
    }
}
