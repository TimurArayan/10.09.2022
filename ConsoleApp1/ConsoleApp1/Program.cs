using System;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace TooMuch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1 - имя");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет " + name);

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Задача 2 - деление");
            Console.WriteLine("Введите число 1: ");
            decimal number1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2: ");
            decimal number2 = decimal.Parse(Console.ReadLine());
            if (number2 != 0)
            {
                decimal quotient = number1 / number2;
                Console.WriteLine("Частное: " + quotient);
            }
            else
            { 
                Console.WriteLine("На 0 делить нельзя");
            }

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Задача 3 - буква");
            string letter0 = Console.ReadLine();
            char letter1 = letter0[0];
            letter1 = (char)(letter1 + 1);
            Console.WriteLine(letter1);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Задача 4 - уравнение");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = (b * b) - (4 * a * c);
            if (D < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else
            {
                if (D == 0)
                {
                    Console.WriteLine(D);
                    double x = -(b) / 2 / a;
                    Console.WriteLine(-b);
                    Console.WriteLine(x);
                }    
                else
                {
                    double root = Math.Sqrt(D);
                    double x1 = (-(b) + root) / 2 / a;
                    double x2 = (-(b) + root) / 2 / a;
                    Console.WriteLine(x1);
                    Console.WriteLine(x2);

                }
            }
            


        }
    }
}