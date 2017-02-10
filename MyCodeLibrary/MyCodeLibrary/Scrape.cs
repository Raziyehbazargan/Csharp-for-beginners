using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebPage(string url)
        {
            return GetWebPage(url);

        }

        public string ScrapeWebpage(string url, string filePath)
        {
            string reply = GetWebPage(url);

            File.WriteAllText(filePath, reply);
            return reply;

        }
        public string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
