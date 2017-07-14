using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一串数字");
            int numbers = int.Parse(Console.ReadLine());
           
            string result = string.Format("{0:N}", numbers);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
