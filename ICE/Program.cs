using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some devices
        SmartLight light = new SmartLight("Living Room Light");
        SmartHeater heater = new SmartHeater("Bedroom Heater");
        SmartTV tv = new SmartTV("Kitchen TV");

        // Create a room and add devices to it
        Room livingRoom = new Room("Living Room");
        livingRoom.AddDevice(light);
        livingRoom.AddDevice(tv);

        Room bedroom = new Room("Bedroom");
        bedroom.AddDevice(heater);

        // Create a house and add rooms to it
        House house = new House("My House");
        house.AddRoom(livingRoom);
        house.AddRoom(bedroom);

        // Turn on all devices in the house
        house.TurnOnAllDevices();

        // Report status of all devices in the living room
        livingRoom.ReportAllDevices();

        // Adjust brightness of the light
        light.AdjustBrightness(50);
        Console.WriteLine($"The brightness of the {light.Name} is now {light.Brightness}");

        // Report how long the light has been on
        TimeSpan? timeOn = light.ReportTimeOn();
        if (timeOn.HasValue)
        {
            Console.WriteLine($"The {light.Name} has been on for {timeOn.Value.TotalMinutes} minutes");
        }
    }
}
