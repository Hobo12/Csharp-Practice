using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一段英文：");
            string str0 = Console.ReadLine();
            string str = ' ' + str0 + ' ';
            int n = str.Length;

            char[] c = str.ToCharArray();
            for (int i = 0; i < n; i++)
            {
                if (c[i] == 'o')
                {
                    int j1 = i;
                    while (c[j1] != ' ')
                    { c[j1] = '0'; j1--; }
                    
                    int j2 = i;
                    while (c[j2] != ' ')
                    { c[j2] = '0'; j2++; }
                    
                }

            }

            for (int p = 0; p < n; p++)
            {
                if (c[p] == '0')
                {
                    c[p] = ' ';
                }
            }

            string str1 = new string(c);
            str1 = str1.Trim();

            char[] w = str1.ToCharArray();
            for (int t = 2; t < str1.Length; t++)
            {
                if (w[t] != ' ')
                { w[t - 1] = '1'; }
            }

            string str2 = new string(w);
            str2 = str2.Replace(" ", "");
            str2 = str2.Replace("1", " ");
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
