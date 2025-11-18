using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task10part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            var n= double.Parse(Console.ReadLine());

            int number = 1;//начало с 1 тк натур числа начинаются с 1

            Console.WriteLine($"Квадраты натуральных чисел, не превышающие {n}:");
            while (number * number <= n)
            {
                Console.WriteLine($"Квадрат числа {number} = {number * number}");
                number++;
            }
            Console.WriteLine($"Следующие квадраты чисел будут превышать {n}.");
        }
    }
}
