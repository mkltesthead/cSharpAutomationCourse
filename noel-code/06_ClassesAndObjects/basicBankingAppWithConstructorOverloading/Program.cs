using System;

class basicBankingAppWithConstructorOverloading
{
    static void Main(string[] args)
    {
        // Create a bank customer with three different constructors
        BankCustomer customer1 = new BankCustomer("John Doe");
        BankCustomer customer2 = new BankCustomer("Jane Smith", "123456789");
        BankCustomer customer3 = new BankCustomer("David Johnson", "987654321", 1000.0);

        // Deposit money for each customer
        customer1.Deposit(500.0);
        customer2.Deposit(1000.0);
        customer3.Deposit(2000.0);

        // Withdraw money from each customer
        customer1.Withdraw(200.0);
        customer2.Withdraw(500.0);
        customer3.Withdraw(1500.0);

        // Display account details for each customer
        customer1.DisplayAccountDetails();
        customer2.DisplayAccountDetails();
        customer3.DisplayAccountDetails();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

public class BankAccount
{
    private string accountNumber;
    private double balance;

    // Default constructor
    public BankAccount()
    {
        accountNumber = "Unknown";
        balance = 0.00;
    }

    // Constructor with accountNumber parameter
    public BankAccount(string accNumber)
    {
        accountNumber = accNumber;
        balance = 0.00;
    }

    // Constructor with accountNumber and initialBalance parameters
    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Current Balance: " + balance);
    }
}

public class BankCustomer
{
    private string name;
    private BankAccount account;

    public BankCustomer(string customerName)
    {
        name = customerName;
        account = new BankAccount();
    }

    public BankCustomer(string customerName, string accNumber)
    {
        name = customerName;
        account = new BankAccount(accNumber);
    }

    public BankCustomer(string customerName, string accNumber, double initialBalance)
    {
        name = customerName;
        account = new BankAccount(accNumber, initialBalance);
    }

    public void Deposit(double amount)
    {
        account.Deposit(amount);
    }

    public void Withdraw(double amount)
    {
        account.Withdraw(amount);
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Customer Name: " + name);
        account.DisplayBalance();
    }
}