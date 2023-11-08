public class SmartDevice
{
    public string Name { get; set; }
    public string Status { get; set; }
    public DateTime? TimeTurnedOn { get; set; }

    public SmartDevice(string name)
    {
        Name = name;
        Status = "off";
        TimeTurnedOn = null;
    }

    public void TurnOn()
    {
        Status = "on";
        TimeTurnedOn = DateTime.Now;
    }

    public void TurnOff()
    {
        Status = "off";
        TimeTurnedOn = null;
    }

    public string ReportStatus()
    {
        return Status;
    }

    public TimeSpan? ReportTimeOn()
    {
        return TimeTurnedOn.HasValue ? DateTime.Now - TimeTurnedOn : null;
    }
}
