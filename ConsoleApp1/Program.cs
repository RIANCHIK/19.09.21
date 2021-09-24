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
            Console.WriteLine("Введите а= ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c= ");
            double c = double.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * (a * c);

            double x1 = -b + Math.Sqrt(D) / 2 * a;
            double x2 = -b - Math.Sqrt(D) / 2 * a;

            if (D < 0)
            {
                Console.WriteLine("Нету корней");

            }
            else
            {
                if (D == 0)
                {
                    Console.WriteLine(x1);
                }
                else
                {
                    Console.WriteLine($"Корень первый будет равен {x1} | Корень второго равен {x2}");
                }
            }

            Console.ReadKey();
        }

    }
}
