class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public string Display()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}