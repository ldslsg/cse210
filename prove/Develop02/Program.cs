using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   
        Write write_object = new Write();
        int i = 0;

        while (i != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What was the best part of my day?");
            
            string test2 = (Console.ReadLine());
            i = int.Parse(test2);

            if (i == 1)
            {
                Console.WriteLine("Type your journal entry here:");
                write_object.user_input(Console.ReadLine());
            }
            else if(i == 2)
            {
                Console.WriteLine("This is your entry:");
                Console.WriteLine(write_object.get_journal_entry()); 
            }
            else if(i == 3)
            {
                Console.WriteLine("Enter the filename to load:");
                string filename = Console.ReadLine();
                LoadJournal(write_object, filename);
            }
            else if(i == 4)
            {
                Console.WriteLine("Enter the filename to save as a .csv:");
                string filename = Console.ReadLine() + ".csv";
                SaveJournalAsCSV(write_object, filename);
            }
        }
    }

    static void LoadJournal(Write writeObject, string filename)
    {
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

    static void SaveJournalAsCSV(Write writeObject, string filename)
    {
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

public class Write
{
    string journal_entry = null;

    public void user_input(string entry)
    {
        journal_entry = entry;
    }

    public string get_journal_entry()
    {
        return journal_entry;
    }
}
