
public class Write
{
    private List<string> journal_entry = new List<string>();

    public void user_input(string input)
    {
        journal_entry.Add(input);
    }

    public string[] get_journal_entry()
    {
        return journal_entry.ToArray();
    }
}