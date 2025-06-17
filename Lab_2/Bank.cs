class Bank
{
    public int Account_No;
    public string Email;
    public string User_Name;
    public string Account_Type;
    public double Account_Balance;

    public void GetAccountDetails()
    {
        Console.Write("Enter Account Number: ");
        Account_No = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Email: ");
        Email = Console.ReadLine();
        Console.Write("Enter User Name: ");
        User_Name = Console.ReadLine();
        Console.Write("Enter Account Type (Savings/Current): ");
        Account_Type = Console.ReadLine();
        Console.Write("Enter Account Balance: ");
        Account_Balance = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("\nAccount Details:");
        Console.WriteLine($"Account Number: {Account_No}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"User Name: {User_Name}");
        Console.WriteLine($"Account Type: {Account_Type}");
        Console.WriteLine($"Account Balance: {Account_Balance:C}");
    }
}
