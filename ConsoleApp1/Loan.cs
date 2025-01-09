namespace DefaultNamespace;

public class Loan
{
    public Customer Borrower { get; set; }
    public decimal Amount { get; set; }
    public double InterestRate { get; set; }
    public DateTime DueDate { get; set; }

    public Loan(Customer borrower, decimal amount, double interestRate, DateTime dueDate)
    {
        Borrower = borrower;
        Amount = amount;
        InterestRate = interestRate;
        DueDate = dueDate;
    }
}
