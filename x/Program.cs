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
            int a = 1;
            //Создать вещественную переменную и присвоить ей любое значение
            double b = 2;
            //Создать не явно типизированную переменную и присвоить ей любое значение
            var c = 3;
            // Вывести на консоль все переменные в строчку 1 методом
            Console.WriteLine($" {a} {b} {c}");
            Console.ReadKey();
           
        }
    }
}
