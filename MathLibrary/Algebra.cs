using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Algebra
    {
        public static double[] SquareEquation(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                throw new ArithmeticException("Нет корней");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return new double[] { x1, x2 };
            }
        }
    }
}
