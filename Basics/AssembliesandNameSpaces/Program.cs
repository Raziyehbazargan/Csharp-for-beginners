using System;
using System.IO;
using System.Net;

namespace AssembliesandNameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We want to write in this file";
            File.WriteAllText(@"C:\text\myfile.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");
            File.WriteAllText(@"c:\text\myfile.txt", reply);

            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
