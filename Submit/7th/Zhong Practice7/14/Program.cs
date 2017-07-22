using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            box mybox = new box();
            Console.WriteLine("输入box的长：");
            mybox.lenth = Console.ReadLine();
            Console.WriteLine("输入box的宽：");
            mybox.width = Console.ReadLine();
            Console.WriteLine("输入box的高：");
            mybox.height = Console.ReadLine();
            Console.WriteLine("面积为：{0}", mybox.S());
            Console.WriteLine("体积为：{0}", mybox.V());
            Console.ReadLine();
        }
    }
    class box
    {
        public string lenth { get; set; }
        public string width { get; set; }
        public string height { get; set; }

        public double S()
        {
            double l = double.Parse(lenth);
            double w = double.Parse(width);
            double h = double.Parse(height);
            double s = 2 * (l * w + l * h + w * h);
            return s;
        }

        public double V()
        {
            double l1 = double.Parse(lenth);
            double w1 = double.Parse(width);
            double h1 = double.Parse(height);
            double v = l1 * w1 * h1;
            return v;
        }

    }
}
