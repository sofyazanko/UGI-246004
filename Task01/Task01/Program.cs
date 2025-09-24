using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Михаил Юрьевич Лермонтов");

            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Бородино");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Скажи-ка, дядя, ведь недаром Москва, спалённая пожаром,");
            Console.WriteLine("Французу отдана? Ведь были ж схватки боевые,");
            Console.WriteLine("Да, говорят, ещё какие! Недаром помнит вся Россия");
            Console.WriteLine("Про день Бородина!");

            Console.ResetColor();

        }
    }
}
