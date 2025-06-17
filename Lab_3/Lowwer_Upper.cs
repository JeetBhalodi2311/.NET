class Lowwer_Upper
{
    public void Run()
    {
        string str = "Hello, World!";

        String result = "";

        foreach (char c in str)
        {
            if (char.IsLower(c))
            {
                result += char.ToUpper(c);
            }
            else if (char.IsUpper(c))
            {
                result += char.ToLower(c);
            }
            else
            {
                result += c;
            }
        }
        Console.WriteLine("Original String: " + str);
        Console.WriteLine("Converted String: " + result);

    }
}
