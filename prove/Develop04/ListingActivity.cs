using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    public ListingActivity(ActivityLog log) : base(log)
    {
        Name = "Listing";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void Run()
    {
        string[] prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Length)]);

        Console.WriteLine("You have a few seconds to think about the prompt...");
        Thread.Sleep(3000); // Pause for 3 seconds

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Enter an item:");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You have listed {items.Count} items.");
    }
}
