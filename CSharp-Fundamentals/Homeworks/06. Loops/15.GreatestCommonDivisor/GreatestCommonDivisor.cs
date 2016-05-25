using System;

class GreatestCommonDivisor
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        do
        {
            a = Math.Abs(a - b);
            if (a != b)
            {
                b = Math.Abs(b - a);
            }
        }
        while (b != a);
        Console.WriteLine(a);
    }
}
