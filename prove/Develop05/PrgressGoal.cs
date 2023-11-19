public class ProgressGoal : Goal
{
    public int Progress { get; set; }
    public int Target { get; set; }

    public ProgressGoal(string name, int value, int target) : base(name, value)
    {
        Target = target;
        Progress = 0;
    }

    public override int MarkComplete()
    {
        if (Progress >= Target)
        {
            Completed = true;
            return Value;
        }
        return 0; // If not completed, return 0 value
    }

    public void UpdateProgress(int amount)
    {
        Progress += amount;
    }
}