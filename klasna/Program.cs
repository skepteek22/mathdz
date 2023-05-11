using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using Microsoft.VisualBasic;
using System.Security.Cryptography;

namespace klasna
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Results:");
            Console.WriteLine($"Sum: {number1 + number2}");
            Console.WriteLine($"Difference: {number1 - number2}");
            Console.WriteLine($"Product: {number1 * number2}");

            
            if (number2 != 0)
            {
                Console.WriteLine($"Quotient: {number1 / (double)number2}");
            }
            else
            {
                Console.WriteLine("Error: division by zero.");
            }

           
            Console.Write("Enter the third number: ");
            int number3 = int.Parse(Console.ReadLine());

            
            int max = Math.Max(number1, Math.Max(number2, number3));
            int min = Math.Min(number1, Math.Min(number2, number3));
            Console.WriteLine($"Maximum number: {max}");
            Console.WriteLine($"Minimum number: {min}");

            
            Console.WriteLine("Numbers from 1 to 100:");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            
            Console.WriteLine("Even numbers from 1 to 100:");
            for (int i = 2; i <= 100; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of numbers from 1 to 100: {sum}");

            
            Console.WriteLine("Multiplication table for 5:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"5 x {i} = {5 * i}");
            }
        }
    }
}