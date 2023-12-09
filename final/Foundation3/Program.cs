class Program
{
    static void Main(string[] args)
    {
        // Create an address
        Address address = new Address("123 Main St", "Anytown", "Anystate", "12345");

        // Create a lecture
        Lecture lecture = new Lecture("Intro to C#", "A beginner's guide to C#", "11/27/2023", "10:00 AM", address, "John Doe", 100);
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetShortDescription());

        // Create a reception
        Reception reception = new Reception("Company Party", "A fun party for all employees", "12/15/2023", "6:00 PM", address, "rsvp@company.com");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetShortDescription());

        // Create an outdoor gathering
        OutdoorGathering gathering = new OutdoorGathering("Company Picnic", "A picnic for all employees and their families", "06/15/2024", "12:00 PM", address, "Sunny");
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine(gathering.GetShortDescription());
    }
}
