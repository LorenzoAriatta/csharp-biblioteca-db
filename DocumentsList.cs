using System;

public class DocumentsList
{
	public List<Document> documents;
	
	public void AddDocument(int serialNumber, int runningTime, string title, string author, DateTime year, string genre, bool isAvailable, int inShelf)
    {
		Dvd dvd = new Dvd(serialNumber, runningTime, title, author, year, genre, isAvailable, inShelf);
		documents.Add(dvd);
    }

	public void AddDocument(string isbn, int numberOfPage, string title, string author, DateTime year, string genre, bool isAvailable, int inShelf)
	{
		Book book = new Book(isbn, numberOfPage, title, author, year, genre, isAvailable, inShelf);
		documents.Add(book);
	}

	public Document FindDoc(string query)
    {
		foreach (Dvd dvd in documents)
		{
			if (query == dvd.title || query == dvd.genre || (query == dvd.title && query == dvd.author))
			{
				return dvd;
			}
		}
		foreach (Book book in documents)
        {
			if(query == book.title || query == book.isbn || (query == book.title && query == book.author))
            {
				return book;
            }
        }

		return null;
    }
}
