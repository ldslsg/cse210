public class Book : Lonable
{
    private string _title;
    private string _isbn;
    private int _upc;

    public Book(string title, string isbn, int upc)
    {
        _title = title;
        _isbn = isbn;
        _upc = upc;
    }

    public override void Display()
    {
        ShowBookDetails();

    }

    public void ShowBookDetails()
    {
        System.Console.WriteLine($"{_title} ; {_isbn} ;; {_upc} {_isCheckedIn}");
    }
}