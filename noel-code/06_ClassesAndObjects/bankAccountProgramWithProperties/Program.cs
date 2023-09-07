using System;

class bankAccountProgramWithProperties
{
    static void Main(string[] args)
    {
        BankCustomer customer = new BankCustomer("Jenny Smith", "465330021-1");

        Console.WriteLine("Initial Account Details:");
        customer.DisplayAccountDetails();

        Console.Write("\nEnter an amount to deposit: ");
        double depositAmount = double.Parse(Console.ReadLine());
        customer.Deposit(depositAmount);

        Console.Write("Enter an amount to withdraw: ");
        double withdrawAmount = double.Parse(Console.ReadLine());
        customer.Withdraw(withdrawAmount);

        Console.WriteLine("\nUpdated Account Details:");
        customer.DisplayAccountDetails();

        Console.Write("\nEnter a new customer name: ");
        customer.Name = Console.ReadLine();

        Console.WriteLine("\nUpdated Account Details with New Customer Name:");
        customer.DisplayAccountDetails();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
public class BankAccount
{
    public string AccountNumber { get; }
    public double Balance { get; private set; }

    public BankAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0.0;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}

public class BankCustomer
{
    public string Name { get; set; }
    public BankAccount Account { get; }

    public BankCustomer(string name, string accountNumber)
    {
        Name = name;
        Account = new BankAccount(accountNumber);
    }

    public void Deposit(double amount)
    {
        Account.Deposit(amount);
    }

    public void Withdraw(double amount)
    {
        Account.Withdraw(amount);
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Customer Name: " + Name);
        Console.WriteLine("Account Number: " + Account.AccountNumber);
        Console.WriteLine("Current Balance: " + Account.Balance);
    }
}