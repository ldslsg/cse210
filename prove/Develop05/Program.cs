using System;

class Program
{
    static void Main(string[] args)
{
    User user = new User("John");
    Goal goal1 = new SimpleGoal("Run a marathon", 1000);
    Goal goal2 = new EternalGoal("Read scriptures", 100);
    Goal goal3 = new ChecklistGoal("Attend the temple", 50, 10, 500);
    Goal goal4 = new ProgressGoal("Marathon training", 500, 10000);
    Goal goal5 = new NegativeGoal("Avoid fast food", 50);

    user.AddGoal(goal1);
    user.AddGoal(goal2);
    user.AddGoal(goal3);
    user.AddGoal(goal4);
    user.AddGoal(goal5);
    ((ProgressGoal)goal4).UpdateProgress(2000);
    while (true)
    {
        Console.WriteLine("1. Display Goals");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Display Score");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                user.DisplayGoals();
                break;
            case 2:
                Console.Write("Enter the name of the goal: ");
                string goalName = Console.ReadLine();
                user.RecordEvent(goalName);
                break;
            case 3:
                user.DisplayScore();
                break;
            case 4:
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}

}
