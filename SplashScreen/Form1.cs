using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SplashScreen.Splasher.Status = "正在展示相关的内容";
            System.Threading.Thread.Sleep(1000);

            //..//此处省略部分加载耗时的代码

            SplashScreen.Splasher.Status = "初始化完毕";
            System.Threading.Thread.Sleep(500);

            SplashScreen.Splasher.Close();
        }
    }
}
