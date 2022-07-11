using System;

public class Dvd : Document
{
	public int serialNumber;

    public int runningTime;

	public Dvd(int serialNumber, int runningTime, string title, string author, DateTime year, string genre, bool isAvailable, int inShelf) : base(title, author, year, genre, isAvailable, inShelf)
    {
        this.serialNumber = serialNumber;

        this.runningTime = runningTime;
    }
}
