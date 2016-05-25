using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("{0} {1}",secondNumber,firstNumber);
        }
        else
        {
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
    }
}

