using System;

class Program
{
    static void Main(string[] args)
    {
        // Uncomment the part you want to test and comment out others.
        // Press Ctrl + K + C to comment, and Ctrl + K + U to uncomment.

        //////////////////// Part 1 ////////////////////
        // Add and subtract days from the date

        
        Console.Write("Enter the date (dd/MM/yyyy): ");
        DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.Write("Enter the number of days to add or subtract: ");
        int days = int.Parse(Console.ReadLine());

        DateTime dateAfter = inputDate.AddDays(days);
        DateTime dateBefore = inputDate.AddDays(-days);

        Console.WriteLine($"Date after {days} days: {dateAfter:dd/MM/yyyy}");
        Console.WriteLine($"Date before {days} days: {dateBefore:dd/MM/yyyy}");
        

        //////////////////// Part 2 ////////////////////
        // Calculate the user's age based on the date of birth

        
        Console.Write("Enter your date of birth (dd/MM/yyyy): ");
        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        DateTime today = DateTime.Now;

        int years = today.Year - birthDate.Year;
        if (birthDate > today.AddYears(-years)) years--;

        int months = today.Month - birthDate.Month;
        if (months < 0) months += 12;

        int days = (today - birthDate.AddYears(years).AddMonths(months)).Days;

        Console.WriteLine($"You are {years} years, {months} months, and {days} days old.");
        

        //////////////////// Part 3 ////////////////////
        // Calculate the difference between two dates

        
        Console.Write("Enter the first date (dd/MM/yyyy): ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.Write("Enter the second date (dd/MM/yyyy): ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        TimeSpan dateDifference = secondDate - firstDate;
        Console.WriteLine($"The difference between the two dates is: {dateDifference.Days} days");
        

        //////////////////// Part 4 ////////////////////
        // Convert days into years, weeks, and days

        
        Console.Write("Enter the number of days: ");
        int totalDays = int.Parse(Console.ReadLine());

        int years = totalDays / 365;
        totalDays %= 365;
        int weeks = totalDays / 7;
        int days = totalDays % 7;

        Console.WriteLine($"Years: {years}");
        Console.WriteLine($"Weeks: {weeks}");
        Console.WriteLine($"Days: {days}");
        

        //////////////////// Part 5 ////////////////////
        // Print day name of the week based on day number

        
        Console.Write("Enter the number of day (1 for Monday, 7 for Sunday): ");
        int dayNumber = int.Parse(Console.ReadLine());

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            string dayName = Enum.GetName(typeof(DayOfWeek), dayNumber % 7);
            Console.WriteLine($"Day {dayNumber} is {dayName}");
        }
        else
        {
            Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
        }
        

        //////////////////// Part 6 ////////////////////
        // Retrieve the current date

        
        DateTime currentDate = DateTime.Today;
        Console.WriteLine($"The current date is: {currentDate:dd/MM/yyyy}");
        

        //////////////////// Part 7 ////////////////////
        // Retrieve the current date and time

        
        DateTime currentDateTime = DateTime.Now;
        Console.WriteLine($"The current date and time is: {currentDateTime:dd/MM/yyyy HH:mm:ss}");
        
    }
}
