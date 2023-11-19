class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value)
    {
    }

    public override int MarkComplete()
    {
        return Value;
    }
}