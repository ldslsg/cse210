public class NegativeGoal : Goal
{
    public NegativeGoal(string name, int value) : base(name, value)
    {
    }

    public override int MarkComplete()
    {
        Completed = true;
        return -Value; // Deduct points for negative goals
    }
}