using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string main = "теплоход";

            string ho = main.Substring(5, 2);
            string lo = main.Substring(3, 2);
            string d = main.Substring(7, 1);
            string e = main.Substring(1, 1);


            string cold = ho + lo + d;
            string delo = d + e + lo;

            Console.WriteLine("Дано слово:" + main);
            Console.WriteLine("Новое слово получилось 'холод':" + cold);
            Console.WriteLine("Новое слово получилось 'дело':" + delo);

        }
    }
}





