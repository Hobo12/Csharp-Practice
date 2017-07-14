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
            
            Console.WriteLine("目标字符串为：Console");
            
            bool displaymatch = true;
            do
            {
                displaymatch = match();
            } while (displaymatch==false);

        }

        private static bool match()
        {
            string str0 = "Console";
            Console.WriteLine("输入所需匹配的字符串：");
            string str1=Console.ReadLine();
            if (str1 == "exit")
            { return true; }
            char[] char0 = str0.ToArray();
            char[] char1 = str1.ToArray();
            int j = 0;
            for (int i = 0; i < char0.Length && j < char1.Length; i++)
            {
                if (char1[j] == char0[i])
                {
                    j++;
                }
            }
            if (j == char1.Length)
            {
                Console.WriteLine("匹配");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("不匹配");
                Console.WriteLine();

            }
            return false;
           


        }
          
    }
}
