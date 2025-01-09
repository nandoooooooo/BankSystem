namespace DefaultNamespace;

public class BankAccount : ATM
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; private set; }
    public Customer Owner { get; set; }
    public List<Transaction> Transactions { get; set; }

    public BankAccount(string accountNumber, Customer owner)
    {
        AccountNumber = accountNumber;
        Owner = owner;
        Balance = 0;
        Transactions = new List<Transaction>();
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Transactions.Add(new Transaction("Deposit", amount));
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Transactions.Add(new Transaction("Withdraw", amount));
        }
        else
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
    }
}