using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _17._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a,b,reply;
            a = File.ReadAllText(@"C:\Users\39776\Documents\GitHub\Csharp-Practice\Submit\10th\DetryKony\17.2\Object.txt");
            Console.WriteLine(a);
            b = DateTime.Now.ToString();
            reply = a + b;
            File.WriteAllText(@"C:\Users\39776\Documents\GitHub\Csharp-Practice\Submit\10th\DetryKony\17.2\Object.txt",reply);
            Console.ReadLine();

        }
    }
}
