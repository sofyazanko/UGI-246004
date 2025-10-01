using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConvertial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 2;

            Console.WriteLine("x = "+x);

            x = 1.9;
            Console.WriteLine("x = " + x);

            //x = double.Parse(Console.ReadLine());
            //Console.WriteLine("x = " + x);

            int n = (int)x;
            Console.WriteLine("n = " + n);
            
            n= (int)Math.Round(x);
            Console.WriteLine("n = " + n);

            long m = 30000000000;
            Console.WriteLine("m = "+m);

            n=(int)m;
            Console.WriteLine("n = " + n);

            checked
            {
                n = (int)m;
            }
            //Console.WriteLine("n = " + n);
        }
    }
}
