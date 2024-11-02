using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int value = int.Parse(Console.ReadLine());

            int squeareElement;

            string rowSqueare;

            for (int i = 1; i <= value; i++)
            {
                int square = 0;

                for (int j = 1; j <= i; j++)
                {
                    squeareElement = (2 * j - 1);
                    
                    square += squeareElement;
                }

                rowSqueare = $"{square} ";
                Console.Write(rowSqueare);
            }
            Console.ReadKey();
        }
    }
}
