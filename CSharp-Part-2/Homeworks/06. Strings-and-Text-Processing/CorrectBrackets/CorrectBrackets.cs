using System;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            int leftBrackets = 0;
            int rightBrackets = 0;
            bool isCorrect = true;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    leftBrackets++;
                }
                else if (expression[i] == ')')
                {
                    rightBrackets++;
                }
                if (rightBrackets > leftBrackets)
                {
                    isCorrect = false;
                }
            }
            if (rightBrackets != leftBrackets)
            {
                isCorrect = false;
            }

            if (isCorrect)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
