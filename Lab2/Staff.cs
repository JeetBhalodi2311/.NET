class Staff
{
    public string Name;
    public string Department;
    public string Designation;
    public int Experience;
    public int Salary;


    public void GetStaffDetails()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter Staff Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Department: ");
            Department = Console.ReadLine();
            Console.Write("Enter Designation: ");
            Designation = Console.ReadLine();
            Console.Write("Enter Years of Experience: ");
            Experience = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void DisplayStaffDetails()
    {
        if (Designation == "HOD" || Designation == "hod")
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
        }   
    }
}

