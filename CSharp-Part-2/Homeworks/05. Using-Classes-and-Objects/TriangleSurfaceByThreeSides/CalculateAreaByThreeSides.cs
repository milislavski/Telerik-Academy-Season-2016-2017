using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceByThreeSides
{
    class CalculateAreaByThreeSides
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            var result = CalculateTriangleArea(sideA, sideB, sideC);            
            Console.WriteLine("{0:0.00}",result);
        }

        static double CalculateTriangleArea(double sideA,double sideB, double sideC)
        {
            double p = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return area;
        }
    }
}
