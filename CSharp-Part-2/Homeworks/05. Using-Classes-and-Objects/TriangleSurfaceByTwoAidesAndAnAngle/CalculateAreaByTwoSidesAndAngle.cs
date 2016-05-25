using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceByTwoAidesAndAnAngle
{
    class CalculateAreaByTwoSidesAndAngle
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angleInDegrees = double.Parse(Console.ReadLine());

            var result = CalculateTriagleArea(sideA, sideB, angleInDegrees);
            Console.WriteLine("{0:0.00}",result);
        }

        static double CalculateTriagleArea(double sideA,double sideB,double degrees)
        {
            double radians = (degrees * Math.PI) / 180;

            double sine = Math.Sin(radians);
            double area = (sideA * sideB * sine) / 2;

            return area;
        }
    }
}
