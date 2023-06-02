using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Geometry
    {
        public static double STriangle( double a, double h)
        {
            return 0.5 * a * h;
        }

        public static double SRTriangle(double a, double b)
        {
            return 0.5 * a * b;
        }

        public static double SRectangle(double a, double b)
        {
            return a * b;
        }

        public static double SCircle(double r)
        {
            return 3.14 * (r * r);
        }

        public static double STrapeze(double a, double b, double h)
        {
            return ((a + b) / 2) * h;
        }
    }
}
