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
            box firstBox = new box();

            firstBox.length = 2;
            firstBox.width = 3;
            firstBox.height = 4;

            Console.WriteLine("Box的面积是{0}",firstBox.area());
            Console.WriteLine("Box的体积是{0}", firstBox.volume());
            Console.ReadLine();
        }
    }
    class box
    {
        public double length { get; set; }
        public double width { get; set; }
        public double height { get; set; }

        public double area()
        {
            return 2 * (length * width + length * height + width * height);
        }
        public double volume()
        {
            return length * width * height;
        }

    }
}
