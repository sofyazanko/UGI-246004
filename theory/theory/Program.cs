using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theory
{
    internal class Program
    {
        static void Main(string[] args)
        {//про переменные
        //    int maxNumber = 10;
        //    x += 2;
        //    //явная типизация
        //    int age = 25;//явно указан тип int
        //    string name = "Анна";//явно указан тип string
        //    double price = 99.99;//явно указан тип double
        //    bool isActive = true;//явно указан тип bool
        //    char grade = 'A';//явно указан тип char
        //    Console.WriteLine($"int age = {age}");
        //    Console.WriteLine($"double price = {price}");
        //    Console.WriteLine($"bool isActive = {isActive}");
        //    Console.WriteLine($"char grade = '{grade}'");
        //    int x, y, z;//объявление без инициализации
        //    int a = 1, b = 2, c = 3;//объявление с инициализацией
        ////неявная типизация
        //    var number = 10;//компилятор определяет как int
        //    var name = "Анна";//определяет как string
        //    var price = 99.99;//определяет как double
        //    var isActive = true;//определяет как bool
        //    var a = 10, b = 20, c = 30;//будет ОШИБКА var только с одним значение работает
        //    var x = y = z = 100;//можно одно значение
        //    //можно присвоить по отдельности 
        //    var a = 10;//int
        //    var b = 20;//int  
        //    var c = 30;//int
        ////явная конверсия
        //    double price = 99.99;//принудительно отбрасываем 0,99
        //    int intPrice = (int)price;
        //    long bigNumber = 3000000000;
        //    int smallNumber = (int)bigNumber;//в результате будет неправильное значение 
        //    int code = 97;
        //    char letter = (char)code; //явное преобразование int  в char. letter = 'a'

        //неявная конверсия
            byte red = 200;//красный канал пикселя(потому что диапазон знач от 0 до 255)
            byte green = 150;//зелёный канал
            byte blue = 100;//синий канал
            int brightness = (red + green + blue) / 3;
            Console.WriteLine($"Яркость пикселя: {brightness}");
        //перевод стороки в число (Parse доступен у всех числовых типов)
            //int number = int.Parse("123");// 123
            //double price = double.Parse("99.99");// 99.99
            
        }
    }
}
