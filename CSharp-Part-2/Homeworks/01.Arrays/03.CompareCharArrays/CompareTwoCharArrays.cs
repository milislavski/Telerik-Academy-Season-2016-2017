using System;

class Program
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        char[] firstArray = firstInput.ToCharArray();
        char[] secondArray = secondInput.ToCharArray();
        bool isEqual = true;
        int minArrayLenght = Math.Min(firstArray.Length, secondArray.Length);

        for (int i = 0; i < minArrayLenght; i++)
        {
            if (firstArray[i] < secondArray[i])
            {
                isEqual = false;
                Console.WriteLine("<");
                break;
            }
            if (firstArray[i] > secondArray[i])
            {
                isEqual = false;
                Console.WriteLine(">");
                break;
            }
        }

        if (isEqual && firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("<");
            return;
        }
        if (isEqual && firstArray.Length > secondArray.Length)
        {
            Console.WriteLine(">");
            return;
        }
        if (isEqual && firstArray.Length == secondArray.Length)
        {
            Console.WriteLine("=");
            return;
        }
    }
}