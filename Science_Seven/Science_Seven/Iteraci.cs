using System;
using System.Collections.Generic;
using System.Text;

namespace Science_Seven
{
    class Iteraci
    {

        public void DoIteracii()
        {

            const double eps = 1e-4;
            double x0 = 0, x1 = 0, x2 = -0.8;
            int iter = 0;
            bool error = false;

            do
            {
                x1 = func(x0);
                iter++;
                if (Math.Abs(x1 - x0) >= eps && iter == 1000)
                {
                    error = true;
                    break;
                }
                x0 = x1;
            } while (Math.Abs(x0 - func(x0)) > eps);
            if (error)
            {
                Console.WriteLine("Не найдено");
            }
            else
            {
                Console.WriteLine("Метод простой итерации");
                Console.WriteLine("Ответ: X = {0} ", x2);
                Console.WriteLine("Итераций пройдено: {0}", iter);
                Console.WriteLine();
            }

            
        }

        public double func(double x)
        {
            double f = Math.Pow(x, 4) + 20 * Math.Pow(x, 3) + 60 * Math.Pow(x, 2) - 400 * x - 1250;
            return f;
        }
        
    }
}
