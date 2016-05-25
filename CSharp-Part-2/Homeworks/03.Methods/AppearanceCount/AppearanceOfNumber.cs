namespace AppearanceCount
{
    using System;
    using System.Linq;

    class AppearanceOfNumber
    {
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            var inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n=>int.Parse(n))
                .ToArray();

            int numberToCheck = int.Parse(Console.ReadLine());

            Console.WriteLine(CountAppearances(inputNumbers,numberToCheck));
        }

        static int CountAppearances (int[] array, int number)
        {
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
