using System;
using System.Collections.Generic;
using System.Text;

namespace Science_Seven
{
    class Ditoh
    {
        //Console.WriteLine("Метод деления отрезка пополам");
        const double epsilon = 1e-2;

        double f(double x)
        {
            return 12.5 * Math.Pow(x, 3) - 7.5 * Math.Pow(x, 2) + 5 * x - 2.5;
        }

        public void DoDitoh()
        {
            double a, b, c;
            a = 0;
            b = 2;
            while (b - a > epsilon)
            {
                c = (a + b) / 2;
                if (f(b) * f(c) < 0)
                    a = c;
                else
                    b = c;
            }
            Console.WriteLine("Метод половинного деления");
            Console.WriteLine("x =" + (a + b));
            Console.WriteLine("f(x) = " + f(a + b));
            Console.WriteLine();
            
        }
    }
}
