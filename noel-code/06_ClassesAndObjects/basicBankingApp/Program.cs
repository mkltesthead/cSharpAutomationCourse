using System;

public class basicBankingApp
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Basic Banking App");

        // Create a bank customer
        Console.Write("Enter customer name: ");
        string name = Console.ReadLine();

        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();

        Console.Write("Enter initial balance: ");
        double initialBalance = Convert.ToDouble(Console.ReadLine());

        BankCustomer customer = new BankCustomer(name, accountNumber, initialBalance);

        Console.WriteLine("Bank Customer Created");

        // Perform transactions
        Console.Write("Enter deposit amount: ");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        customer.Deposit(depositAmount);

        Console.Write("Enter withdrawal amount: ");
        double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
        customer.Withdraw(withdrawalAmount);

        // Display account details
        Console.WriteLine("Account Details:");
        customer.DisplayAccountDetails();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

public class BankAccount
{
    private string accountNumber;
    private double balance;

    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
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
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Current Balance: {balance:C2}");
    }
}

public class BankCustomer
{
    private string name;
    private BankAccount account;

    public BankCustomer(string name, string accountNumber, double initialBalance)
    {
        this.name = name;
        this.account = new BankAccount(accountNumber, initialBalance);
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
        Console.WriteLine($"Customer Name: {name}");
        account.DisplayBalance();
    }
}