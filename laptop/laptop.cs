public class Laptop{

    private double _screenSize;
    private string _os;
    private bool _touchscreen;
    public Laptop(double _screenSize, string os, bool ts)
    {
        _screenSize = _screenSize;
        _os = os;
        _touchscreen = ts;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{_screenSize} {_os} {_touchscreen}");
    }
}