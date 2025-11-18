using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");
            var n=int.Parse(Console.ReadLine());

            double sum = 0;//накаплив сумму

            for (int i = 0; i < n; i++)//i будет счетчиком кол-ва чисел n
            {
                Console.WriteLine($"Введите {i + 1}-е число");
                double number = double.Parse(Console.ReadLine());//double использ тк действит числа 
                sum += Math.Abs(number);
            }
            Console.WriteLine($"Сумма модулей={sum}");
        }
    }
}
