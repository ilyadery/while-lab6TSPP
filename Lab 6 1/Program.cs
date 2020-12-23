using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double xn, xk, dx;
            double x;
            double y = 0;
            String Str;
            Console.Title = "Оператор While";
            Console.Write("Введите начальное значение диапазона в градусах: ");
            Str = Console.ReadLine();
            xn = Convert.ToDouble(Str);
            Console.Write("Введите конечное значение диапазона в градусах: ");
            Str = Console.ReadLine();
            xk = Convert.ToDouble(Str);
            Console.Write("Введите значение шага: ");
            Str = Console.ReadLine();
            dx = Convert.ToDouble(Str);
            x = xn;
            while (x <= xk)
            {
                if (x < -1)
                {
                    y = ((Math.Sqrt(1 + Math.Abs(x))) / 1 - x) + (Math.Sin((x + 1) / 4));
                }
                else if (x >= -1)
                {
                    y = ((Math.Sqrt(1 + Math.Abs(x))) / (1 - x)) + (1 - Math.Cos(8 / (2 * x + 3)));
                }
                Str = y.ToString("f2");
                Console.WriteLine("При значении х = {0}  y = {1}", x, Str);
                x = x + dx;    
            }

        }
    }
}

