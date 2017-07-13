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
            bool flag = true;
            while (flag == true)
            {
                flag = MainMenu();
            }

        }
        static private bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1) Caculate the area of a triangle");
            Console.WriteLine("2) Guessing number game");
            Console.WriteLine("3) exit");
            int result = int.Parse(Console.ReadLine());
            if (result == 1)
            {
                area();
                return true;
            }
            else if(result == 2)
            {
                GuessingNumber();
                return true; 
            }
            else if (result == 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void area()
        {
            Console.Clear();
            double[] length = new double[3];
            Console.WriteLine("请输入三角形的三边长");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("第{0}条边",i + 1);
                length[i] = float.Parse(Console.ReadLine());
            }
            if (JudgeTrangle(length))
            {
                double t = 0.5 * (length[0] + length[1] + length[2]);
                double s = Math.Sqrt(t * (t - length[0]) * (t - length[1]) * (t - length[2]));
                Console.WriteLine("三角形的面积是{0}", s);
            }
            Console.ReadLine();
        }
        private static bool JudgeTrangle(double[] length)
        {
            if (length[0]+length[1]>length[2]&& length[0] + length[2] > length[1] && length[1] + length[2] > length[0])
            {
                return true;
            }
            else
            {
                Console.WriteLine("您输入的三边不构成三角形");
                return false;
            }
        }
        private static void GuessingNumber()
        {
            Console.Clear();
            Random rd = new Random();
            int result = rd.Next(1, 100);
            int times = 0;
            bool flag = true;
            Console.WriteLine("猜数1-100");
            do
            {
                times++;
           
                int userNumber = int.Parse(Console.ReadLine());
                if(userNumber > result)
                {
                    Console.WriteLine("大了");
                }
                else if (userNumber < result)
                {
                    Console.WriteLine("小了");
                }
                if (userNumber == result)
                {
                    Console.WriteLine("你猜对了，你一共猜了{0}次",times);
                    flag = false;
                }
            } while (flag);
            Console.ReadLine();
        }
    }
}
