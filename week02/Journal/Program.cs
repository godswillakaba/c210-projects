using System;

class Program
{
    static void Main(string[] args)
    {
        // For creativity, I added a allow the user to specify the location of their entry.
        // This allows for a more immersive experience, as users can remember where they were when they wrote their entry.
        
        Journal journal = new Journal();
        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = journal.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                Console.Write("Where did this happen? ");
                string location = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                journal.AddEntry(prompt, response, date, location);
                Console.WriteLine("\nEntry added successfully!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nJournal Entries:\n");
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("\nEnter filename to load (e.g., journal.txt): ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (choice == "4")
            {
                Console.Write("\nEnter filename to save (e.g., journal.txt): ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
            }
        }
    }
}