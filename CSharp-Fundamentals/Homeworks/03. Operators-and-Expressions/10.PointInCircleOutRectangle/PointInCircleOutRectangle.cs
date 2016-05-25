using System;

class PointInCircleOutRectangle
{
    static void Main()
    {
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());
        double circleX = 1;
        double circleY = 1;
        double radius = 1.5;
        bool isInCircle = (Math.Abs(pointX - circleX)) * (Math.Abs(pointX - circleX)) + (Math.Abs(pointY - circleY)) * (Math.Abs(pointY - circleY)) <= radius * radius;
        bool IsInRectangle = (pointX <= 5 && pointY >= -1) && (pointY >= -1 && pointY <= 1);

        if (isInCircle && IsInRectangle)
        {
            Console.WriteLine("inside circle inside rectangle ");
        }
        else if (isInCircle && !IsInRectangle)
        {
            Console.WriteLine("inside circle outside rectangle ");

        }
        else if (!isInCircle && IsInRectangle)
        {
            Console.WriteLine("outside circle inside rectangle ");
        }
        else
        {
            Console.WriteLine("outside circle outside rectangle");
        }
    }
}
