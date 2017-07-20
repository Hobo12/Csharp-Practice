using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myBirthday = new DateTime(1996,2,5);
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge);
            Console.Read();
        }
    }
}
