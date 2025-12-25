using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;//m-кол-во строк; n-кол-во столбцов

            while (true)
            {
                Console.WriteLine("Введите через пробел два натуральных числа n и m от 5 до 20");
                Console.WriteLine("(Enter - отказ от ввода)");
                var input = Console.ReadLine();

                if (input == string.Empty)//это если пользователь вввел пустую строку
                    return;

                var strings = input.Split();//разбиваем строку и превращаем в массив

                if (strings.Length == 2 && int.TryParse(strings[0], out m) &&
                    int.TryParse(strings[1], out n) && 5 <= m && m <= 20 &&
                    5 <= n && n <= 20)//проверка что введены два числа и равны от 5 до 20
                    break;
                else
                {
                    Console.WriteLine("Ошибка ввода");
                    continue;
                }
            }

            var matrix = new int[m, n];//создаем двумерный массив
            var rnd = new Random();//тут будет генератор случайных чисел

            for (int i = 0; i < matrix.GetLength(0); i++)//проходимся по всем строкам i
                for (int j = 0; j < matrix.GetLength(1); j++)//проходим по всем столбцам
                    matrix[i, j] = rnd.Next(0, 100);//заполняем каждую ячейку числом от 0 до 100

            Console.WriteLine();
            PrintTable(matrix);//метод для вывода массива на экран
            Console.WriteLine();

            Console.Write("\nВведите число для поиска: ");//с нов строки (\n) 
            int searchNumber;//число с которым будем сравнивать
            while (!int.TryParse(Console.ReadLine(), out searchNumber))
                Console.Write("Ошибка! Введите число.");

            var (row, col) = FindElementGreaterThan(matrix, searchNumber);//метод будет возвращать строку и столбец

            if (row != -1) // индекса -1 в массиве не существует, т.е не будет результата
            {
                int value = matrix[row, col];//выводим значение из массива
                Console.WriteLine($"Найден элемент {value} > {searchNumber} ; строка {row}, столбец {col}");
            }
            else
            {
                Console.WriteLine($"Элементов больше {searchNumber} не найдено");
            }

            
            Console.WriteLine("\nСреднее арифметическое по столбцам:");
            PrintColumnAverages(matrix);
        }

        static void PrintTable(int[,] table)//метод для вывода массива на экран, запятая для разделения измерений двумер массива
        {
            for (int i = 0; i < table.GetLength(0); i++)//идем по всем строкам массива
            {
                for (int j = 0; j < table.GetLength(1); j++)//идем по столбцам строки
                    Console.Write($"{table[i, j],2} ");//вывод элемента с отступом 2 симв
                Console.WriteLine();
            }
        }

        
        static (int row, int col) FindElementGreaterThan(int[,] table, int n)//метод для поиска большего числа
        {
            for (int i = 0; i < table.GetLength(0); i++)//по строк
                for (int j = 0; j < table.GetLength(1); j++)//по столб
                    if (table[i, j] > n)//если текущий элемент больше заданного, в n передано значение searchNumber
                        return (i, j);//возвращ  координаты
            return (-1, -1);//если ничего не нашли, то возвращ пустоту
        }

        static void PrintColumnAverages(int[,] table)//для вычисления ср арифмет
        {
            int rows = table.GetLength(0);//первое измерение - строки
            int cols = table.GetLength(1);//второе измерение - столбцы

            for (int col = 0; col < cols; col++)//идем по всем столбцам массива
            {
                double sum = 0;//тут сумму храним
                for (int row = 0; row < rows; row++)//по всем строкам столбца
                    sum += table[row, col];
                Console.WriteLine($"Столбец {col}: {sum / rows}");
            }
        }
    }
}
