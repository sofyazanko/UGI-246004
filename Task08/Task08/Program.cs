using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число k");
            var k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число m");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число n");
            var n = int.Parse(Console.ReadLine());

            if (IfLogicalExpressionTrue(k, m, n))
                Console.WriteLine("Все числа делятся на 3");
        }
        static bool IfLogicalExpressionTrue(int k, int m, int n) =>
            (k % 3 == 0) && (m % 3 == 0) && (n % 3 == 0);
    }
}
