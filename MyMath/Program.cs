using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace MyMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Геометрия--\n");
            //Площадь треугольника
            Console.WriteLine("Площадь треугольника = " + Geometry.STriangle(2,4));

            //Площадь прямоугольного треугольника
            Console.WriteLine("Площадь прямоугольного треугольника = " + Geometry.SRTriangle(5, 5));

            //Площадь прямоугольника
            Console.WriteLine("Площадь прямоугольника = " + Geometry.SRectangle(3, 6));

            //Площадь круга
            Console.WriteLine("Площадь круга = " + Geometry.SCircle(6));

            //Площадь трапеции
            Console.WriteLine("Площадь прямоугольника = " + Geometry.STrapeze(4, 6, 8) + "\n");


            Console.WriteLine("--Алгебра--\n");
            Console.WriteLine(Algebra.SquareEquation(1, -1, -2));
        }
    }
}
