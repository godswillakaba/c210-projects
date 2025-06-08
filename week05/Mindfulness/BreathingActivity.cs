using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you to relax by guiding you through slow breathing."){}

    public void Run()
    {
        DisplayStartingMessage();
        int time = GetDuration();

        for(int i =0; i < time; i +=6)
        {
            Console.Write("Breathe in....");
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write("Breathe out....");
            ShowCountDown(3);
            Console.WriteLine("\n");
        }
        DisplayEndMessage();
    }
}