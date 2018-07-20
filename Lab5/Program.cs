using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{

    class Program
    {

        static long Factorial(int x)    //IS recursive qB^)
        {

            //long fact = 1;

            if( x == 1)
            {

                return 1;

            }

            return Factorial(x-1) * x;

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello, welcome to the Factorial Calculator, please enter a  number 1 through 20 (inclusive).");

            char goAgain = 'y';

            do
            {

                int i = int.Parse(Console.ReadLine());
                Console.WriteLine($"The factorial of {i} is " + Factorial(i));

                Console.WriteLine("Would you like to play again? (Y/N)");
                goAgain = Char.Parse(Console.ReadLine());

                Console.WriteLine("Please enter another number 1-20");

            } while (Char.ToLower(goAgain) == 'y');

            Console.WriteLine("See ya next time...");

        }

    }

}
