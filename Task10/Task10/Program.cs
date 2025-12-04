using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число a (меньше 500):");

            int a;//фикс исход значение

            if (!int.TryParse(Console.ReadLine(), out a))

            {
                Console.WriteLine("Ошибка ввода");
                return;
            }
            if (a >= 500)
            {
                Console.WriteLine("Число должно быть меньше 500");
                return;
            }
            int sum = 0;//накапливаем сумму начиная с 0

            for (int i = a; i <= 500; i++)//прибавл +1 к исх знач
                sum += i * i * i;

            Console.WriteLine($"Сумма кубов чисел от {a} до 500 равна {sum}");
        }

    }
}
