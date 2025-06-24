using System.Collections;

class Hashtable_Example
{
    private Hashtable table = new Hashtable();

    public void Add(object key, object value)
    {
        if (!table.ContainsKey(key))
        {
            table.Add(key, value);
            Console.WriteLine($"Added: [{key}] = {value}");
        }
        else
        {
            Console.WriteLine("Key already exists!");
        }
    }

    public void Remove(object key)
    {
        if (table.ContainsKey(key))
        {
            table.Remove(key);
            Console.WriteLine($"Removed key: {key}");
        }
        else
        {
            Console.WriteLine("Key not found.");
        }
    }

    public void ContainsKey(object key)
    {
        Console.WriteLine(table.ContainsKey(key)
            ? $"Hashtable contains the key: {key}"
            : $"Key {key} does not exist.");
    }

    public void ContainsValue(object value)
    {
        Console.WriteLine(table.ContainsValue(value)
            ? $"Hashtable contains the value: {value}"
            : $"Value {value} not found.");
    }

    public void Clear()
    {
        table.Clear();
        Console.WriteLine("Hashtable cleared.");
    }

    public void Display()
    {
        Console.WriteLine("Current Hashtable:");
        if (table.Count == 0)
        {
            Console.WriteLine("[Empty]");
        }
        else
        {
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine($"[{entry.Key}] = {entry.Value}");
            }
        }
    }

}


    


        
