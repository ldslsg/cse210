using System;
using System.Threading;

public abstract class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }
    protected ActivityLog Log { get; set; }

    public Activity(ActivityLog log)
    {
        Log = log;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {Name} activity.");
        Console.WriteLine(Description);
        Console.WriteLine("Enter the duration of the activity in seconds:");

        int userInput;
        while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
        Duration = userInput;

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds

        Run();

        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds

        Log.AddEntry(Name);
    }

    protected abstract void Run();
}
