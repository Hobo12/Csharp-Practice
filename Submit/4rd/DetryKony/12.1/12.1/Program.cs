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
            Console.WriteLine("input how much it is:");
            string money = Console.ReadLine();
            Console.WriteLine(transform(money));
            Console.ReadLine();
        }
        private static string transform (string x)
        {
            char[] money1 = x.ToCharArray();
            char[] result = new char[money1.Length+(money1.Length-1)/3+3];
            result[money1.Length + (money1.Length - 1) / 3 + 2] = '0';
            result[money1.Length + (money1.Length - 1) / 3 + 1] = '0';
            result[money1.Length + (money1.Length - 1) / 3] = '.';
            int n = 0;
            int j = money1.Length + money1.Length / 3 - 1;
            for (int i = money1.Length-1; i >= 0 ; i--)
            {
                n++;
                if ((n-1)%3==0&&n>1)
                {
                    result[j] = ',';
                    j--;
                }
                result[j] = money1[i];
                j--;
            }
            string k = new string(result);
            return k;
        }
    }
}
