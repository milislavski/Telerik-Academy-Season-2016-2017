using System;

class PrrintSign
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        string sign = "";

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            sign = "0";
        }
        else if (((firstNumber > 0) && (secondNumber > 0) && (thirdNumber < 0)) ||
            ((firstNumber > 0) && (secondNumber < 0) && (thirdNumber > 0)) ||
            ((firstNumber < 0) && (secondNumber > 0) && (thirdNumber > 0)) ||
            ((firstNumber < 0) && (secondNumber < 0) && (thirdNumber < 0)))
        {
            sign = "-";
        }
        else
        {
            sign = "+";
        }
        Console.WriteLine(sign);
    }
}

