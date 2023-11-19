class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusValue;

    public ChecklistGoal(string name, int value, int targetCount, int bonusValue) : base(name, value)
    {
        this.targetCount = targetCount;
        currentCount = 0;
        this.bonusValue = bonusValue;
    }

    public override int MarkComplete()
    {
        currentCount++;
        if (currentCount == targetCount)
        {
            MarkBonus();
            return Value + bonusValue;
        }
        return Value;
    }

    private void MarkBonus()
    {
        Completed = true;
    }

    public string ProgressStatus()
    {
        return $"Completed {currentCount}/{targetCount} times";
    }
}
