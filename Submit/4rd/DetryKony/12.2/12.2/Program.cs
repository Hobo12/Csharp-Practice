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
            Console.WriteLine("input a sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine(delete(sentence)); 
            Console.ReadLine();
        }
        private static string delete(string x)
        {
            string result = "";
            string[] arr = x.Split(' ');
            string target = "o";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains(target))
                {
                    arr[i] = arr[i].Remove(0,arr[i].Length);
                }
            }
            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i]!="")
                {
                    result = result + arr[i] + " ";
                }            
            }
            result = result.Trim();
            return result;
        }
    }
}
