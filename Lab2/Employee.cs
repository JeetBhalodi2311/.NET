using System;

interface Gross
{
    void Gross_sal();
}

class Employee
{
    protected string Name;

    public Employee(string name)
    {
        Name = name;
    }

    public void basic_sal(double basic)
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Basic Salary: {basic}");
    }
}

class Salaryy : Employee, Gross
{
    private double HRA, TA, DA, GrossSalary;

    public Salaryy(string name, double hra, double ta, double da) : base(name)
    {
        HRA = hra;
        TA = ta;
        DA = da;
    }

    public void Disp_sal()
    {
        Console.WriteLine($"HRA: {HRA}");
        Console.WriteLine($"TA: {TA}");
        Console.WriteLine($"DA: {DA}");
    }

    public void Gross_sal()
    {
        GrossSalary = HRA + TA + DA;
        Console.WriteLine($"Gross Salary: {GrossSalary}");
    }
}
