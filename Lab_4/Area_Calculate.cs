class Area_Calculate
{
    public double CalculateArea(double side)
    {
        return side * side;
    }

    public double CalculateArea(double length, double width)
    {
        return length * width;
    }

    public double CalculateArea(double radius, bool isCircle)
    {
        return Math.PI * radius * radius;
    }
}
