using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Part6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество групп (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество студентов в группе (m): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите количество экзаменов (k): ");
            int k = int.Parse(Console.ReadLine());

            int bestGroup = 1;//начинаем с 1 группы
            double bestScore = 0;//дабл потому что средний балл будет дробным

            for (int group = 1; group <= n; group++)//обработка всех групп начин с 1
            {
                Console.WriteLine($"Ввод данных для группы {group}:");//вводим для текущей группы
                double groupSum = 0;//обнуляем для кажд нов группы

                for (int student = 0; student < m; student++)
                {
                    Console.Write($"Введите оценки для {student + 1} студента. Количество экзаменов: {k}.");

                    for (int exam = 1; exam <= k; exam++)
                    {
                        Console.Write($"\nОценка за экзамен {exam}: ");
                        int score = int.Parse(Console.ReadLine());
                        if (score < 0 || score > 100)
                        {
                            Console.WriteLine("Оценка должна быть от 0 до 100.");
                            return;
                        }
                        groupSum += score;//добавл оценки к общей сумме группы
                    }
                }
                double groupScore = groupSum / (m * k);
                Console.WriteLine($"Средний балл группы {group}: {groupScore}");
                if (groupScore > bestScore)
                {
                    bestScore = groupScore;//обновл лучш балл
                    bestGroup = group;//обновл лучш группу
                }


            }
            Console.WriteLine($"Лучшая группа по среднему баллу: группа {bestGroup} (средний балл: {bestScore})");

        }

    }

}

