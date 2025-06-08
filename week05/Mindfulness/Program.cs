using System;

class Program
{
    static void Main(string[] args)
    {
        // For creativity;
        // Spinner and countdown animation are implemented during pauses
        // Questions and Prompts are selected randomly
        //  Reflection and listing activities track the number of questions or inputs

        
        while(true)
        {
            Console.Clear();
            Console.WriteLine("Mindfullness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Please select from the menu: ");
            string choice = Console.ReadLine();


            if(choice == "1")
            {
                new BreathingActivity().Run();
            }

            else if (choice =="2")
            {
                new ReflectionActivity().Run();
            }

            else if (choice == "3")
            {
                new ListingActivity().Run();
            }

            else if (choice == "4")
            {
                Console.WriteLine("Goodbye");
                break;
            }

            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}