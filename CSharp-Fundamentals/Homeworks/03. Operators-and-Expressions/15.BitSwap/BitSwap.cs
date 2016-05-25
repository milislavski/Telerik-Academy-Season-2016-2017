using System;
using System.Text;

class BitSwap
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());//firstPosition
        int q = int.Parse(Console.ReadLine());//secondPosition
        int k = int.Parse(Console.ReadLine());//range

        uint mask = (uint)Math.Pow(2, k) - 1;
        uint result1 = (uint)number & (mask << p);
        result1 >>= p;
        uint result2 = (uint)number & (mask << q);
        result2 >>= q;
        number &= ~(mask << p); //set value 0 from first postion
        number &= ~(mask << q); //set value 0 from second position
        number |= (result2 << p);
        number |= (result1 << q);
        Console.WriteLine(number);
    }
}

