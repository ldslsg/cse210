public class Elevator
{
    private List<Floor> floors = new List<Floor>();
    public bool DoorOpen { get; private set; }
    public int CurrentFloor { get; private set; }
    public int MaxFloor { get; private set; }

    public Elevator(int maxFloor)
    {
        // Initialize the elevator with some floors
        MaxFloor = maxFloor;
        for (int i = 1; i <= maxFloor; i++)
        {
            floors.Add(new Floor($"Floor {i}"));
        }

        // By default, the elevator starts on the first floor with its doors closed
        CurrentFloor = 0;
        DoorOpen = false;
    }

    public void OpenDoors()
    {
        if (!DoorOpen)
        {
            Console.WriteLine("Opening doors");
            DoorOpen = true;
        }
        else
        {
            Console.WriteLine("Doors are already open.");
        }
    }

    public void CloseDoors()
    {
        if (DoorOpen)
        {
            Console.WriteLine("Closing doors");
            DoorOpen = false;
        }
        else
        {
            Console.WriteLine("Doors are already closed.");
        }
    }

    public void GoToFloor(int floorNumber)
    {
        if (floorNumber >= 1 && floorNumber <= MaxFloor)
        {
            int targetFloor = floorNumber - 1;
            if (targetFloor != CurrentFloor)
            {
                Console.WriteLine($"Moving from {floors[CurrentFloor].Name} to {floors[targetFloor].Name}");
                CurrentFloor = targetFloor;
                OpenDoors(); // Automatically open doors when reaching a floor
            }
            else
            {
                Console.WriteLine($"Already on {floors[CurrentFloor].Name}");
            }
        }
        else
        {
            Console.WriteLine("Invalid floor number.");
        }
    }

    public void ReportStatus()
    {
        Console.WriteLine($"Current Floor: {floors[CurrentFloor].Name}");
        Console.WriteLine($"Doors are {(DoorOpen ? "open" : "closed")}");
    }
}

class Floor
{
    public string Name { get; }

    public Floor(string name)
    {
        Name = name;
    }
}