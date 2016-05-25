using System;

class BiggestOfThree
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double biggestNumber = firstNumber;

        if (secondNumber > firstNumber)
        {
            if (secondNumber > thirdNumber)
            {
                biggestNumber = secondNumber;
            }
            else
            {
                biggestNumber = thirdNumber;
            }
        }
        else
        {
            if (thirdNumber> firstNumber)
            {
                biggestNumber = thirdNumber;
            }
        }
        Console.WriteLine(biggestNumber);
    }
}

