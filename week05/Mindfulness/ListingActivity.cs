using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are the people that you appreciate?",
        "What are your strengths?",
        "Who have helped you this week?",
        "When have you felt the Holy Ghost this week?",
        "Who are your personal heroes?"
    };


    public ListingActivity() : base("Listing Activity", "This activity helps you reflects on the good things in your life."){}

    public void Run()
    {
        DisplayStartingMessage();
        Random rnd = new Random();

        Console.WriteLine(_prompts[rnd.Next(_prompts.Count())]);
        Console.WriteLine("You may begin in");
        ShowCountDown(5);
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;
        List<string> items = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write(">>  ");
            string input = Console.ReadLine();

            if (! string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
                count++;
            }
        }

        Console.WriteLine($"\nYou Listed {count} items");
        DisplayEndMessage();

    }
}