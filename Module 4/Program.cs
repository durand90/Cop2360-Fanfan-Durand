// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

namespace DivisionWithExceptionHandling
{
    class Program
    {
        static void Main(strings[] args)
        {
            Console.Writeline("Enter the first number:");
            strings input1 = Console.Readline();
            Console.Writeline("Enter the second number:");
            sting input2 = Console.Readline();
            
            PerfomDivision(input1, input2);
        }
    }
}

        static void PerformDivision(sting num1, string num2)
        {
            try
            {
                // Convert strings to integers
                int dividend = Convert.ToInt32(num1);
                int divisor = Convert.ToInt32(num2);
                
                //Perform Division
                int result = dividend / divisor;
                
                // Print the result 
                Console.Writeline($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.Writeline("Error: One of the inputs is not a valid integer.");
            }
            catch (DivideByZeroException)
            {
                Console.Writeline("Error: Division by zero is not allowed."");
            }
            catch (Exception ex)
            {
                Console.Writeline($"An unexpected error occurred: {ex.Message}");
                
            }
}