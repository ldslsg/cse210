public class VIP_Elevator : Elevator
{
    private string accessCode;

    public VIP_Elevator(string code)
    {
        accessCode = code;
    }

    public void EnterCode(string code)
    {
        if (code == accessCode)
        {
            OpenDoors();
            Console.WriteLine("VIP access granted. Doors are open. You can now choose a floor.");
        }
        else
        {
            Console.WriteLine("Invalid access code. Doors remain closed.");
        }
    }
}