class ChangeCase
{
    public void Run()
    {
        Console.WriteLine("Enter a string:");
        char ch = Convert.ToChar(Console.ReadLine());

        if (char.IsLower(ch))
        {
            Console.WriteLine("Uppercase: " + char.ToUpper(ch));
        }
        else if (char.IsUpper(ch))
        {
            Console.WriteLine("Lowercase: " + char.ToLower(ch));
        }
        else
        {
            Console.WriteLine("Entered character is not an alphabet.");
        }

    }
}
