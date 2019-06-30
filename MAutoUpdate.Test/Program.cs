using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MAutoUpdate.Test
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory + "AutoUpdater.exe";
            string path = AppDomain.CurrentDomain.BaseDirectory + "MAutoUpdate.Test.exe";

            //同时启动自动更新程序
            if (File.Exists(path))
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo()
                {
                    //FileName = "AutoUpdater.exe",
                    //Arguments = "1.1.2.0" +
                    //            "1.1.2.2" +
                    //            "https://github.com/WELL-E" +
                    //            "https://gitee.com/hongjiapeng/MangoUpdate/raw/master/MAutoUpdate.Test%201.1.2.2.zip" +
                    //            @"E:\GitHub\20190512\MAutoUpdate\MAutoUpdate.Test\bin\Debug" +
                    //            "2b406701f8ad92922feb537fc789561a"

                    FileName = "MAutoUpdate.exe",
                    Arguments = " MAutoUpdate.Test 0"
                };
                Process proc = Process.Start(processStartInfo);
                if (proc != null)
                {
                    proc.WaitForExit();
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
