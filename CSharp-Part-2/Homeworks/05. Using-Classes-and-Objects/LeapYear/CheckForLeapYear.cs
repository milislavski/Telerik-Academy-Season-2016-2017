namespace LeapYear
{
    using System;

    class CheckForLeapYear
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            IsLeapYear(input);
        }

        static void IsLeapYear(int year)
        {
            var isLeap = DateTime.IsLeapYear(year);
            if (isLeap)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
