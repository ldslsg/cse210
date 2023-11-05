using System;

class Program
{
    static void Main(string[] args)
    {
        ActivityLog log = new ActivityLog();

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. View activity log");
            Console.WriteLine("5. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity(log).Start();
                    break;
                case "2":
                    new ReflectionActivity(log).Start();
                    break;
                case "3":
                    new ListingActivity(log).Start();
                    break;
                case "4":
                    log.Display();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
