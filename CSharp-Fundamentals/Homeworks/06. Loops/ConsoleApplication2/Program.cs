using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double resultX = 1;
            double factorialN = 1;
            double s = 0;

            for (long i = 1; i <= n; i++)
            {
                factorialN = factorialN * (i);
                resultX = Math.Pow(x, i);
                s += (factorialN / resultX);
            }

            Console.WriteLine("{0:0.00000}", s + 1);
            Console.ReadLine();
        }

    }
}