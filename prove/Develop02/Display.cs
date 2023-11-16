

class Display
{
    public static void DisplayEntry(Write writeObject)
    {
        Console.WriteLine("This is your entry:");
        Console.WriteLine(string.Join(Environment.NewLine, writeObject.get_journal_entry())); 
    }
}
