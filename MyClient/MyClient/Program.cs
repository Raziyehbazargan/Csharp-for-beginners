using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloadFile dlFile = new DownloadFile();
            string value = dlFile.ScrapeWebpage("http://www.raziyeh.info");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
