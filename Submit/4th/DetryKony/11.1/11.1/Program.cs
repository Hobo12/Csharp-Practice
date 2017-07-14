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
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose a section");
            Console.WriteLine("1. Solve the area of triangle.");
            Console.WriteLine("2. Guessing game.");
            Console.WriteLine("3. Exit.");
            string result = Console.ReadLine();
            if (result=="1")
            {
                Console.WriteLine(First());
                Console.ReadLine();
                return true;
            }
            else if (result=="2")
            {
                Second();
                Console.ReadLine();
                return true;
            }
            else if (result =="3")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private static double First()
        {
            Console.Clear();
            Console.WriteLine("Enter the three sides of triangle to solve the area.");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c)/2;
            double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.Write("Area of triangle = ");
            return S;
        }
        private static void Second()
        {
            Console.Clear();
            Console.WriteLine("Guessing game!");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1,101);
            int times = 0;
            bool incorrect = true;
            int min = 1;
            int max = 100;
            Console.WriteLine("Guessing a number from {0} to {1}.", min, max);
            do
            {
                string input = Console.ReadLine();
                if (Convert.ToInt32(input) == randomNumber)
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong! Try again.");
                    if (Convert.ToInt32(input) > randomNumber)
                    {
                        Console.WriteLine("The number you have typed is too large.");
                        max = Convert.ToInt32(input) - 1;
                        Console.WriteLine("Guessing a number from {0} to {1}.", min, max);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("The number you have typed is too small.");
                        min = Convert.ToInt32(input) + 1;
                        Console.WriteLine("Guessing a number from {0} to {1}.", min, max);
                        Console.WriteLine();
                    }
                }
                times++;
            } while (incorrect);
            Console.WriteLine("Correct!");
            Console.WriteLine("You have tried {0} times to get the correct answer.", times);
        }

    }
}
