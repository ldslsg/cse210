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