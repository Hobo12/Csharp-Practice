using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _17._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://ice.do/auth/login");
            Console.WriteLine(reply);
            File.WriteAllText(@"ice.html", reply + "Saved by Zhong Tianyi");
            Console.ReadLine();
        }
    }
}
