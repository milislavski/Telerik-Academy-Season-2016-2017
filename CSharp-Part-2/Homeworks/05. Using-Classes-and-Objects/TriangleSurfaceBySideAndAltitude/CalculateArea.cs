using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceBySideAndAltitude
{
    class CalculateArea
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());

            var result = CalculateTriangleArea(side, altitude);
           
            Console.WriteLine("{0:0.00}",result);
        }

        static double CalculateTriangleArea(double side, double altitude)
        {
            double area = (side * altitude) / 2;
            return area;
        }
    }
}
