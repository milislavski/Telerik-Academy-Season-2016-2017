using System;

class BiggestOfFive
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double fourthNumber = double.Parse(Console.ReadLine());
        double fifthNumber = double.Parse(Console.ReadLine());

        double maxNumber = firstNumber;
        if (secondNumber > maxNumber)
        {
            maxNumber = secondNumber;
        }

        if (thirdNumber > maxNumber)
        {
            maxNumber = thirdNumber;
        }

        if (fourthNumber > maxNumber)
        {
            maxNumber = fourthNumber;
        }

        if (fifthNumber > maxNumber)
        {
            maxNumber = fifthNumber;
        }
        Console.WriteLine(maxNumber);
    }
}

