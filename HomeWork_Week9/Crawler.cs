using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork_Week9
{
    public class Crawler
    {
        private Dictionary<string, bool> allURLs; // 所爬取以及即将爬取的所有资源
        private Queue<string> waitingURLs; // 正在等待被爬取的队列
        private string baseURL; // 主网页，仅爬取主网页上的信息
        private int timeLimit; // 爬取网页次数的限制
        private int crawlCount; // 已经爬取次数

        public delegate void DownloadSinglePage(string url); // 在类内定义委托类型
        public delegate void DownloadComplete(); // 定义爬取完成时的委托
        public event DownloadSinglePage downloadSinglePage; // 每爬取到一个页面就出发一个相应时间
        public event DownloadComplete downloadComplete; // 爬取结束产生该事件

        public Crawler(string originURL, int crawlMaxCount = 10)
        {
            // 获取主网页
            this.baseURL = originURL.Split(new string[2] { "//", "/" }, StringSplitOptions.RemoveEmptyEntries)[1];

            this.allURLs = new Dictionary<string, bool>();
            this.waitingURLs = new Queue<string>();

            // 主网页还尚未爬取
            this.allURLs.Add(originURL, false);
            this.waitingURLs.Enqueue(originURL);

            // 爬取次数
            this.timeLimit = crawlMaxCount;
            crawlCount = 0;
        }

        /// <summary>
        /// 将待爬取的网页依次以字符串的形式下载下来
        /// </summary>
        public void DownloadPage()
        {
            while(crawlCount < this.timeLimit)
            {
                // 取出一个待爬地址
                if(waitingURLs.Count == 0)
                {
                    break;
                }
                string nextURL = this.waitingURLs.Dequeue();
                string htmlPage = new WebClient().DownloadString(nextURL); // 下载网络资源
                this.allURLs[nextURL] = true;

                // 解析
                this.Parse(htmlPage, nextURL);

                if(crawlCount == timeLimit)
                {
                    downloadComplete();
                }

                // 一次爬取完成：取出网址——获取资源——解析资源，获取更多的链接网页进行爬取
            }
        }

        /// <summary>
        /// 将爬取的网页内容进行解析
        /// 获取改网页链接的其他网页
        /// </summary>
        /// <param name="htmlPage">已经爬取下来的，待解析的网页html代码</param>
        /// <param name="baseURL">得到当前html文件的源网页</param>
       public void Parse(string htmlPage, string baseURL) 
        {
            // 抽出其中的网站链接
            string htmlPattern = @"(href|HREF)[ ]*=[ ]*[""'](?<targetUrl>[^""'#>]+(.html|.htm))[""']";
            MatchCollection matchs = Regex.Matches(htmlPage, htmlPattern);

            for(int i = 0; i < matchs.Count; i++)
            {
                string nextURL = matchs[i].Groups["targetUrl"].Value;
                // 将相对地址转换为绝对地址
                string nextAbsoluteURL = this.RelativeToAbsolute(nextURL, baseURL);

                // 判断是否是主网页上的网址
                if (Regex.IsMatch(nextAbsoluteURL, this.baseURL))
                {
                    // 将符合要求的网址加入到集合中
                    if (!this.allURLs.ContainsKey(nextAbsoluteURL))
                    {
                        if(crawlCount >= timeLimit)
                        {
                            return;
                        }
                        // 每当成功爬取一个网页就出发downloadSinglePange事件，让form显示网址
                        downloadSinglePage(nextAbsoluteURL);
                        this.allURLs.Add(nextAbsoluteURL, false);
                        this.waitingURLs.Enqueue(nextAbsoluteURL);
                        crawlCount++;
                    }
                }

            }

        }

        /// <summary>
        /// 将绝对地址转换为相对地址
        /// </summary>
        /// <param name="relativeURL">相对地址</param>
        /// <param name="baseURL">爬取出当前网址的父网址(绝对地址格式)</param>
        /// <returns>转换后的相对地址</returns>
        public string RelativeToAbsolute(string relativeURL, string baseURL)
        {
            if (Regex.IsMatch(relativeURL, @"http[s]*://"))
            {
                return relativeURL;
            }else if (Regex.IsMatch(relativeURL, @"//"))
            {
                // 加上http：
                return "http:" + relativeURL;
            }else if (relativeURL.StartsWith("./"))
            {
                // 当前目录下
                if (baseURL.EndsWith("/"))
                {
                    return baseURL + relativeURL.Substring(1);
                }
                else
                {
                    return baseURL + relativeURL;
                }
            }else if (relativeURL.StartsWith("../"))
            {
                // 上一级目录下
                return this.RelativeToAbsolute(relativeURL.Substring(3), baseURL);
            }else if(relativeURL.StartsWith("/"))
            {
                // 位于根目录下
                return "http://" + baseURL.Split(new string[2] { "//", "/" }, StringSplitOptions.RemoveEmptyEntries)[1] +
                    relativeURL;
            }
            else
            {
                // 直接接在当前页面上
                if (baseURL.EndsWith("/"))
                {
                    return baseURL + relativeURL.Substring(1);
                }
                else
                {
                    return baseURL + relativeURL;
                }
            }
        }

        public void PrintAllUrl()
        {
            foreach (var url in allURLs)
            {
                Console.WriteLine(url.Key);
            }
        }
    }
}
