using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {

            // Read in the two integer values
            Console.Write("Enter the first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int b = int.Parse(Console.ReadLine());

            // Calculate the sum
            int sum;
            if (a == b)
            {
                sum = 3 * (a + b);
            }
            else
            {
                sum = a + b;
            }

            // Print the result
            Console.WriteLine("The sum is: " + sum);
            Console.ReadLine();
        }
    }
}
