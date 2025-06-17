using System;

class Distance
{
    private double dist1, dist2, dist3;

    public Distance(double dist1, double dist2)
    {
        this.dist1 = dist1;
        this.dist2 = dist2;
        this.dist3 = 0;
    }

    public void AddDistances()
    {
        dist3 = dist1 + dist2;
    }
    
    public void DisplayAddition()
    {
        Console.WriteLine("Distance 1: " + dist1);
        Console.WriteLine("Distance 2: " + dist2);
        Console.WriteLine("Total Distance: " + dist3);
    }
}

