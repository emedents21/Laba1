using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class Tabulation
    {
        public double[,] xy = new double[1000, 2];

        public int n = 0;

        private double f1(double x)
        {
            if (x == 0)
            {
                return 0; 
            }

            double result = (Math.Exp(x) * Math.Log(Math.Abs(x))) / (1 / Math.Tan(3 * x - 1) * 1 / Math.Tan(3 * x - 1));
            return result;
        }
        private double f2(double x)
        {
            double result = 5 / Math.Tan(2 * x + 3) + 1;
            return result;

        }

        private double f3(double x)
        {
            double numerator = Math.Pow(3 * x - 1, 2);
            double denominator = Math.Pow(x, 5);
            double firstTerm = numerator / denominator;
            double secondTerm = Math.Pow(Math.Sin(x + 2), 3);
            double result = firstTerm + secondTerm;

            return result;

        }


        public void tab(double xn = -5.2, double xk = 11.7, double h = 0.5, double a = 0.8)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
