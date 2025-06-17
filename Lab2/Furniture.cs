class Furniture
{
    public string material;
    public int price;

    public void GetFurnitureDetails()
    {
        Console.Write("Enter Material: ");
        material = Console.ReadLine();
        Console.Write("Enter Price: ");
        price = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayFurnitureDetails()
    {
        Console.WriteLine("\nFurniture Details:");
        Console.WriteLine($"Material: {material}");
        Console.WriteLine($"Price: {price:C}");
    }
}

class Table : Furniture
{
    public int Height;
    public int surface_area;
    
    public void GetTableDetails()
    {
        GetFurnitureDetails();
        Console.Write("Enter Height: ");
        Height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Surface Area: ");
        surface_area = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayTableDetails()
    {
        DisplayFurnitureDetails();
        Console.WriteLine($"Height: {Height} cm");
        Console.WriteLine($"Surface Area: {surface_area} sq. cm");
    }

}