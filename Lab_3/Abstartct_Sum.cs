abstract class Abstartct_Sum
{
    abstract public void SumOfTwo(int a, int b);

    abstract public void SumOfThree(int a, int b, int c);
}

class Calculate : Abstartct_Sum
{
    public override void SumOfTwo(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine($"Sum of two numbers: {sum}");
    }
    public override void SumOfThree(int a, int b, int c)
    {
        int sum = a + b + c;
        Console.WriteLine($"Sum of three numbers: {sum}");
    }
}
