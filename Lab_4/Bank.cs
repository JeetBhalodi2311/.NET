using System;

class BankAccount
{
    private string accountHolderName;
    private double balance;

    public BankAccount(string accountHolderName, double initialBalance)
    {
        this.accountHolderName = accountHolderName;
        this.balance = initialBalance;
        Console.WriteLine($"Account created for {accountHolderName} with initial balance: {initialBalance}");
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Cash deposited: {amount}. New balance: {balance}");
    }

    public void Deposit(double amount, string checkNumber)
    {
        balance += amount;
        Console.WriteLine($"Check deposited (Check No: {checkNumber}): {amount}. New balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Cash withdrawn: {amount}. Remaining balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }

    public void Withdraw(double amount, string checkNumber)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Check withdrawal (Check No: {checkNumber}): {amount}. Remaining balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }
}
