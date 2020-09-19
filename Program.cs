using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_csharp_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Ctriangle ctriangle = new Ctriangle(); // Создаем обьект класса

            Console.WriteLine("Введите длину 1-й стороны:");
            double.TryParse(Console.ReadLine(), out double side1); // Вводим длину стороны

            Console.WriteLine("Введите длину 2-й стороны:");
            double.TryParse(Console.ReadLine(), out double side2); // Вводим длину стороны

            Console.WriteLine("Введите длину 3-й стороны:");
            double.TryParse(Console.ReadLine(), out double side3); // Вводим длину стороны

            Console.WriteLine();

            if (!ctriangle.isCtriangle(side1, side2, side3)) // Проверка на существование треугольника
            {
                Console.WriteLine("Треугольник с такими сторонами не существует!");
                return;
            }

            Console.WriteLine();

            ctriangle.PrintCtriangle(side1, side2, side3); // Выводим информацию о треугольнике(углы , площадь , периметр)

            Console.WriteLine();

            Console.WriteLine("Введите колличество треугольников:");
            int.TryParse(Console.ReadLine(), out int numctr); // Вводим количество треугольников 

            Ctriangles ctriangles = new Ctriangles(numctr); // Создаем обьект класса и передаем количество, которое ввели

            Console.WriteLine();

            ctriangles.PrintCtriangles(); // Выводим информацию о треугольниках

            Console.WriteLine();

            Console.WriteLine("Среднее значение площади этих треугольников равно:" + ctriangles.findMiddleSquare()); // Вычисляем и выводим среднее заначение площади


            Console.ReadLine();
        }
    }
}
