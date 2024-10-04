using System;

class Program
{
    static void Main(string[] args)
    {
        // Uncomment the part you want to test and comment out others.
        // Press Ctrl + K + C to comment, and Ctrl + K + U to uncomment.

        //////////////////// Part 1 ////////////////////
        // Calculate BMI using height in meters and weight in kilograms

        
        Console.Write("Enter your height in meters: ");
        double heightMeters = double.Parse(Console.ReadLine());
        Console.Write("Enter your weight in kilograms: ");
        double weightKg = double.Parse(Console.ReadLine());

        double bmiMetric = weightKg / (heightMeters * heightMeters);
        Console.WriteLine($"Your BMI is {bmiMetric:F1}");

        if (bmiMetric < 18.5)
            Console.WriteLine("You are Underweight.");
        else if (bmiMetric < 25)
            Console.WriteLine("You are Normal.");
        else if (bmiMetric < 30)
            Console.WriteLine("You are Overweight.");
        else
            Console.WriteLine("You are Obese.");
        

        //////////////////// Part 2 ////////////////////
        // Calculate BMI using height in feet and inches, and weight in pounds

        
        Console.Write("Enter your height in feet: ");
        int feet = int.Parse(Console.ReadLine());
        Console.Write("Enter your height in inches: ");
        int inches = int.Parse(Console.ReadLine());
        Console.Write("Enter your weight in pounds: ");
        double weightLbs = double.Parse(Console.ReadLine());

        // Convert height to inches
        int totalHeightInches = (feet * 12) + inches;
        double bmiImperial = (weightLbs * 703) / (totalHeightInches * totalHeightInches);
        Console.WriteLine($"Your BMI is {bmiImperial:F1}");

        if (bmiImperial < 18.5)
            Console.WriteLine("You are Underweight.");
        else if (bmiImperial < 25)
            Console.WriteLine("You are Normal.");
        else if (bmiImperial < 30)
            Console.WriteLine("You are Overweight.");
        else
            Console.WriteLine("You are Obese.");
        

        //////////////////// Part 3 ////////////////////
        // Convert player's score from integer to double and print with one decimal place

        
        int playerScore = 100;
        double playerScoreDouble = (double)playerScore;
        Console.WriteLine($"Player's Score with one decimal place: {playerScoreDouble:F1}");
        

        //////////////////// Part 4 ////////////////////
        // Convert player's health from double to integer percentage and print result

        
        double playerHealth = 0.75;
        int healthPercentage = (int)(playerHealth * 100);
        Console.WriteLine($"Player's Health as a percentage: {healthPercentage}%");
        

        //////////////////// Part 5 ////////////////////
        // Convert player's coins from double to integer (rounded down) and print result

        
        double playerCoins = 123.45;
        int coinsInteger = (int)playerCoins;
        Console.WriteLine($"Player's Coins as an integer: {coinsInteger}");
        

        //////////////////// Part 6 ////////////////////
        // Convert player's progress from boolean to string and print result

        
        bool progress = true;  // change this to false to test incomplete
        string progressStatus = progress ? "Completed" : "Incomplete";
        Console.WriteLine($"Player's Progress as a string: {progressStatus}");
        
    }
}
