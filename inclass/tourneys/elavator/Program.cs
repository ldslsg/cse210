class Program
{
    static void Main()
    {
        Elevator elevator = new Elevator();
        
        elevator.ReportStatus();

        elevator.OpenDoors();
        elevator.CloseDoors();

        elevator.GoToFloor(1);
        elevator.ReportStatus();

        elevator.GoToFloor(2);
        elevator.ReportStatus();
    }
}