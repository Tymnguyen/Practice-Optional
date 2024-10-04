using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        /////////////////////////// Telephone Directory ///////////////////////////

        // Step 1: Define the file path for PhoneDirectory.csv
        string phoneDirectoryFile = "PhoneDirectory.csv";

        // Step 2: Check if the file exists, if not, create it and add header
        if (!File.Exists(phoneDirectoryFile))
        {
            using (StreamWriter sw = File.CreateText(phoneDirectoryFile))
            {
                sw.WriteLine("Name,Phone Number");
            }
        }

        // Step 3: Prompt the user to enter names and phone numbers, append them to the CSV file
        int phoneRecordCount = 0;
        string inputName, inputPhoneNumber;
        do
        {
            Console.Write("Enter name (or 'Exit' to quit): ");
            inputName = Console.ReadLine();
            if (inputName.ToLower() == "exit")
                break;

            Console.Write("Enter phone number: ");
            inputPhoneNumber = Console.ReadLine();

            // Step 4: Append the input to the CSV file
            using (StreamWriter sw = File.AppendText(phoneDirectoryFile))
            {
                sw.WriteLine($"{inputName},{inputPhoneNumber}");
            }

            phoneRecordCount++;
        } while (true);

        // Step 5: Display the number of records appended to the file
        Console.WriteLine($"Number of records appended: {phoneRecordCount}");


        /////////////////////////// Library Loan System ///////////////////////////

        string inputFile = "loaninfo.csv";
        string outputFile = "overdueinfo.csv";

        // Step 3: Read data from loaninfo.csv and process
        try
        {
            // Read all lines from the file, skipping the header line
            string[] lines = File.ReadAllLines(inputFile);

            // Open the output file for writing
            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                // Print header to console
                Console.WriteLine("{0,-10} {1,-12} {2,-14} {3,-14} {4,-12} {5,-13} {6,-8}", 
                    "Book ID", "Borrower ID", "Date Borrowed", "Date Returned", "Days Loaned", "Days Overdue", "Fine");

                // Write header to output file
                sw.WriteLine("Book ID, Borrower ID, Days Overdue, Fine");

                // Process each line
                for (int i = 1; i < lines.Length; i++)
                {
                    // Split line by comma
                    string[] parts = lines[i].Split(',');

                    // Extract relevant data
                    string bookID = parts[0];
                    string borrowerID = parts[1];

                    // Update the format string for parsing the date
                    DateTime dateBorrowed = DateTime.ParseExact(parts[2], "d/M/yyyy", CultureInfo.InvariantCulture);
                    DateTime dateReturned = DateTime.ParseExact(parts[3], "d/M/yyyy", CultureInfo.InvariantCulture);

                    // Calculate days loaned
                    int daysLoaned = (int)(dateReturned - dateBorrowed).TotalDays;

                    // Calculate days overdue and fine
                    int daysOverdue = Math.Max(daysLoaned - 14, 0);
                    double fine = daysOverdue * 0.5;

                    // Write data to console
                    Console.WriteLine($"{bookID,-10} {borrowerID,-12} {dateBorrowed,-14:yyyy-MM-dd} {dateReturned,-14:yyyy-MM-dd} {daysLoaned,-12} {daysOverdue,-13} ${fine,-8:F2}");

                    // Write data to output file if overdue
                    if (daysOverdue > 0)
                    {
                        sw.WriteLine($"{bookID}, {borrowerID}, {daysOverdue}, ${fine:F2}");
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}
