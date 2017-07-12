using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("原字符串为Console");
            Console.WriteLine("请输入需检索的字符串，以\"exit\"结束");
            bool flag = true;
            do
            {
                flag = experiment(Console.ReadLine());
            } while (flag);
            
        }

        private static bool experiment(string x)
        {
            if (x == "exit")
            {
                return false;
            }
            int j = 0;
            string originString = "Console";
            char[] originChar = originString.ToCharArray();
            char[] xChar = x.ToCharArray();
            for (int i = 0; i < originChar.Length&&j < xChar.Length; i++)
            {
                if (xChar[j]==originChar[i])
                {
                    j++;
                }
            }
            if (j == xChar.Length)
            {
                Console.WriteLine("匹配");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("不匹配");
                Console.WriteLine();
            }
            return true;
        }
    }
}
