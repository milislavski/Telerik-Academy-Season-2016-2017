using System;

class ComparingFloats
{
    static void Main()
    {
        double firstDouble = double.Parse(Console.ReadLine());
        double secondDouble = double.Parse(Console.ReadLine());
        bool isEqual = Math.Abs(firstDouble - secondDouble) < 0.000001;
        if (isEqual)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

