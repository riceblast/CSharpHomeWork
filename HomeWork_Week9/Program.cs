﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_Week9
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Crawler crawler = new Crawler("https://www.cnblogs.com/dstang2000/");
            //crawler.DownloadPage();
            //crawler.PrintAllUrl();
        }
    }
}
