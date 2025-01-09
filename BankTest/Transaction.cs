namespace ConsoleApp1;

public class Transaction
{
    public string Type { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }

    public Transaction(string type, decimal amount)
    {
        Type = type;
        Amount = amount;
        Date = DateTime.Now;
    }
}