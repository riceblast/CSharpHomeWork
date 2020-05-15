using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_Week9
{
    public partial class Form1 : Form
    {
        private string absoluteUrlCheckerPattern;
        private string toBeFilledUrlCheckerPattern; // 未写http，需要进行填充
        private Crawler crawler; // 爬取器

        public Form1()
        {
            InitializeComponent();
            absoluteUrlCheckerPattern = @"^(http[s]*)://[ ]*(www|mail).[\S]+.[\S]+";
            toBeFilledUrlCheckerPattern = @"^(www|mail).[\S]+.[\S]+";
        }

        // 开始爬取网页
        private void btnCrawl_Click(object sender, EventArgs e)
        {
            // 净空原有记录
            this.txtResultURL.Clear();

            // 正确性校验
            string originURL = null;

            // 判断网址是否合法
            if(Regex.IsMatch(txtURL.Text, absoluteUrlCheckerPattern))
            {
                originURL = txtURL.Text;
            }else if(Regex.IsMatch(txtURL.Text, toBeFilledUrlCheckerPattern))
            {
                originURL = "http://" + txtURL.Text;
            }
            else
            {
                // 非法网址
                MessageBox.Show("输入的网站非法，请重新输入");
                txtURL.Clear();
                return;
            }

            if (!originURL.Trim().EndsWith("/"))
            {
                originURL += "/";
            }

            // 判断数字是否合法
            if (!Regex.IsMatch(txtLimitTimes.Text.Trim(), @"^[\d]+$"))
            {
                // 如果数字不合法
                MessageBox.Show("输入的爬取次数不合法，请重新输入");
                txtLimitTimes.Clear();
                return;
            }

            // 如果网址和数字均合法，则进行爬取
            crawler = new Crawler(originURL, Convert.ToInt32(txtLimitTimes.Text));
            crawler.downloadSinglePage += this.ShowUrl;
            crawler.downloadComplete += this.Complete;
            // 使用线程的原因：
            // 如果不使用线程，则若爬虫不停止，form就无法显示
            // 多线程可以实现并发，在爬取的同时可以向用户显示网页
            new Thread(crawler.DownloadPage).Start();
        }

        private void ShowSingleUrl(string url)
        {
            this.txtResultURL.Text += "\n" + url;
        }

        // 每次成功爬取到一个网页，就将其显示出来
        private void ShowUrl(string url)
        {
            if (this.txtResultURL.InvokeRequired)
            {
                Action<String> action = this.ShowSingleUrl;
                this.Invoke(action, new object[] { url });
            }
            else
            {
                this.ShowSingleUrl(url);
            }
        }

        // 下载结束，提示用户
        private void ShowComplete()
        {
            this.txtResultURL.Text += "\n\n" + "爬取完成";
        }

        // 下载结束提示用户
        private void Complete()
        {
            if (this.txtResultURL.InvokeRequired)
            {
                Action action = this.ShowComplete;
                this.Invoke(action, new object[] { });
            }
            else
            {
                this.ShowComplete();
            }
        }
    }
}
