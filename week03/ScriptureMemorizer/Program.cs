using System;

//For creativity, I decided to allow users to play multiple rounds of the game without restarting the program.

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        bool playAgain = true;
        while (playAgain)
        {
            Scripture scripture = library.GetRandomScripture();
            bool quitRequested = false;


            while ( ! scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPlease press ENTER to hide more words or type 'quit' to exit");

                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Thanks for playing! See you again.");
                    quitRequested = true;
                    break; 
                }

                else if (input == "")
                {
                    scripture.HideRandomWords();
                }
            } 

            if (!quitRequested)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are are hidden. Well done!");

                Console.Write("\nDo you want to play again? (yes/no): ");
                string response = Console.ReadLine().Trim().ToLower();
                
             
                if (response != "yes")
                {
                    Console.WriteLine("Thanks for playing! See you again.");
                    playAgain = false;
                }
            } 
            else
            {
                playAgain = false; // Exit the loop if the user requested to quit
            }      
               
        }    
    }
}