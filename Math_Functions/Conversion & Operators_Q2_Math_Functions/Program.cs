using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Calculate the minimum of two numbers
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double min = Math.Min(num1, num2);
        Console.WriteLine($"The minimum of {num1} and {num2} is {min}\n");

        // Part 2: Calculate the maximum of two numbers
        Console.Write("Enter the first number: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2 = double.Parse(Console.ReadLine());
        double max = Math.Max(num1, num2);
        Console.WriteLine($"The maximum of {num1} and {num2} is {max}\n");

        // Part 3: Calculate the square root of a number
        Console.Write("Enter a number: ");
        double num = double.Parse(Console.ReadLine());
        double sqrt = Math.Sqrt(num);
        Console.WriteLine($"The square root of {num} is {sqrt}\n");

        // Part 4: Calculate the absolute value of a number
        Console.Write("Enter a number: ");
        num = double.Parse(Console.ReadLine());
        double absValue = Math.Abs(num);
        Console.WriteLine($"The absolute value of {num} is {absValue}\n");

        // Part 5: Calculate the power of a number
        Console.Write("Enter the base number: ");
        double baseNum = double.Parse(Console.ReadLine());
        Console.Write("Enter the exponent: ");
        double exponent = double.Parse(Console.ReadLine());
        double power = Math.Pow(baseNum, exponent);
        Console.WriteLine($"{baseNum} raised to the power of {exponent} is {power}\n");

        // Part 6: Round a number to the nearest integer
        Console.Write("Enter a number: ");
        num = double.Parse(Console.ReadLine());
        double rounded = Math.Round(num);
        Console.WriteLine($"{num} rounded to the nearest integer is {rounded}\n");

        // Part 7: Find the smallest integer greater than or equal to a number
        Console.Write("Enter a number: ");
        num = double.Parse(Console.ReadLine());
        double ceiling = Math.Ceiling(num);
        Console.WriteLine($"The smallest integer greater than or equal to {num} is {ceiling}\n");

        // Part 8: Find the largest integer less than or equal to a number
        Console.Write("Enter a number: ");
        num = double.Parse(Console.ReadLine());
        double floor = Math.Floor(num);
        Console.WriteLine($"The largest integer less than or equal to {num} is {floor}\n");

        // Part 9: Calculate e raised to the power of a number
        Console.Write("Enter a number: ");
        num = double.Parse(Console.ReadLine());
        double exp = Math.Exp(num);
        Console.WriteLine($"e raised to the power of {num} is {exp}\n");

        // Part 10: Calculate the natural logarithm of a number
        Console.Write("Enter a number: ");
        num = double.Parse(Console.ReadLine());
        double log = Math.Log(num);
        Console.WriteLine($"The natural logarithm of {num} is {log}\n");

        // Part 11: Generate a random number between 1 and 100
        Random random = new Random();
        int randomNumber = random.Next(1, 101); // Random number between 1 and 100
        Console.WriteLine($"A random number between 1 and 100 is {randomNumber}");
    }
}
