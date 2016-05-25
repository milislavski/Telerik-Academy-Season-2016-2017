using System;

class MoonGravity
{
    static void Main()
    {
        double weightOnTheEarth = double.Parse(Console.ReadLine());
        double moonWeight = (weightOnTheEarth * 17) / 100;
        Console.WriteLine("{0:F3}", moonWeight);
    }
}
