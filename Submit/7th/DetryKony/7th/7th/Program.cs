using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th
{
    class Program
    {
        static void Main(string[] args)
        {
            box cuboid = new box();
            Console.WriteLine("Input high ,width ,depth");
            cuboid.high = Convert.ToDouble(Console.ReadLine());
            cuboid.width = Convert.ToDouble(Console.ReadLine());
            cuboid.depth = Convert.ToDouble(Console.ReadLine());
            Console.Write("volume=");
            Console.Write(box.volume(cuboid));
            Console.WriteLine();
            Console.Write("area=");
            Console.Write(box.area(cuboid));
            Console.ReadLine();
        }
    }
    class box
    {
        public double high { get; set; }
        public double width { get; set; }
        public double depth { get; set; }
        public static double volume(box x)
        {
            return x.high * x.width * x.depth;
        }
        public static double area(box x)
        {
            return 2 * (x.high * x.width + x.width * x.depth + x.high * x.depth);
        }
    }
}
