using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1: ");                    //////////////////////////Ззадача 1
            double e = Math.E;
            double e1 = Math.Round(e, 1);
            Console.WriteLine(e1);

            Console.WriteLine("Задача 2: ");                        /////////////////////////////Задача 2
            Console.WriteLine(50);
            Console.WriteLine(10);


            Console.WriteLine("Задача 4: ");                        //////////////////////////Ззадача 4
            Console.WriteLine("Введите число: ");
            double number1 = double.Parse(Console.ReadLine());
            double number2 = number1 + 10;
            Console.WriteLine(number2);

            Console.WriteLine("Задача 5: ");                        //////////////////////////Ззадача 5

            double storona = double.Parse(Console.ReadLine());
            double perimetr = storona * 4;
            Console.WriteLine(perimetr);

            Console.WriteLine("Задача 6: ");                        //////////////////////////Ззадача 6
            Console.WriteLine("Введите радиус: ");
            double radious = double.Parse(Console.ReadLine());
            double lenght = 2 * radious * Math.PI;
            double square = radious * radious * Math.PI;
            Console.WriteLine("Длина: " + lenght);
            Console.WriteLine("Площадь" + square);

            Console.WriteLine("Задача 7: ");                        //////////////////////////Ззадача 7
            Console.WriteLine("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            double y = Math.Cos(x);
            Console.WriteLine("cos(x) = " + y);

            Console.WriteLine("Задача 8: ");                            //////////////////////////Ззадача 8
            Console.WriteLine("Введите основание 1 : ");
            double base1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите основание 2 : ");
            double base2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту : ");
            double heigh = double.Parse(Console.ReadLine());
            double Square1 = (base1 + base2) / 2 * heigh;
            Console.WriteLine("Площадь трапеции: " + Square1);

            Console.WriteLine("Задача 9: ");                //////////////////////////Ззадача 9
            Console.WriteLine("Сколько стоит кг конфет?: ");
            double price1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Сколько стоит кг печенья?: ");
            double price2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Сколько стоит кг яблок?: ");
            double price3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Сколько кг конфет купили?: ");
            double m1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Сколько кг печенья купили?: ");
            double m2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Сколько кг яблок купили?: ");
            double m3 = double.Parse(Console.ReadLine());
            price1 = (m1 * price1) + (m2 * price2) + (m3 * price3);
            Console.WriteLine("общая цена: " + price1);

            Console.WriteLine("Задача 10: ");                           //////////////////////////Ззадача 10
            Console.Write("Мир ");
            Console.Write("Труд ");
            Console.WriteLine("Май ");
            Console.WriteLine("Мир ");
            Console.WriteLine("     Труд");
            Console.WriteLine("             Май");



            Console.WriteLine("Задача 11: ");     //////////////////////////Ззадача 11
            Console.WriteLine("Введите объект 1: ");
            object o1 = Console.ReadLine();
            Console.WriteLine("Введите объект 2: ");
            object o2 = Console.ReadLine();
            Console.WriteLine(02);
            Console.WriteLine(o1);

            Console.WriteLine("Задача 12: "); ////////////Задача 12
            Console.WriteLine("Какая фигура? ");
            string figure = Console.ReadLine();
            if (figure == "треугольник")
            {
                Console.WriteLine("что найти? ");
                string value1 = Console.ReadLine();

                if (value1 == "периметр")
                {
                    Console.WriteLine("Введите сторону 1: ");
                    double triangle1p = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите сторону 2: ");
                    double triangle2p = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите сторону 3: ");
                    double triangle3p = double.Parse(Console.ReadLine());
                    double trianglep = triangle1p + triangle2p + triangle3p;
                    Console.WriteLine("Периметр треугольника: " + trianglep);
                }
                if (value1 == "площадь")
                {
                    Console.WriteLine("Введите сторону 1: ");
                    double triangle1s = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите сторону 2: ");
                    double triangle2s = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите сторону 3: ");
                    double triangle3s = double.Parse(Console.ReadLine());
                    double p = triangle1s + triangle2s + triangle3s;
                    double triangles = Math.Sqrt(p / 2 * (p / 2 - triangle1s) * (p / 2 - triangle2s) * (p / 2 - triangle3s));
                    Console.WriteLine("Площадь треугольника: " + triangles);
                }
            }
            if (figure == "четырехугольник")
            {
                Console.WriteLine("что найти? ");
                string value2 = Console.ReadLine();
                if (value2 == "периметр")
                {
                    Console.WriteLine("Введите сторону 1: ");
                    double sq1p = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите сторону 2: ");
                    double sq2p = double.Parse(Console.ReadLine());
                    double sqp = (sq1p + sq2p) * 2;
                    Console.WriteLine("Периметр четырехугольника: " + sqp);
                }
                if (value2 == "площадь")
                {
                    Console.WriteLine("Введите сторону 1: ");
                    double sq1s = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите сторону 2: ");
                    double sq2s = double.Parse(Console.ReadLine());
                    double sqs = sq1s * sq2s;
                    Console.WriteLine("Площадь четырехугольника: " + sqs);
                }
                if (figure == "круг")
                {
                    Console.WriteLine("Введите радиус: ");
                    double rad = double.Parse(Console.ReadLine());
                    Console.WriteLine("что найти? ");
                    string valuek = Console.ReadLine();
                    if (valuek == "длина")
                    {
                        double lenght12 = 2 * rad * Math.PI;
                        Console.WriteLine("Длина круга: " + lenght12);
                    }
                    if (valuek == "площадь")
                    {
                        double krs = rad * rad * Math.PI;
                        Console.WriteLine("Площадь круга: " + krs);
                    }

                }



                Console.WriteLine("Задача 13: "); /////////////////////////////////////////////////Задача 13
                Console.WriteLine("Введите число: ");
                double number3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Вы ввели число: " + number3);

                Console.WriteLine("Задача 14: "); /////////////////////////////////////////////////Задача 14
                Console.WriteLine("2 кг");
                Console.WriteLine("13 17");

                Console.WriteLine("Задача 15: "); /////////////////////////////////////////////////Задача 15
                Random rnd = new Random();
                int value1 = rnd.Next();
                Console.WriteLine(value1);
                int value212 = rnd.Next();
                Console.WriteLine(value212);
                int value3 = rnd.Next();
                Console.WriteLine(value3);
                int value4 = rnd.Next();
                Console.WriteLine(value4);


                Console.WriteLine("Задача 16: "); /////////////////////////////////////////////////Задача 16
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
                        double x0 = -(b) / 2 / a;
                        Console.WriteLine(-b);
                        Console.WriteLine(x0);
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
                Console.WriteLine("Задача 17: "); /////////////////////////////////////////////////Задача 17
                Console.WriteLine("Введите целое число 1: ");
                double number01 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите целое число 2: ");
                double number02 = int.Parse(Console.ReadLine());
                double srar = (number01 + number02) / 2;
                Console.WriteLine("Среднее арифмитическое: " + srar);
                double srgeom = Math.Sqrt(number01 * number02);
                Console.WriteLine("Среднее геометрическое: " + srgeom);


                Console.WriteLine("Задача 19: "); /////////////////////////////////////////////////Задача 19
                Console.WriteLine("Введите a: ");
                object a11 = Console.ReadLine();
                Console.WriteLine("Введите b: ");
                object b11 = Console.ReadLine();
                Console.WriteLine("Введите c: ");
                object c11 = Console.ReadLine();
                object d11 = a11;
                object e11 = b11;
                b11 = c11;
                a11 = e11;
                c11 = a11;
                Console.WriteLine(a11);
                Console.WriteLine(b11);
                Console.WriteLine(c11);

                Console.WriteLine("Задача 20: "); /////////////////////////////////////////////////Задача 20
                Console.WriteLine("Сколько секунд прошло с начала суток? ");
                int sek = int.Parse(Console.ReadLine());
                int chasov = sek / 3600; //a)
                int minut = (sek - (chasov * 3600)) / 60;
                int sekund = sek % 60;
                Console.WriteLine("часов " + chasov);
                Console.WriteLine("минут " + minut);
                Console.WriteLine("секунд " + sekund);

                Console.WriteLine("Задача 21: "); /////////////////////////////////////////////////Задача 21
                int k = 0;
                int a21 = 543;
                int b21 = 130;
                while (a21 >= 0)
                {
                    a21 = a21 - b21;
                    k = k + 1;
                }
                Console.WriteLine(k);

                Console.WriteLine("Задача 22: "); /////////////////////////////////////////////////Задача 22
                Console.WriteLine("Введите число: ");
                int z = int.Parse(Console.ReadLine());
                int z1 = z % 10;
                int z2 = z / 10;
                int z3 = z1 * 100 + z2;
                Console.WriteLine(z3);

                Console.WriteLine("Задача 23: "); /////////////////////////////////////////////////Задача 23
                Console.WriteLine("Введите число: ");
                int chislo23 = int.Parse(Console.ReadLine());
                int soten = chislo23 / 100;
                int tis = chislo23 / 1000;
                Console.WriteLine(soten);
                Console.WriteLine(tis);


                Console.WriteLine("Задача 25: "); /////////////////////////////////////////////////Задача 25
                Console.WriteLine("Введите число: ");
                int chislo25 = int.Parse(Console.ReadLine());
                int chsilo251 = chislo25 % 10;
                int chislo252 = chislo25 - chsilo251;

                Console.WriteLine("Задача 28: "); /////////////////////////////////////////////////Задача 28
                Console.WriteLine("Введите число 1: ");
                int chislo281 = Math.Abs(int.Parse(Console.ReadLine()));
                Console.WriteLine("Введите число 2: ");
                int chislo282 = Math.Abs(int.Parse(Console.ReadLine()));
                Console.WriteLine("Введите число 3: ");
                int chislo283 = Math.Abs(int.Parse(Console.ReadLine()));
                int chislo284 = Math.Min(chislo281, chislo282);
                int chislo285 = Math.Min(chislo281, chislo283);
                int chislo28 = Math.Min(chislo284, chislo285);
                Console.WriteLine(chislo28);

                Console.WriteLine("Задача 29: "); /////////////////////////////////////////////////Задача 29
                Console.WriteLine("Введите число 1: ");
                int chislo291 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число 2: ");
                int chislo292 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число 3: ");
                int chislo293 = int.Parse(Console.ReadLine());
                int chislo294 = Math.Max(chislo291, chislo292);
                int chislo295 = Math.Max(chislo291, chislo293);
                int chislo29max = Math.Max(chislo294, chislo295);
                int chislo296 = Math.Min(chislo291, chislo293);
                int chislo297 = Math.Min(chislo291, chislo293);
                int chislo29min = Math.Min(chislo296, chislo297);
                int chislo29 = chislo29max + chislo29min;

                Console.WriteLine("Задача 30: "); /////////////////////////////////////////////////Задача 30
                int k30 = 2;
                int chislo30 = int.Parse(Console.ReadLine());
                for (int i = 2; i < Math.Sqrt(chislo30); i++)
                {
                    if (chislo30 % i == 0)
                    {
                        k30 = k30 + 2;
                    }
                    if (i == Math.Sqrt(chislo30))
                    {
                        k30++;
                    }
                }
                Console.WriteLine(k30);



                Console.WriteLine("Задание 32"); //////////////////////////////////////////////////Задача 32
                Console.WriteLine("Введите первый элемент последовательности: ");
                double chislo321 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второй элемент последовательности: ");
                double chislo322 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер элемента последовательности: ");
                double chislo323 = double.Parse(Console.ReadLine());
                double chislo32 = chislo321 + ((chislo322 - chislo321) * (chislo323 - 1));
                Console.WriteLine(chislo32);

                Console.WriteLine("Задание 32"); //////////////////////////////////////////////////Задача 34
                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();
                Console.WriteLine("a)" + name);
                Console.WriteLine("б)Привет " + name);



















            }
        }
    }
}
