using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Check your grade here!");
        Console.Write("What was your score percentage?");
        string result = Console.ReadLine();
        int grade = int.Parse(result);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }
        
        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");


        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the test.");
        }

        else
        {
            Console.WriteLine("Sorry, review your notes carefully and take the test again.");
        }
    }
}