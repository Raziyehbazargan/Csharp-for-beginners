using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class DownloadFile
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebPAge(url);
        }
        public string ScrapeWebpage(string url, string filePath)
        {
            string reply = GetWebPAge(url);
            File.WriteAllText(filePath, reply);
            return reply;
        }
        private string GetWebPAge(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
