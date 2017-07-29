using System;
using System.Collections.Generic;
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
            reply += "\nSaved by Hobo12";
            System.IO.File.WriteAllText(@"WriteText.html", reply);
        }
    }
}
