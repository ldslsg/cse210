using System;
using System.IO;

class Save
{
    public static void SaveJournalAsCSV(Write writeObject)
    {
        Console.WriteLine("Enter the filename to save as a .csv:");
        string filename = Console.ReadLine() + ".csv";
        try
        {
            // Assuming you have a collection of entries, you can format them as CSV
            string[] entries = { writeObject.get_journal_entry() };
            string csvContent = string.Join(Environment.NewLine, entries);

            File.WriteAllText(filename, csvContent);
            Console.WriteLine("Journal saved successfully as a .csv file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }
}
