using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое натуральное целое число:");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Введите целое число");
                return;
            }
            Console.WriteLine("Введите второе натуральное целое число:");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Введите целое число");
                return;
            }

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Числа должны быть натуральными (больше 0)");
                return;
            }
            int nok = Math.Max(a,b);
            while (true)//пока не найдем нок будет работать
            {
                if (nok % a == 0 && nok % b == 0)//должно и на а, и на б делиться
                {
                    break;
                }

                nok++;//увелич на 1 каждый раз пока не найдем нок
            }

            Console.WriteLine($"Наименьшее общее кратное чисел {a} и {b} равно {nok}");
        }
    }
}
