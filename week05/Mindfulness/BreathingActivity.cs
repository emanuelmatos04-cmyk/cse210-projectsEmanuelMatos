using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Breathe in...");
        ShowCountDown(3);
        Console.WriteLine("Breathe out...");
        ShowCountDown(3);
        DisplayEndingMessage();
    }
}
