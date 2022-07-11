using System;

public class Book : Document
{
	public string isbn;

	public int numberOfPage;

	public Book(string isbn, int numberOfPage, string title, string author, DateTime year, string genre, bool isAvailable, int inShelf) : base(title, author, year, genre, isAvailable, inShelf)
    {
        this.isbn = isbn;

        this.numberOfPage = numberOfPage;
    }
}
