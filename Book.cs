using System.Text;

public class Book


{
    // Properties to store key information about the book

    public string Title { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }

   // Constructor used to create a new book with the specified details.
    public Book(string title, string desc, string category, string author, string genre)
    {
        Title = title;
        Description = desc;
        Category = category;
        Author = author;
        Genre = genre;
    }

   // Appends formatted book details to the provided StringBuilder.
    public void AddForWriting(StringBuilder sb)
    {
        sb.Append("Title: ");
        sb.AppendLine(Title);

        sb.Append("Author: ");
        sb.AppendLine(Author);

        sb.Append("Description: ");
        sb.AppendLine(Description);

        sb.Append("Genre: ");
        sb.AppendLine(Genre);

        sb.Append("Category: ");
        sb.AppendLine(Category);

        sb.AppendLine();
    }
}
