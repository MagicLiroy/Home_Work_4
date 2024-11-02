using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника: ");
            int lenght = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение сторон квадрата прямоугольника: ");
            int side = int.Parse(Console.ReadLine());

            bool sizeComparison = lenght >= side && width >= side;

            int squareCounter = 0;

            int squares = 0;

            if (sizeComparison)
            {
                while (true)
                {
                    squares += side;

                    if (width + lenght - squares >= side)
                    {
                        squareCounter += 1;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine($"В прямоугольник поместиться квадратов: {squareCounter} ");
            }
            else
                {
                    Console.WriteLine("Квадрат не помещается в прямоугольик");
                }

            Console.ReadKey();
        }
    }
}
