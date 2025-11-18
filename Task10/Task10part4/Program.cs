using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n");
            var n = long.Parse(Console.ReadLine());

            Console.WriteLine("Введите число k (от 0 до 8):");
            var k = int.Parse(Console.ReadLine());

            if (k < 0 || k > 8)
            {
                Console.WriteLine("Число k должно быть в диапазоне от 0 до 8");
                return;
            }
            int sum = 0;

            var numb = n;//создали копию содерж число n

            while (numb > 0)
            {
                int digit = (int)(numb % 10);//берем послед цифру
                numb /= 10;//отсекаем

                if (digit > k)
                {
                    sum += digit;
                }    
            }
            Console.WriteLine($"Сумма цифр числа {n}, больших {k}, равна {sum}");
        }
    }
}
