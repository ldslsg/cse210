using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Reference
{
    public string Book { get; private set; }
    public int StartChapter { get; private set; }
    public int EndChapter { get; private set; }
    public int StartVerse { get; private set; }
    public int EndVerse { get; private set; }

    public Reference(string reference)
    {
        Book = string.Empty; // Initialize to a default value
        ParseReference(reference);
    }

    private void ParseReference(string reference)
    {
        // Regular expression pattern to match references like "John 3:16" or "Proverbs 3:5-6".
        string pattern = @"(\D+) (\d+):(\d+)(?:-(\d+))?";
        Match match = Regex.Match(reference, pattern);

        if (match.Success)
        {
            Book = match.Groups[1].Value;
            StartChapter = int.Parse(match.Groups[2].Value);
            StartVerse = int.Parse(match.Groups[3].Value);

            if (match.Groups[4].Success)
            {
                EndChapter = StartChapter;
                EndVerse = int.Parse(match.Groups[4].Value);
            }
        }
        else
        {
            throw new ArgumentException("Invalid reference format");
        }
    }
}
