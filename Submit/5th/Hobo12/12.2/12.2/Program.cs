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
            Console.WriteLine("Enter a sentense and delete any word containing \'o\'");
            string initialSentence = Console.ReadLine();
            DeleteO(initialSentence);
            Console.ReadLine();
        }
        static private void DeleteO(string initialSentence)
        {
            char[] initialSentenceArray = initialSentence.ToCharArray();
            int beginning = 0;
            int ending = 0;
            for (int i  = 0; i < initialSentenceArray.Length; i++)
            {
                
                if (initialSentenceArray[i] == ' ')
                {
                    bool flag = true;
                    ending = i;
                    flag = CheckO(initialSentenceArray,beginning,ending);
                    if (flag)
                    {
                        initialSentence=initialSentence.Remove(beginning, ending - beginning);
                        initialSentenceArray = initialSentence.ToCharArray();
                        ending = beginning;
                        i = beginning;
                    }
                    else
                    {
                        beginning = ending;
                    }
                }

            }
            Console.WriteLine(initialSentence);
        }
        static private bool CheckO(char[] initialSentenceArray, int beginning, int ending)
        {
            for (int i = beginning; i <= ending; i++)
            {
                if (initialSentenceArray[i] == 'o')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
