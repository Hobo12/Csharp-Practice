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
            bool displayMenu = true;
            while (displayMenu == true)
            {
               displayMenu= MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Option1");
            Console.WriteLine("2) Option2");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Triangle();
                return true;
            }
            else if (result == "2")
            {
                GussingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void Triangle()
        {
            Console.WriteLine("Triangle");
            Console.WriteLine("输入三边长度：");
            double result1=double.Parse( Console.ReadLine());
            double result2 = double.Parse(Console.ReadLine());
            double result3 = double.Parse(Console.ReadLine());
            double p = 0.5* (result1 + result2 + result3);
            double result = Math.Sqrt(p*(p-result1)* (p - result2)* (p - result3));
            Console.WriteLine("三角形面积为：");
            Console.WriteLine(result);
           
        }

        private static void GussingGame()
        {
            Console.WriteLine("Gussing game");
            Random myRandom = new Random();
            int RandomNumber = myRandom.Next(1, 101);
            int guesses = 0;
            bool incorrect = true;
            do
            {
               
                Console.WriteLine("输入一个1与100之间的整数：");
                
                int result= Int32.Parse(Console.ReadLine());
                guesses++;
                if (result == RandomNumber)
                {
                    incorrect = false;
                }
                else
                {
                    if (result < RandomNumber)
                    { Console.WriteLine("错误，猜测的数字偏小"); }
                    if (result > RandomNumber)
                    { Console.WriteLine("错误，猜测的数字偏大"); }
                    
                }

            } while (incorrect);
            Console.WriteLine("正确，你一共尝试了{0}次",guesses);

            Console.ReadLine();
        }
    }
}
