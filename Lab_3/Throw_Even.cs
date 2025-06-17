class Throw_Even
{
    public void Run(int n)
    {
        try
        {
            if (n % 2 != 0)
            {
                throw new Exception("The number is not even.");
            }
            Console.WriteLine("The number is even: " + n);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");

        }
    }
}
