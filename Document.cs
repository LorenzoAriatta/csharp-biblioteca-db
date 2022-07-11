using System;

public class Document
{
    public string title;

    public string author;

    public DateTime year;

    public string genre;

    public bool isAvailable;

    public int inShelf;

    public Document(string title, string author, DateTime year, string genre, bool isAvailable, int inShelf)
    {
        this.title = title;

        this.author = author;

        this.year = year;

        this.genre = genre;

        this.isAvailable = isAvailable;

        this.inShelf = inShelf;
    }
}
