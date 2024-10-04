using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Uncomment the part you want to test and comment out others.
        // Press Ctrl + K + C to comment, and Ctrl + K + U to uncomment.

        //////////////////// Question 1 ////////////////////
        // Attempt to divide two numbers and print any exceptions

        
        try
        {
            int numerator = 10;
            int denominator = 0; // Division by zero
            int result = numerator / denominator;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        

        //////////////////// Question 2 ////////////////////
        // Convert a string to an integer and print any exceptions

        
        try
        {
            string input = "abc"; // Invalid input for conversion
            int number = int.Parse(input);
            Console.WriteLine($"Converted number: {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid format for integer conversion.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        

        //////////////////// Question 3 ////////////////////
        // Open a file and print any exceptions

        
        try
        {
            string filePath = "non_existent_file.txt"; // File does not exist
            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Error: File not found.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        

        //////////////////// Question 4 ////////////////////
        // Read input from the user and print any exceptions

        
        try
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            Console.WriteLine($"You entered: {userNumber}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input format.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        

        //////////////////// Question 5 ////////////////////
        // Perform a calculation and print any exceptions

        
        try
        {
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 / number2; // May cause divide by zero error
            Console.WriteLine($"Result of division: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input format.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        
    }
}
