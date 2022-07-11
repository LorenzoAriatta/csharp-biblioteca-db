using System;

public class LendingsList
{
	public List<Lending> lendings;

	public LendingsList()
	{
		this.lendings = new List<Lending>();
	}

	public void NewLending(User onLoan, Document document)
    {
		Lending newLending = new Lending(onLoan, document);
		lendings.Add(newLending);
    }

	public Lending SearchLending(string query)
    {
		foreach(Lending lending in lendings)
        {
			if(query == lending.onLoanDocument.title)
            {
				return lending;
            }
        }

		return null;
    }
}
