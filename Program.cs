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
            Ctriangle ctriangle = new Ctriangle();

            Console.WriteLine("Введите длину 1-й стороны:");
            double.TryParse(Console.ReadLine(), out double side1);

            Console.WriteLine("Введите длину 2-й стороны:");
            double.TryParse(Console.ReadLine(), out double side2);

            Console.WriteLine("Введите длину 3-й стороны:");
            double.TryParse(Console.ReadLine(), out double side3);

            Console.WriteLine();

            if (!ctriangle.isCtriangle(side1, side2, side3))
            {
                Console.WriteLine("Треугольник с такими сторонами не существует!");
                return;
            }

            Console.WriteLine();

            ctriangle.PrintCtriangle(side1, side2, side3);

            Console.WriteLine();

            Console.WriteLine("Введите колличество треугольников:");
            int.TryParse(Console.ReadLine(), out int numctr);

            Ctriangles ctriangles = new Ctriangles(numctr);

            Console.WriteLine();

            ctriangles.PrintCtriangles();

            Console.WriteLine();

            Console.WriteLine("Среднее значение площади этих треугольников равно:" + ctriangles.findMiddleSquare());


            Console.ReadLine();
        }
    }
}
