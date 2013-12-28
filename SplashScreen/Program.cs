using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SplashScreen
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //登陆界面
            SplashScreen.Splasher.Show(typeof(SplashScreen.frmSplash));
            Logon dlg = new Logon();
            dlg.StartPosition = FormStartPosition.CenterScreen;
           
            DialogResult d = dlg.ShowDialog();
            //dlg.Show();
            //SplashScreen.Splasher.Close();
            //if (DialogResult.OK == dlg.ShowDialog())
            if (DialogResult.OK == d)
            
            {
                if (dlg.bLogin)
                {
                    SplashScreen.Splasher.Show(typeof(SplashScreen.frmSplash));

                    //gc.MainDialog = new MainForm();
                    //gc.MainDialog.StartPosition = FormStartPosition.CenterScreen;

                    //Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                    //Application.Run(gc.MainDialog);
                    Application.Run(new MainForm());
                }

            }
            dlg.Dispose();
            //Application.Run(new Form1());
        }
    }
}
