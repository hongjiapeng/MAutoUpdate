﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace MAutoUpdate
{
    public static class LogTool
    {
        static string temp = AppDomain.CurrentDomain.BaseDirectory;
        public static void AddLog(String value)
        {
            var log = $"[{DateTime.Now.ToString()}]{value}";
            Debug.WriteLine(log);
            if (!Directory.Exists(Path.Combine(temp, @"log\")))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(temp, @"log\"));
                directoryInfo.Create();
            }
            using (StreamWriter sw = File.AppendText(Path.Combine(temp, @"log\update.log")))
            {
                sw.WriteLine(log);
            }
        }
    }
}
