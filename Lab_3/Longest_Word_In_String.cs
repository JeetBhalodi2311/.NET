class Longest_Word_In_String
{
    public void Run(string input)
    {
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = string.Empty;
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        Console.WriteLine("The longest word is: " + longestWord);
    }
}
