using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double d = (b * b) - (4 * a * c);
        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (d == 0)
        {
            double x1 = -b / (2 * a);
            double x2 = -b / (2 * a);
            Console.WriteLine("{0:0.00}", x1);
        }
        else
        {
            double x1 = (-b - (Math.Sqrt(d))) / (2 * a);
            double x2 = (-b + (Math.Sqrt(d))) / (2 * a);
            Console.WriteLine("{0:0.00}", Math.Min(x1,x2));
            Console.WriteLine("{0:0.00}", Math.Max(x1,x2));
        }
    }
}

