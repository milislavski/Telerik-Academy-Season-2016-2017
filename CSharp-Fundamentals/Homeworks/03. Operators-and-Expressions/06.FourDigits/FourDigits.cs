using System;

class FourDigits
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int firstNumber = (inputNumber / 1000) % 10;
        int secondNumber = (inputNumber / 100) % 10;
        int thirdNumber = (inputNumber / 10) % 10;
        int fourthNumber = inputNumber % 10;
        int sum = firstNumber + secondNumber + thirdNumber + fourthNumber;
        string reversedNumberAsString = fourthNumber.ToString()
                                        + thirdNumber.ToString()
                                        + secondNumber.ToString()
                                        + firstNumber.ToString();
        //int reversedNumber = int.Parse(reversedNumberAsString);
        string lastDigitFirstAsString = fourthNumber.ToString()
                                        + firstNumber.ToString()
                                        + secondNumber.ToString()
                                        + thirdNumber.ToString();
        //int lastDigitFirst = int.Parse(lastDigitFirstAsString);
        string exchangeMiddleNumbersAsString = firstNumber.ToString()
                                        + thirdNumber.ToString()
                                        + secondNumber.ToString()
                                        + fourthNumber.ToString();
        int exchangeMiddleNumbers = int.Parse(exchangeMiddleNumbersAsString);
        Console.WriteLine(sum);
        Console.WriteLine(reversedNumberAsString);
        Console.WriteLine(lastDigitFirstAsString);
        Console.WriteLine(exchangeMiddleNumbers);
    }
}
