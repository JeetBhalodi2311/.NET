class IndexOutOfRange
{
    public void Run()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        try
        {
            Console.Write("Enter an index to access the array (0-4): ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value at index " + index + ": " + numbers[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Index is out of range!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
