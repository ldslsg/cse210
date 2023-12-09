public class Cycling : Activity
{
    public double Speed { get; set; }

    public Cycling(DateTime date, double length, double speed) : base(date, length)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed / 60) * Length;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}