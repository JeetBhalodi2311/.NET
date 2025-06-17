interface calculate
{
    public void Addition(int a,int b);
    public void Subtraction(int a,int b);

}

class Result : calculate
{
    public void Addition(int a, int b)
    {
        Console.WriteLine("Sum: " + (a + b));

    }

    public void Subtraction(int a, int b) 
    {
        Console.WriteLine("Difference: " + (a - b));
    }
}