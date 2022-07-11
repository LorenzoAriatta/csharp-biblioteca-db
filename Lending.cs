using System;

public class Lending
{
	public User onLoan;

	public Document onLoanDocument;

	public DateTime startOn;

	public DateTime endOn;

	double loanPeriod;

	public Lending(User onLoan, Document onLoanDocument)
    {
        this.onLoan = onLoan;

        this.onLoanDocument = onLoanDocument;

        this.startOn = new DateTime();

        this.endOn = new DateTime().AddDays(loanPeriod);
    }
}
