using System;

class Account_Intrest
{
    protected string accountHolder;
    protected string accountNumber;
    protected double balance;

    public Account_Intrest(string holder, string number, double bal)
    {
        accountHolder = holder;
        accountNumber = number;
        balance = bal;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: " + balance);
    }
}

class Interest : Account_Intrest
{
    private double rateOfInterest;

    public Interest(string holder, string number, double bal, double rate)
        : base(holder, number, bal)
    {
        rateOfInterest = rate;
    }

    public void CalculateInterest()
    {
        double interest = balance * rateOfInterest / 100;
        Console.WriteLine("Interest Earned: " + interest);
    }
}
