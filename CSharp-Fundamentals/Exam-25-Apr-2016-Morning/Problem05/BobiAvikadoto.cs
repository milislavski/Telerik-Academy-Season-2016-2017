using System;
using System.Collections.Generic;


class BobiAvokadoto
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string nToBinary = Convert.ToString(n, 2).PadLeft(32, '0');
        int c = int.Parse(Console.ReadLine());

        int best = 0;

        var allCombs = new List<int>();
        for (int i = 0; i < c; i++)
        {
            int currentComb = int.Parse(Console.ReadLine());
            string currentCombBinary = Convert.ToString(currentComb, 2).PadLeft(32, '0');
            for (int j = 0; j < nToBinary.Length; j++)
            {
                if (nToBinary[j] != currentCombBinary[j])
                {
                    if (currentComb > best)
                    {
                        best = currentComb;
                        allCombs.Add(best);
                    }
                }
            }
        }
        allCombs.Sort();
        allCombs.Reverse();
        Console.WriteLine(allCombs[0]);

    }
}
