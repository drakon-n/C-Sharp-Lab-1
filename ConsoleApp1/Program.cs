using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = In();
            b = In();
            c = In();
            int d;
            d = (b * b) - 4 * a * c;
            if (d >= 0)
                {
                if (d != 0)
                {
                    double x1, x2;
                    x1 = ((-b - Math.Sqrt(d)) / 2 * a);
                    x2 = ((-b + Math.Sqrt(d)) / 2 * a);
                    Console.WriteLine($"Корни уравнения {x1} и {x2}");
                }
                else
                {
                    double x1;
                    x1 = (-b/ 2 * a);
                    Console.WriteLine($"Корень уравнения {x1}");
                }
                }
            else
                { Console.WriteLine("Корней нет"); }
            Console.ReadKey();

        }

        static int In()
        {
            while (true)
            {
                int i;
                if (int.TryParse(Console.ReadLine(), out i))
                    return i;
                else
                    Console.Write("Неверный ввод! Введите еще раз: ");
            }
        }
    }
}

