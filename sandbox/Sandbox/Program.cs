using System;




public class Program
{
    public static void Main()
    {
        var activities = new Activity[]
        {
            new Running(DateTime.Now, 30, 3.0),
            new Cycling(DateTime.Now, 30, 15.0),// 15mph
            new Swimming(DateTime.Now, 30, 20) //20 laps
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
