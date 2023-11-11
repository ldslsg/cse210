using System;

class Display
{
    public static void DisplayEntry(Write writeObject)
    {
        Console.WriteLine("This is your entry:");
        Console.WriteLine(writeObject.get_journal_entry()); 
    }
}
