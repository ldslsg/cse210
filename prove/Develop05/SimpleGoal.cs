class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value)
    {
    }

    public override int MarkComplete()
    {
        base.MarkComplete();
        return Value;
    }
}