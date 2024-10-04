using System;

class Program
{
    static void Main(string[] args)
    {
        // Uncomment the part you want to test and comment out others.
        // Press Ctrl + K + C to comment, and Ctrl + K + U to uncomment.

        //////////////////// Part 1 ////////////////////
        // Concatenate two strings (first name and last name)

        string firstName = "John";
        string lastName = "Doe";
        string fullName = firstName + " " + lastName;
        Console.WriteLine("Full Name: " + fullName);


        //////////////////// Part 2 ////////////////////
        // Get two strings (username) from the user and concatenate them

        Console.WriteLine("Enter your first name: ");
        string userFirstName = Console.ReadLine();
        Console.WriteLine("Enter your last name: ");
        string userLastName = Console.ReadLine();
        string userFullName = userFirstName + " " + userLastName;
        Console.WriteLine("Your full name is: " + userFullName);


        //////////////////// Part 3 ////////////////////
        // Concatenate three strings (first name, last name, and clan name)

        Console.WriteLine("Enter your first name: ");
        firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name: ");
        lastName = Console.ReadLine();
        Console.WriteLine("Enter your clan name: ");
        string clanName = Console.ReadLine();
        string fullNameWithClan = firstName + " " + lastName + " of Clan " + clanName;
        Console.WriteLine("Your full name with clan is: " + fullNameWithClan);


        //////////////////// Part 4 ////////////////////
        // Concatenate a string and an integer (player name and number)

        Console.WriteLine("Enter your player name: ");
        string playerName = Console.ReadLine();
        Console.WriteLine("Enter your player number: ");
        int playerNumber = int.Parse(Console.ReadLine());
        string playerInfo = playerName + " #" + playerNumber;
        Console.WriteLine("Player Information: " + playerInfo);
    }
}
