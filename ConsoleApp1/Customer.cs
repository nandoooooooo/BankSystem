namespace ConsoleApp1;

public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<BankAccount> Accounts { get; set; }

    public Customer(string name, string address)
    {
        Name = name;
        Address = address;
        Accounts = new List<BankAccount>();
    }
}