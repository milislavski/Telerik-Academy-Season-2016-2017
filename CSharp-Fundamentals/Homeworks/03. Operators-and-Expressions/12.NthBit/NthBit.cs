using System;

class NthBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());


        int result = (number >> position) & 1;

        Console.WriteLine(result);
    }
}