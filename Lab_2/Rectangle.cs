class Rectangle
{
    public int length;
    public int width;
    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;

        int Area = length * width;
        Console.WriteLine($"Area of Rectangle: {Area}");
    }
}
