class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();

        // Add multiple scriptures to the library
        library.AddScripture("John 3:16", "For God so loved the world...");
        library.AddScripture("Proverbs 3:5-6", "Trust in the LORD with all your heart...");

        while (true)
        {
            Scripture randomScripture = library.GetRandomScripture();
            if (randomScripture == null)
            {
                Console.WriteLine("No scriptures in the library.");
                break;
            }

            while (!randomScripture.IsComplete())
            {
                randomScripture.Display();
                Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    return;

                randomScripture.HideWords(3); // Hide 3 random words
    }
}
    }}