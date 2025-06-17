class DivideByZeroException
{
    public void Run()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());
            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (System.DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integers.");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
