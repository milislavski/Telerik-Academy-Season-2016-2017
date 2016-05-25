using System;

class OddOrEven
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        string isOdd = "odd";
        if (inputNumber % 2 == 0)
        {
            isOdd = "even";
        }
        Console.WriteLine("{0} {1}", isOdd, inputNumber);
    }
}