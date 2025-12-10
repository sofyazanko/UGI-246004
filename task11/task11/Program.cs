using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число (n меньше 18446744073709551616):");
            string input = Console.ReadLine();

            if (!ulong.TryParse(input, out ulong number) || number == 0)//ulong тк 64битный и берет значения с диапазоне от 0 до 18 446 744 073 709 551 615 и 0 тоже убираем тк у нас положит числа
            {
                Console.WriteLine("Число должно быть положительным целым (n меньше 18446744073709551616).");
                return;
            }
            string numStr = number.ToString();//делаем строку
            int[] digits = new int[numStr.Length];//делаем массив который равен длине строки

            ulong changeable = number;//это времен переменная
            for (int i = 0; i < digits.Length; i++)//запустили цикл по всему масссиву
            {
                digits[i] = (int)(changeable % 10);//взяли послед цифру
                changeable /= 10;//убрали посл цифру
            }
            Console.WriteLine("Массив цифр числа в обратном порядке:");
            PrintIntArray(digits);
            Console.WriteLine("\nВведите число k:");//число k с нов строки
            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                Console.WriteLine("k введено неверно.");
                return;
            }
            int[] newDigits = new int[digits.Length];//создали копию массива
            for (int i = 0; i < digits.Length; i++)//опять запустили цикл
            {
                newDigits[i] = (digits[i] + k) % 10;
            }
            Console.WriteLine($"После прибавления {k} по модулю 10:");
            PrintIntArray(newDigits);

            int sum = 0;
            foreach (int digit in digits)//форич перебирает все числы массива
                sum += digit;//каждый раз +1 цифра
            Console.WriteLine($"\nСумма цифр по модулю 10: {sum % 10}");//с нов строки по мод 10

            int[] swap = digits.ToArray();//снова создаем копию
            for (int i = 0; i < swap.Length - 1; i += 2)//берем 0,2,4,6..для дальнейшего обмена
            {
                (swap[i], swap[i + 1]) = (swap[i + 1], swap[i]);//меняю
            }
            Console.WriteLine("\nПосле обмена соседних элементов:");//с нов строчки вывела
            PrintIntArray(swap);
            Console.WriteLine("\nИсходный массив:");
            PrintIntArray(digits);
        }

        static void PrintIntArray(int[] array)
        {
            foreach (var item in array)
                Console.Write($"{item}, ");

            Console.WriteLine("\b\b.\n");
        }
    }
}
