class Hospital
{
    public  void HospitalDetails()
    {
        Console.WriteLine("General hospital details.");
    }
}

class Apollo : Hospital
{
    public void HospitalDetails()
    {
        Console.WriteLine("Apollo Hospital - Known for advanced healthcare and technology.");
    }
}

class Wockhardt : Hospital
{
    public void HospitalDetails()
    {
        Console.WriteLine("Wockhardt Hospital - Excellence in cardiology and neurology.");
    }
}

class Gokul_Superspeciality : Hospital
{
    public void HospitalDetails()
    {
        Console.WriteLine("Gokul Superspeciality - Leading in multispeciality treatments.");
    }
}

