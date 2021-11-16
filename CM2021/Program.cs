using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM2021
{
    class Program
    {
        static void TablitzaZnacenij()
        {
            double y;            
            double x = 2;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("x = " + x);
                y = 2 * Math.Cos(((5 * x) / 7));                
                Console.WriteLine("y = " + y);               
                x += 0.5;
            }
        }
        static void Pervaya(double q)
        {
            double y0 = 0.28349;
            double dy0 = 0.71002;
            double d2y0 = 0.05382;
            double d3y0 = 0.08273;
            double d4y0 = 0.01723;
            double d5y0 = 0.00825;
            double P = (y0) + (q * dy0) + (((q * (q - 1)) / 2) * d2y0) + (((q * (q - 1) * (q - 2)) / 6) * d3y0) + (((q * (q - 1) * (q - 2) * (q - 3)) / 24) * d4y0) + (((q * (q - 1) * (q - 2) * (q - 3) * (q - 4)) / 120) * d5y0);
            Console.WriteLine("P1 = " + P);
        }
        static void Vtoraya(double t)
        {
            double y = -1.99471;
            double dy4 = 0.07508;
            double d2y3 = 0.24227;
            double d3y2 = 0.04007;
            double d4y1 = 0.02548;
            double d5y0 = 0.00825;
            double P = (y) + (t * dy4) + (((t * (t + 1)) / 2) * d2y3) + (((t * (t + 1) * (t + 2)) / 6) * d3y2) + (((t * (t + 1) * (t + 2) * (t + 3)) / 24) * d4y1) + (((t * (t + 1) * (t + 2) * (t + 3) * (t + 4)) / 120) * d5y0);
            Console.WriteLine("P2 = " + P);
        }
        static void LaCringe(double[] y, double[] xlar, int x)
        {
            double c0 = y[0] / ((xlar[0] - xlar[1]) * (xlar[0] - xlar[2]) * (xlar[0] - xlar[3]) * (xlar[0] - xlar[4]) * (xlar[0] - xlar[5]));
            double c1 = y[1] / ((xlar[1] - xlar[0]) * (xlar[1] - xlar[2]) * (xlar[1] - xlar[3]) * (xlar[1] - xlar[4]) * (xlar[1] - xlar[5]));
            double c2 = y[2] / ((xlar[2] - xlar[0]) * (xlar[2] - xlar[1]) * (xlar[2] - xlar[3]) * (xlar[2] - xlar[4]) * (xlar[2] - xlar[5]));
            double c3 = y[3] / ((xlar[3] - xlar[0]) * (xlar[3] - xlar[1]) * (xlar[3] - xlar[2]) * (xlar[3] - xlar[4]) * (xlar[3] - xlar[5]));
            double c4 = y[4] / ((xlar[4] - xlar[0]) * (xlar[4] - xlar[1]) * (xlar[4] - xlar[2]) * (xlar[4] - xlar[3]) * (xlar[4] - xlar[5]));
            double c5 = y[5] / ((xlar[5] - xlar[0]) * (xlar[5] - xlar[1]) * (xlar[5] - xlar[2]) * (xlar[5] - xlar[3]) * (xlar[5] - xlar[4]));
            Console.WriteLine("c0 = " + c0 + "; c1 = " + c1 + "; c2 = " + c2 + "; c3 = " + c3 + "; c4 = " + c4 + "; c5 = " + c5);
            double L5X = (c0 * (x - xlar[1]) * (x - xlar[2]) * (x - xlar[3]) * (x - xlar[4]) * (x - xlar[5])) + (c1 * (x - xlar[0]) * (x - xlar[2]) * (x - xlar[3]) * (x - xlar[4]) * (x - xlar[5])) + (c2 * (x - xlar[0]) * (x - xlar[1]) * (x - xlar[3]) * (x - xlar[4]) * (x - xlar[5])) + (c3 * (x - xlar[0]) * (x - xlar[1]) * (x - xlar[2]) * (x - xlar[4]) * (x - xlar[5])) + (c4 * (x - xlar[0]) * (x - xlar[1]) * (x - xlar[2]) * (x - xlar[3]) * (x - xlar[5])) + (c5 * (x - xlar[0]) * (x - xlar[1]) * (x - xlar[2]) * (x - xlar[3]) * (x - xlar[4]));
            Console.WriteLine("а ответ крч = " + L5X);
        }
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            double otvet = 2 * Math.Cos((5 * x - 3)/7);
            double q = (x - 2) / 0.5;
            double t = (x - 4.5) / 0.5;
            Console.WriteLine("Ответ = " + otvet + "; q = " + q + "; t = " + t);
            double[] y = {0.28349, -0.42653, -1.08273, -1.60228, -1.91963, -1.99471};
            double[] dy0 = {0.71002, 0.6562, 0.51955, 0.31735, 0.07508};
            double[] xlar = {2, 2.5, 3, 3.5, 4, 4.5};
            while (true)
            {
                Console.WriteLine("0. Таблица Значений");
                Console.WriteLine("1. Первая интерполяционная формула Ньютона");
                Console.WriteLine("2. Вторая интерполяционная формула Ньютона");
                Console.WriteLine("3. Формула Лагранжа");
                Console.Write("Вращайте барабан - ");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case (0):
                        Console.WriteLine("Таблица Значений");
                        TablitzaZnacenij();
                        break;
                    case (1):
                        Console.WriteLine("Первая интерполяционная формула Ньютона");
                        Pervaya(q);
                        break;
                    case (2):
                        Console.WriteLine("Вторая интерполяционная формула Ньютона");
                        Vtoraya(t);
                        break;
                    case (3):
                        Console.WriteLine("Формула Лагранжа");
                        LaCringe(y, xlar, x);
                        break;
                }
            }
        }
    }
}
