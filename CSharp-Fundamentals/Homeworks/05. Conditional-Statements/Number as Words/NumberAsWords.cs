using System;

class NumberAsWords
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int firstDigit = (inputNumber / 100) % 10;
        int secondDigit = (inputNumber / 10) % 10;
        int thirdDigit = (inputNumber % 10);

        string[] numbersToTwenty = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"
            , "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] tens = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        string result = "";

        if (inputNumber >= 0 && inputNumber <= 20)
        {
            result = numbersToTwenty[inputNumber];
        }

        else if (inputNumber > 19 && inputNumber < 100)
        {
            if (thirdDigit == 0)
            {
                result = tens[secondDigit - 2];
            }
            else
            {
                result = tens[secondDigit - 2] + " " + numbersToTwenty[thirdDigit].ToLower();
            }
        }

        else
        {
            if (secondDigit == 0 && thirdDigit == 0)
            {
                result = numbersToTwenty[firstDigit] + " hundred";
            }
            else if (secondDigit != 0 && thirdDigit == 0)
            {
                result = numbersToTwenty[firstDigit] + " hundred and " + tens[secondDigit - 2].ToLower();
            }
            else if (secondDigit == 0 && thirdDigit != 0)
            {
                result = numbersToTwenty[firstDigit] + " hundred and " + numbersToTwenty[thirdDigit].ToLower();
            }
            else
            {
                if (secondDigit == 1)
                {
                    result = numbersToTwenty[firstDigit] + " hundred and " + numbersToTwenty[(thirdDigit) + 10].ToLower();
                }
                else
                {
                    result = numbersToTwenty[firstDigit] + " hundred and " + tens[secondDigit - 2].ToLower() + " " + numbersToTwenty[thirdDigit].ToLower();
                }
            }
        }
        Console.WriteLine(result);
    }
}

