using System;
using System.IO;

class Load
{
    public static void LoadJournal(Write writeObject)
    {
        Console.WriteLine("Enter the filename to load:");
        string filename = Console.ReadLine();
        try
        {
            string[] entries = File.ReadAllLines(filename);

            foreach (var entry in entries)
            {
                writeObject.user_input(entry);
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
