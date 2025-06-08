using System;
using System.Collections. Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone else",
        "Think of a time you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless"
    };

    private List<string> _questions = new List<string>
    {
        "Why was experience meaning to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different frommother times?",
        "What did you learn about yourself during this experience?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activityhelps you to reflect on times you've shown strength or resiience."){}

    public void Run()
    {
        DisplayStartingMessage();
        Random rnd = new Random();
        Console.WriteLine(_prompts[rnd.Next(_prompts.Count)]);
        ShowSpinner(5);

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rnd.Next(_questions.Count)];
            Console.WriteLine($">{question}");
            ShowSpinner(5);
        }
        DisplayEndMessage();
    }
}