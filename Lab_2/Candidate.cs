class Candidate
{
    public int ID;
    public string Name;
    public int Age;
    public double Weight;
    public double Height;
    public void GetCandidateDetails()
    {
        Console.Write("Enter Candidate ID: ");
        ID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Candidate Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Candidate Age: ");
        Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Candidate Weight (kg): ");
        Weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Candidate Height (m): ");
        Height = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayCandidateDetails()
    {
        Console.WriteLine("\nCandidate Details:");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Height: {Height} m");
    }
}

