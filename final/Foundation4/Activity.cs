public abstract class Activity
{
    public DateTime Date { get; set; }
    public double Length { get; set; }

    public Activity(DateTime date, double length)
    {
        Date = date;
        Length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}