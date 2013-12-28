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
    public partial class Logon : Form
    {
        public Logon()
        {
            InitializeComponent();
            SplashScreen.Splasher.Status = "正在登陆";
            System.Threading.Thread.Sleep(1000);

            SplashScreen.Splasher.Status = "初始化完毕";
            System.Threading.Thread.Sleep(500);
            SplashScreen.Splasher.Close();
            //SplashScreen.Splasher.Close();
        }
        //private bool blogin = false;

        public bool bLogin { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            bLogin = true;
            this.DialogResult = DialogResult.OK;

        }

        private void Logon_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
