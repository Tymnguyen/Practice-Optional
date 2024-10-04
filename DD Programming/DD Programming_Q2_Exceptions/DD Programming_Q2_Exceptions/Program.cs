using System;

class Program
{
    static void Main(string[] args)
    {
        // Uncomment the part you want to test and comment out others.
        // Press Ctrl + K + C to comment, and Ctrl + K + U to uncomment.

        //////////////////// Part 1 ////////////////////
        // Divide two numbers with exception handling for non-numeric values and division by zero

        try
        {
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                if (num2 == 0)
                    throw new DivideByZeroException();

                double result = num1 / num2;
                Console.WriteLine($"Result of division: {result}");
            }
            else
            {
                throw new FormatException("Invalid input, please enter numeric values.");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }

        //////////////////// Part 2 ////////////////////
        // Convert a string to an integer and handle FormatException

        try
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                Console.WriteLine($"You entered the number: {result}");
            }
            else
            {
                throw new FormatException("Invalid input, unable to convert to an integer.");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        //////////////////// Part 3 ////////////////////
        // Divide two numbers and handle DivideByZeroException

        try
        {
            Console.Write("Enter the numerator: ");
            int numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter the denominator: ");
            int denominator = int.Parse(Console.ReadLine());

            if (denominator == 0)
                throw new DivideByZeroException();

            int result = numerator / denominator;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input, please enter numeric values.");
        }

        //////////////////// Part 4 ////////////////////
        // Convert a string to uppercase and handle NullReferenceException

        try
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (input == null)
                throw new NullReferenceException();

            string upperCaseString = input.ToUpper();
            Console.WriteLine($"Uppercase: {upperCaseString}");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Error: Null input is not allowed.");
        }
    }
}
