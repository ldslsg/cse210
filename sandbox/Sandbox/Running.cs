public class Running : Activity
{
    public double Distance { get; set; }

    public Running(DateTime date, double length, double distance) : base(date, length)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / Length) * 60;
    }

    public override double GetPace()
    {
        return Length / Distance;
    }
}
