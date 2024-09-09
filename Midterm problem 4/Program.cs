using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_problem_4
{
    internal class Program
    {
        static int factorial(int x) //sets the factorial as int x
        {
            int returnValue = 1; //sets return value as 1
            for (int i = 1; i <= x; i++) 
            {
                returnValue *= i; // Returns i
            }
           Console.WriteLine(returnValue); // writes the return value
            return returnValue; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number"); // prompts user to enter a number
            int number = Convert.ToInt32(Console.ReadLine()); // makes their number a variable


            if (number == 0 ) // checks users input to be above 0
            {
                Console.WriteLine("Enter a number above 0"); // prompts user to input a number above 0
            }

            int sum = 0; // sets the sum as 0
            for (int i = 1;i < number; i++)
            {
                sum = sum + factorial(i); //adds the sum and factorial
            }
            Console.WriteLine("Sum of factorial is " + sum); // prints the sum of the factorial
            Console.Read();
        }
    }
}
