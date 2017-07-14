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
            string target = "Console";
   
            bool flag = true;
            while (flag)
            {
                string userInput = Console.ReadLine();
             
                flag = JudgeExit(userInput, target);
            }
            
        }
        static private bool JudgeExit(string userInput, string target)
        {
            string end = "exit";
            if (end == userInput)
            {
                return false;
            }
            else
            {
                CompareInOrder(userInput,target);
                return true;
            }
        }
        static private void CompareInOrder(string userInput, string target)
        {
            char[] userInputArray = userInput.ToCharArray();
            char[] targetArray = target.ToCharArray();
            bool flag = true;
            int j = 0;
            for (int i = 0; i < userInputArray.Length; i++)
            {
                for (; j <= targetArray.Length; j++)
                {
                    if (j == targetArray.Length)
                    {
                        flag = false;
                        break;
                    }
                    else if (targetArray[j] == userInputArray[i])
                    {
                        break;
                    }
                   
                }
                if (flag == false)
                {
                    break;
                }
               
            }
            if (flag)
            {
                Console.WriteLine("匹配");
            }
            else
            {
                Console.WriteLine("不匹配");
            }
        }
    }
}
