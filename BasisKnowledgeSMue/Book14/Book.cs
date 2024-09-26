namespace BasisKnowledgeSMue.Book;

public class Book
{
    private string title;
    private string author;

    public Book()
    {
        title = "Unknown";
        author = "None";
    }

    public Book(string title) : this()
    {
        this.title = title;
    }

    public Book(string title, string author) : this(title)
    {
        this.author = author;
    }
}