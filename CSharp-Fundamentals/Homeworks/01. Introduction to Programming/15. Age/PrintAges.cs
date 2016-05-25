
//The input will always consist of a single line - a birthdate.

//Output

//You should print two lines with one number on the each line:
//How old are you now, on the first line.
//How old will you be after 10 years, on the second line.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintAges
{
    static void Main()
    {
        string[] userBirthmonthDayAndYear = Console.ReadLine().Split('.');
        int userBirthMonth = int.Parse(userBirthmonthDayAndYear[0]);
        int userBirthDay = int.Parse(userBirthmonthDayAndYear[1]);
        int userBirthYear = int.Parse(userBirthmonthDayAndYear[2]);

        DateTime now = DateTime.Now;
        int userYears = 0;

        if (now.Month < userBirthMonth)
        {
            userYears = now.Year - userBirthYear - 1;
        }
        else if (now.Month > userBirthMonth)
        {
            userYears = now.Year - userBirthYear;
        }
        else
        {
            if (now.Day < userBirthDay)
            {
                userYears = now.Year - userBirthYear - 1;
            }
            else
            {
                userYears = now.Year - userBirthYear;
            }
        }
        Console.WriteLine("{0}\n{1}",userYears,userYears+10);
    }
}


