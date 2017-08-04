using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace _17._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string a = client.DownloadString("https://ice.do/auth/login");
            string b = "\n";
            string c = "Saved by <DetryKony>";
            string reply = a + b + c;
            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\39776\Documents\GitHub\Csharp-Practice\Submit\10th\DetryKony\17.1\ice.html",reply);
            Console.ReadLine();
        }
    }
}
