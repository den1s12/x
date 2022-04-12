using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать целочисленную переменную и присвоить ей значение 1
            int a = 5;
            //Создать вещественную переменную и присвоить ей любое значение
            double b = 2;
            //Создать не явно типизированную переменную и присвоить ей любое значение
            var c = 3;
            // Вывести на консоль все переменные в строчку 1 методом
            Console.WriteLine($" {a} {b} {c}");
            //Возвести в квадрат целочисленную переменную и вывести результат на консоль
            a = a * a;
            Console.WriteLine(a);
            //Найти остаток от деления 12 на 4 и вывести на консоль
            Console.WriteLine(12 % 4);
            //Принять с консоли 3 числа и перемножить их, результат вывести на консоль
            Console.WriteLine("Введите переменные v, n, g");
            int v = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(v * n * g);
            //Принять с консоли 2 числа и найти большее из них
            Console.WriteLine("Введите переменные m, h");
            double m = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            if (m > 0)
            {
                Console.WriteLine("{0} Наибольшее число", m);
            }
            else
            {
                Console.WriteLine("{0} Наибольшее число", h);
            }
            Console.ReadLine();
        }
    }
}
