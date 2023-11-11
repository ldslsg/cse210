class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> words;
    private Random random = new Random();
    public int hiddenCount = 0;

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool IsComplete()
    {
        return hiddenCount == words.Count;
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", words.Select(word => word.Display())));
    }

    public void HideWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int randomIndex = random.Next(words.Count);
            if (!words[randomIndex].IsHidden)
            {
                words[randomIndex].IsHidden = true;
                hiddenCount++;
            }
        }
    }
}
