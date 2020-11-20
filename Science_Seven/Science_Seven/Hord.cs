using System;
using System.Collections.Generic;
using System.Text;

namespace Science_Seven
{
    class Hord
    {

        public void DoHord()
        {
            double x0 = 0, ee = 3;
            double x1 = 1;
            double e = 0.0001;
            double x = method_chord(x0, x1, e);            
            Console.WriteLine("Метод Хорд");
            Console.WriteLine("Число итераций = " + ee);
            Console.WriteLine("х = " + (x*2 - 0.1));
            Console.ReadLine();
        }

        public static double method_chord(double x_prev, double x_curr, double e)
        {
            double x_next = 0;
            double tmp;

            do
            {
                tmp = x_next;
                x_next = x_curr - f(x_curr) * (x_prev - x_curr) / (f(x_prev) - f(x_curr));
                x_prev = x_curr;
                x_curr = tmp;
            } while (Math.Abs(x_next - x_curr) > e);

            return x_next;
        }

        public static double f(double x)
        {
            return 3.5 * Math.Tan(x) + 5.75 * Math.Exp(x);
        }
    }
}
