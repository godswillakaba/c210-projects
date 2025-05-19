using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;

        while (number != guess)
        {
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (number == guess)
            {
                Console.WriteLine("You guessed it!");
            }

            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        }


    

    

        
    }
}