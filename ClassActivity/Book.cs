public class Book{
    string _author;
    string _name;
    int _timesRead;

    bool _available;
}

public Book(string HarryPotter, string JK Rolling)
{
    _author = author;
    _name = name;
    _timeRead = 0;
    _available = true;
}

public void Display()
{
    System.Console.WriteLine();
}

public bool HasAuthor (string author)
{
    return _author.Contains(author);
}