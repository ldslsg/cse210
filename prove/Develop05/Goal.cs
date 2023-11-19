public class Goal
{
    public string Name { get; }
    public int Value { get; }
    public bool Completed { get; protected set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        Completed = false;
    }

    public virtual int MarkComplete()
    {
        Completed = true;
        return Value;
    }

    public bool IsCompleted()
    {
        return Completed;
    }
}
