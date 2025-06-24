class Dictionary_Example
{
    private Dictionary<int, string> data = new Dictionary<int, string>();

    public void Add(int key, string value)
    {
        if (!data.ContainsKey(key))
        {
            data.Add(key, value);
            Console.WriteLine($"Added: [{key}] = {value}");
        }
        else
        {
            Console.WriteLine("Key already exists!");
        }
    }

    public void Remove(int key)
    {
        if (data.Remove(key))
        {
            Console.WriteLine($"Removed key: {key}");
        }
        else
        {
            Console.WriteLine("Key not found!");
        }
    }

    public void ContainsKey(int key)
    {
        Console.WriteLine(data.ContainsKey(key)
            ? $"Key {key} exists."
            : $"Key {key} does not exist.");
    }

    public void ContainsValue(string value)
    {
        Console.WriteLine(data.ContainsValue(value)
            ? $"Value \"{value}\" exists."
            : $"Value \"{value}\" does not exist.");
    }

    public void Clear()
    {
        data.Clear();
        Console.WriteLine("Dictionary cleared.");
    }

    public void Display()
    {
        Console.WriteLine("Current Dictionary:");
        if (data.Count == 0)
        {
            Console.WriteLine("[Empty]");
        }
        else
        {
            foreach (var kvp in data)
            {
                Console.WriteLine($"[{kvp.Key}] = {kvp.Value}");
            }
        }
    }

}



    

    
        

