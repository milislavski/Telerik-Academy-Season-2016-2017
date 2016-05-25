using System;

class ThirdBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string numberToBinary = Convert.ToString(number, 2).PadLeft(32, '0');
        int len = numberToBinary.Length;
        var thirdBit = numberToBinary[len - 4];
        Console.WriteLine(thirdBit);
    }
}