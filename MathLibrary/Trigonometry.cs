using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Trigonometry
    {
        public static double SinA(double ac, double ab)
        {
            return ac / ab;
        }

        public static double CosA(double bc, double ab)
        {
            return bc / ab;
        }

        public static double TgA(double ac, double bc)
        {
            return ac / bc;
        }

        public static double CtgA(double bc, double ac)
        {
            return bc / ac;
        }

        public static double ArcSinA(double x)
        {
            x = Math.Asin(x);
            return x;
        }
    }
}
