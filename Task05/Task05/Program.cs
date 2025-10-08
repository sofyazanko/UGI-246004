using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Calculate(2, -2, 3) + Calculate(3, -3, 5) + Calculate(5, -5, 7);
            Console.WriteLine(Math.Round(x,3));


        }
        static double Calculate(double a, double b, double c) =>
               Math.Sqrt((a + Math.Pow(Math.E, b)) / c);
    }
}
