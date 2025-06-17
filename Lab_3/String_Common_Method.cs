class String_Common_Method
{
    public void Run()
    {
        string str1 = "Hello, World!";
        string str2 = "  C# Programming  ";

        Console.WriteLine("Length of str1: " + str1.Length);

        Console.WriteLine("Uppercase: " + str1.ToUpper());
        Console.WriteLine("Lowercase: " + str1.ToLower());

        Console.WriteLine("Trimmed str2: '" + str2.Trim() + "'");

        Console.WriteLine("Substring (from index 7): " + str1.Substring(7));

        Console.WriteLine("Contains 'World': " + str1.Contains("World"));

        Console.WriteLine("Replace 'World' with 'C#': " + str1.Replace("World", "C#"));

        string[] words = str1.Split(' ');
        Console.WriteLine("Split result:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        string joinedString = string.Join("-", words);
        Console.WriteLine("Joined string: " + joinedString);

        Console.WriteLine("Starts with 'Hello': " + str1.StartsWith("Hello"));
        Console.WriteLine("Ends with '!': " + str1.EndsWith("!"));

        Console.WriteLine("Index of 'World': " + str1.IndexOf("World"));
    }
}


