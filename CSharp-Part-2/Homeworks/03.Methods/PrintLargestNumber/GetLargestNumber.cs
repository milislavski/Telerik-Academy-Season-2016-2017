namespace PrintLargestNumber
{
    using System;
    using System.Linq;

    class GetLargestNumber
    {
        static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            int result = GetMax(inputNumbers[0], GetMax(inputNumbers[1], inputNumbers[2]));
            Console.WriteLine(result);
        }

        static int GetMax(int firstValue,int secondValue)
        {
            int maxValue = firstValue;
            if (secondValue > firstValue)
            {
                maxValue = secondValue;
            }
            return maxValue;
        }
    }
}
