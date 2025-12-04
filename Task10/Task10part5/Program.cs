using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое натуральное число:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе натуральное число:");
            b = int.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Числа должны быть натуральными (больше 0)");
                return
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
