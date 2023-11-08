using System.Collections.Generic;

public class Room
{
    public string Name { get; set; }
    public List<SmartDevice> Devices { get; set; }

    public Room(string name)
    {
        Name = name;
        Devices = new List<SmartDevice>();
    }

    public void AddDevice(SmartDevice device)
    {
        Devices.Add(device);
    }

    public void TurnOnAllLights()
    {
        foreach (var device in Devices)
        {
            if (device is SmartLight)
            {
                device.TurnOn();
            }
        }
    }

    public void TurnOffAllLights()
    {
        foreach (var device in Devices)
        {
            if (device is SmartLight)
            {
                device.TurnOff();
            }
        }
    }

    public void ReportAllDevices()
    {
        foreach (var device in Devices)
        {
            System.Console.WriteLine($"{device.Name} is {device.ReportStatus()}");
        }
    }
    
    public void TurnOnAllDevices()
    {
        foreach (var device in Devices)
        {
            device.TurnOn();
        }
    }

    public void TurnOffAllDevices()
    {
        foreach (var device in Devices)
        {
            device.TurnOff();
        }
    }
}
