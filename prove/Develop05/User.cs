class User
{
    private string name;
    private List<Goal> goals;
    private int score;

    public User(string name)
    {
        this.name = name;
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.Name == goalName)
            {
                score += goal.MarkComplete();
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine($"Your Goals:");
        foreach (var goal in goals)
        {
            string status = goal.IsCompleted() ? "[X]" : "[ ]";
            if (goal is ChecklistGoal checklistGoal)
            {
                status += $" {checklistGoal.ProgressStatus()}";
            }
            Console.WriteLine($"{status} {goal.Name}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score for {name}: {score}");
    }
}
