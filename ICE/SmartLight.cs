public class SmartLight : SmartDevice
{
    public int Brightness { get; set; }

    public SmartLight(string name) : base(name)
    {
        Brightness = 0;
    }

    public void AdjustBrightness(int brightness)
    {
        Brightness = brightness;
    }
}
