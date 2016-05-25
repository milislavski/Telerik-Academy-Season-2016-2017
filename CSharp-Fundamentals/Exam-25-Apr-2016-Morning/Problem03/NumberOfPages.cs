using System;
using System.Collections.Generic;
using System.Text;

class NumberOfPages

{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //StringBuilder allDigits = new StringBuilder();
        long digitCounter = 0;
        for (int i = 1; i <= n; i++)
        {
            int currentLenght = i.ToString().Length;
            digitCounter += currentLenght;
        }

        Console.WriteLine(digitCounter);


    }
}

