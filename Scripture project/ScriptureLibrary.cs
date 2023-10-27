class ScriptureLibrary
{
    private List<Scripture> scriptures = new List<Scripture>();
    private Random random = new Random();

    public void AddScripture(string reference, string text)
    {
        scriptures.Add(new Scripture(reference, text));
    }

    public Scripture GetRandomScripture()
    {
        if (scriptures.Count == 0)
        {
            return null;
        }

        int randomIndex = random.Next(scriptures.Count);
        return scriptures[randomIndex];
    }
}
