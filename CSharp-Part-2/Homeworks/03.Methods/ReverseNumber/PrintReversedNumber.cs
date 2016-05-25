namespace ReverseNumber
{
    using System;

    class PrintReversedNumber
    {
        static void Main()
        {
            var number = Console.ReadLine();
            Console.WriteLine(ReverseNumber(number));
        }

        static string ReverseNumber(string number)
        {
            string negativeNumber = "";
            string result = "";
            if (number[0] == '-')
            {
                result = "-";
                negativeNumber = number.Substring(1);

                for (int i = negativeNumber.Length-1; i >=0 ; i--)
                {
                    result += negativeNumber[i];
                }
            }
            else
            {
                for (int i = number.Length-1; i >= 0; i--)
                {
                    result += number[i];
                }
            }
            return result;
        }
    }
}
