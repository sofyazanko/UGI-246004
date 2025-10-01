using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n от 1 до 999, при этом число единиц не равно 0");

            var n = int.Parse(Console.ReadLine());

            var units = n % 10;

            var tens = (n / 10) % 10;

            var hundreds = n / 100;
            
            var result = units*100+tens*10+ hundreds;
            Console.WriteLine("Число x равно: "+result);

        }
    }
}
