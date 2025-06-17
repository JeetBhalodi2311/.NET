class Salary
{
    public double Basic;
    public double HRA;
    public double DA;
    public double TA;

    public Salary(double Basic, double TA, double HRA = 0.2, double DA = 0.1)
    {
        this.Basic = Basic;
        this.HRA = (HRA/100)*Basic;
        this.DA = (DA/100)*Basic;
        this.TA = TA;
    }

    public void CalculateSalary()
    {
        double GrossSalary = this.Basic + this.HRA + this.DA + this.TA;
        Console.WriteLine($"Gross Salary: {GrossSalary}");
    }
}
