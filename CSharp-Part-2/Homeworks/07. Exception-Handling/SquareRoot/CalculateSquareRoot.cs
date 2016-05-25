using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class CalculateSquareRoot
    {
        static void Main()
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Invalid number");
                    return;
                }
                Console.WriteLine("{0:0.000}", Math.Sqrt(number));

            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid number");
            }
            catch (ArgumentNullException)
            {

                Console.WriteLine("Invalid number");
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }


        }
    }
}
