namespace ConsoleApp1;

public class Bank
{
    public string Name { get; set; }
    public List<Customer> Customers { get; set; }
    public List<Employee> Employees { get; set; }
    public List<BankAccount> BankAccounts { get; set; }
    public List<Loan> Loans { get; set; }

    public Bank(string name)
    {
        Name = name;
        Customers = new List<Customer>();
        Employees = new List<Employee>();
        BankAccounts = new List<BankAccount>();
        Loans = new List<Loan>();
    }
}