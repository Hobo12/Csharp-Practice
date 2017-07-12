using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        private static void MainMenu()
        {
            Console.WriteLine("Choose a section");
            Console.WriteLine("1)");
            Console.WriteLine("2)");
            Console.WriteLine("3)");
            string result = Console.ReadLine();
            if (result=="1")
            {

            }
            else if (result=="2")
            {

            }
            else if (result =="3")
            {

            }
            else { }

        }
        private static double First()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c)/2;
            double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return S;
        }

    }
}
