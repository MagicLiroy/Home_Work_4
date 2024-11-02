using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            int negativeNumber = 0, positiveNumber = 0;

           

            do
            {
                Console.Write("Введите целое число: ");
                number = int.Parse(Console.ReadLine());

                if (number >= 0)
                {
                    positiveNumber += 1;
                }
                else
                {
                    negativeNumber += 1;
                }
            }
            while (number != 0);

            if (positiveNumber > negativeNumber)
            {
                Console.WriteLine("Количество положительных чисел больше отрицательных");
            }
           else if(positiveNumber < negativeNumber)
            {
                Console.WriteLine("Количество отрицательных чисел больше положительных");
            }
           else if (positiveNumber == negativeNumber)

                Console.WriteLine("Количество отрицательных чисел равно положительным");


            Console.ReadKey();
        }
    }
}
