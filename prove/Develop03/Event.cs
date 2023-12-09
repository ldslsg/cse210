
public abstract class Event
{
    protected string Title;
    protected string Description;
    protected string Date;
    protected string Time;
    protected Address Address;

    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public abstract string GetStandardDetails();
    public abstract string GetFullDetails();
    public abstract string GetShortDescription();
}



// Similarly, define the Reception and OutdoorGathering classes
