using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону прямоугольного параллелепипеда");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую сторону прямоугольного параллелепипеда");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третью сторону прямоугольного параллелепипеда");
            var c = double.Parse(Console.ReadLine());

            var area = 2 * (a * b + a * c + b * c);
            var shape = a * b * c;

            Console.WriteLine("Площадь поверхности прямоугольного параллелепипеда равна  " + area);
            Console.WriteLine("Объем прямоугольного параллелепипеда равен  " + shape );
        }
    }
}
