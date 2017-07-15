using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一串数字：");
            string str0 = Console.ReadLine();
            int str1 = int.Parse(str0);
            string str2 = string.Format("{0:N}", str1);
            Console.WriteLine(str2);
            Console.ReadLine();
        }
        

    }
}
