using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = "Введите первую координату";
            var y = "Введите вторую координату";

            Console.WriteLine("Точка("+x+","+y+")");

            
        }

        static int InputInteger(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());  
        }
    }
}
