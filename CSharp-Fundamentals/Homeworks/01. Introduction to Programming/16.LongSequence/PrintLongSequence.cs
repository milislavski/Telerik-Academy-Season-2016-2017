//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

//You might need to learn how to use loops in C# (search in Internet).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintLongSequence
{
    static void Main()
    {
        int startNumber = 2;
        int endNumber = 1002;
        for (int number = startNumber; number < endNumber; number++)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number * (-1));
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}

