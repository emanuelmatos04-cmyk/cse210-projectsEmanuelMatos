using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter duration in seconds: ");
                    int duration1 = int.Parse(Console.ReadLine());
                    BreathingActivity breathing = new BreathingActivity(
                        "Breathing Activity",
                        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                        duration1);
                    breathing.Run();
                    break;

                case "2":
                    Console.Write("Enter duration in seconds: ");
                    int duration2 = int.Parse(Console.ReadLine());
                    List<string> prompts = new List<string>
                    {
                        "Think of a time when you stood up for someone else.",
                        "Think of a time when you did something really difficult.",
                        "Think of a time when you helped someone in need.",
                        "Think of a time when you did something truly selfless."
                    };
                    List<string> questions = new List<string>
                    {
                        "Why was this experience meaningful to you?",
                        "Have you ever done anything like this before?",
                        "How did you get started?",
                        "How did you feel when it was complete?",
                        "What made this time different than other times?",
                        "What is your favorite thing about this experience?",
                        "What could you learn from this experience?",
                        "What did you learn about yourself?",
                        "How can you keep this experience in mind in the future?"
                    };
                    ReflectingActivity reflecting = new ReflectingActivity(
                        "Reflection Activity",
                        "This activity will help you reflect on times in your life when you have shown strength and resilience.",
                        duration2,
                        prompts,
                        questions);
                    reflecting.Run();
                    break;

                case "3":
                    Console.Write("Enter duration in seconds: ");
                    int duration3 = int.Parse(Console.ReadLine());
                    List<string> listingPrompts = new List<string>
                    {
                        "Who are people that you appreciate?",
                        "What are personal strengths of yours?",
                        "Who are people that you have helped this week?",
                        "When have you felt peace this month?",
                        "Who are some of your personal heroes?"
                    };
                    ListingActivity listing = new ListingActivity(
                        "Listing Activity",
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                        duration3,
                        listingPrompts);
                    listing.Run();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
