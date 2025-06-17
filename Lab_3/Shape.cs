interface Shape
{
    public void Circle();
    public void Triangle();

    public void Square();
}

class CalculateShape : Shape
{
    public void Circle()
    {
        Console.WriteLine("Calculating area of Circle");
        double radius = 5.0; 
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area of Circle: {area}");
    }
    public void Triangle()
    {
        Console.WriteLine("Calculating area of Triangle");
        double baseLength = 4.0; 
        double height = 3.0; 
        double area = 0.5 * baseLength * height;
        Console.WriteLine($"Area of Triangle: {area}");
    }
    public void Square()
    {
        Console.WriteLine("Calculating area of Square");
        double side = 4.0; 
        double area = side * side;
        Console.WriteLine($"Area of Square: {area}");
    }
}

