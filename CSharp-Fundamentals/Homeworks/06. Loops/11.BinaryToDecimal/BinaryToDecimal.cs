using System;

class BinaryToDecimal
{
    static void Main()
    {
        string numberToBinary = Console.ReadLine().Trim();
        double number = 0;
        double power = 0;

        for (int i = numberToBinary.Length - 1; i >= 0; i--)
        {
            number += (numberToBinary[i] - '0') * Math.Pow(2, power);
            power++;
        }

        Console.WriteLine(number);
    }
}

