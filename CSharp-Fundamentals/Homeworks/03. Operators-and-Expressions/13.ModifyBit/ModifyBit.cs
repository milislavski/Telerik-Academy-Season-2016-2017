using System;

class ModifyBit
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());

        if (value == 0)
        {
            ulong mask = (ulong)~(1 << position);
            ulong result = number & mask;
            Console.WriteLine(result);
        }
        else
        {
            ulong mask = (ulong)1 << position;
            ulong result = number | mask;
            Console.WriteLine(result);

        }
    }
}