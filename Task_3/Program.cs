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
            float lenght = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника: ");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение сторон квадрата прямоугольника: ");
            float sideSquare = float.Parse(Console.ReadLine());

            if (sideSquare >= width || sideSquare >= lenght)
            {
                float squareRectangle = 0;

                while (width > 0)
                {
                    squareRectangle += lenght;
                    width -= 1;
                }

                float areaSquare = 0;

                float squareAreaCounter = sideSquare;

                while (squareAreaCounter > 0)
                {
                    areaSquare += sideSquare;
                    squareAreaCounter -= 1;
                }

                int counterSquares = 0;
                float occupiedArea = squareRectangle;

                while (occupiedArea >= areaSquare)
                {
                    occupiedArea -= areaSquare;
                    counterSquares += 1;
                }

                Console.WriteLine($"Количество квадратов, которое поместиться в прямоугольник: {counterSquares}");

            }
            else { Console.WriteLine("Квадрат не поместиться в прямоугольник"); }

            Console.ReadKey();
            
        }
    }
}
