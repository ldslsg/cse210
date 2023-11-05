using System;
using System.Collections.Generic;

public class ActivityLog
{
    private Dictionary<string, int> log = new Dictionary<string, int>();

    public void AddEntry(string activityName)
    {
        if (log.ContainsKey(activityName))
        {
            log[activityName]++;
        }
        else
        {
            log[activityName] = 1;
        }
    }

    public void Display()
    {
        Console.WriteLine("Activity log:");
        foreach (KeyValuePair<string, int> entry in log)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
    }
}
