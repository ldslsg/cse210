using System.Collections.Generic;

public class House
{
    public string Name { get; set; }
    public List<Room> Rooms { get; set; }

    public House(string name)
    {
        Name = name;
        Rooms = new List<Room>();
    }

    public void AddRoom(Room room)
    {
        Rooms.Add(room);
    }

    public void TurnOnAllDevices()
    {
        foreach (var room in Rooms)
        {
            room.TurnOnAllDevices();
        }
    }

    public void TurnOffAllDevices()
    {
        foreach (var room in Rooms)
        {
            room.TurnOffAllDevices();
        }
    }
}
