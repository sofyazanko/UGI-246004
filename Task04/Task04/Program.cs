using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            var x=double.Parse(Console.ReadLine());
            var y=F(x);

            Console.WriteLine("y=" + y);
        }
        static double F(double x)
            {
            return Math.Abs(x+(Math.Abs(x+(Math.Abs(x+Math.Sqrt(x+1))))));
        }
    }
}
