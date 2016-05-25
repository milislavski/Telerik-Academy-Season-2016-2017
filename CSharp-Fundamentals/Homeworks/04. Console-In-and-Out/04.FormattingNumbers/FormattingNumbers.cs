using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string aInHex = a.ToString("X");
        string bToBinary = Convert.ToString(a, 2);
        Console.WriteLine("{0,-10}|{1}|{2,10:0.00}|{3,-10:F3}|", aInHex, bToBinary.PadLeft(10, '0'), b, c);
    }
}
