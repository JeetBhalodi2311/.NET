class RBI_Bank
{
    public void CalculateInterest(double principal, double rate, int years)
    {
        double interest = (principal * rate * years) / 100;
        Console.WriteLine("Interest as per RBI guidelines: " + interest);
    }
}

class HDFC : RBI_Bank
{
    public void CalculateInterest(double principal, double rate, int years)
    {
    double interest = (principal * (rate + 0.5) * years) / 100; 
    Console.WriteLine("HDFC Interest: " + interest);
    }
}

class SBI : RBI_Bank
{
    public void CalculateInterest(double principal, double rate, int years)
    {
        double interest = (principal * (rate + 0.3) * years) / 100; 
        Console.WriteLine("SBI Interest: " + interest);
    }
}
class ICICI : RBI_Bank
{
    public void CalculateInterest(double principal, double rate, int years)
    {
        double interest = (principal * (rate + 0.4) * years) / 100;
        Console.WriteLine("ICICI Interest: " + interest);
    }
}



