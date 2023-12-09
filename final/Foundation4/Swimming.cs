public class Swimming : Activity
{
    public int NumberOfLaps { get; set; }

    public Swimming(DateTime date, double length, int numberOfLaps) : base(date, length)
    {
        NumberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return NumberOfLaps * 50 / 1000 * 0.62; // convert to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Length) * 60;
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }
}