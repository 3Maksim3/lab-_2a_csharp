using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_csharp_2a
{
    class Ctriangles
    {
        Ctriangle[] ctriangles; // Объявление массива обьектов
        internal Ctriangle[] Ctriangles_ { get => ctriangles; set => ctriangles = value; } // Свойства массива
        // Конструктор без параметров
        public Ctriangles() 
        {

        }
        // Конструктор заполняющий массив данными
        public Ctriangles(int N)
        {
            Ctriangles_ = new Ctriangle[N];
            Random random = new Random();

            for (int i = 0; i < Ctriangles_.Length; i++)
            {
                Ctriangles_[i] = new Ctriangle();
                Ctriangles_[i].Side1 = random.Next(10, 15);
                Ctriangles_[i].Side2 = random.Next(10, 15);
                Ctriangles_[i].Side3 = random.Next(2, 20);
            }
        }
        // Метод выводящий информацию об массиве
        public void PrintCtriangles()
        {
            int i = 1;
            foreach (Ctriangle ctriangle in Ctriangles_)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Ctriangle № " + i++ + " with Sides: " + ctriangle.Side1 + " ; " + ctriangle.Side2 + " ; " + ctriangle.Side3);
            }

        }
        // Метод находящий среднее арифметическое всех площадей
        public double findMiddleSquare()
        {
            double middle = 0;

            if (Ctriangles_.Length > 0)
                for (int i = 0; i < Ctriangles_.Length; i++)
                    middle += Ctriangles_[i].GetSquare(Ctriangles_[i].Side1, Ctriangles_[i].Side2, Ctriangles_[i].Side3);

            middle /= Ctriangles_.Length;

            return middle;
        }
    }
}
