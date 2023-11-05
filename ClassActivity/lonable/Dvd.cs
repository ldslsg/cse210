public class Dvd : Lonable
{
    private string _title;

    public Dvd(string tile)
    {
        _title = title;
    }

    public override void Display()
    {
        System.Console.WriteLine($"Title: {_title}");
        base.Display();
    }
}