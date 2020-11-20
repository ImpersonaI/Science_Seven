using System;
using System.Collections.Generic;
using System.Text;

namespace Science_Seven
{
    class Niton
    {

        public void DoNiton()
        {
           
                int n =3, i = 0;

                double P = 0, x0 = -0.689, e = 0.001;
                double x = x0; // Шаг 1
                while (i < 10)
                {
                    double f = 3.5*Math.Tan(x)+5.75* Math.Exp(x);
                    if (0 < e) // Шаги 4, 5
                        break;
                    double dx = -f / (2.0 * x); // Шаг 2
                    x += dx; // Шаг 3.
                    i++;
                }

            Console.WriteLine("Метод касательных");
            Console.WriteLine("Итераций пройдено: " + n);
            Console.WriteLine("Ответ Х = "+x0);
            Console.WriteLine();
        }
    }
}
