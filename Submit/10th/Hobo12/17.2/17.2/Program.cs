using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("Objective.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            string path = "Objective.txt";
            DateTime localDate = DateTime.Now;

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("\n"+localDate);
            }

            Console.ReadLine();
        }
        
    }
}
