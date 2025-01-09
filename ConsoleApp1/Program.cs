using DefaultNamespace;

public class Program
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank("Quicksilver Bank");

        Customer customer1 = new Customer("Alice Johnson", "123 Main St");
        Customer customer2 = new Customer("Bob Smith", "456 Elm St");

        bank.Customers.Add(customer1);
        bank.Customers.Add(customer2);

        BankAccount account1 = new BankAccount("123456", customer1);
        BankAccount account2 = new BankAccount("789012", customer2);

        bank.BankAccounts.Add(account1);
        bank.BankAccounts.Add(account2);

        account1.Deposit(1000);
        account2.Deposit(500);
        account1.Withdraw(200);

        Console.WriteLine($"Account {account1.AccountNumber}, Owner: {account1.Owner.Name}, Balance: {account1.Balance}");
        Console.WriteLine($"Account {account2.AccountNumber}, Owner: {account2.Owner.Name}, Balance: {account2.Balance}");

        Loan loan = new Loan(customer1, 5000, 3.5, DateTime.Now.AddYears(1));
        bank.Loans.Add(loan);

        Console.WriteLine($"Loan for {loan.Borrower.Name}, Amount: {loan.Amount}, Interest Rate: {loan.InterestRate}%");
    }
}