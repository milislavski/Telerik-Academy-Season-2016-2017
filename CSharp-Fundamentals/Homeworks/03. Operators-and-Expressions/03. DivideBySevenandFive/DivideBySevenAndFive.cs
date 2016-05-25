using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        string result = "false";
        if (inputNumber % 7 == 0 && inputNumber % 5 == 0)
        {
            result = "true";
        }
        Console.WriteLine("{0} {1}", result, inputNumber);
    }
}