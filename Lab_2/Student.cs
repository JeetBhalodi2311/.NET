class Student
{
    public int Enrollment_No;
    public string Student_Name;
    public int Semester;
    public double CPI;
    public double SPI;

    public Student(int enrollmentNo, string studentName, int semester, double cpi, double spi)
    {
        this.Enrollment_No = enrollmentNo;
        this.Student_Name = studentName;
        this.Semester = semester;
        this.CPI = cpi;
        this.SPI = spi;
    }

    public void DisplayStudentDetails()
    {
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine($"Enrollment Number: {Enrollment_No}");
        Console.WriteLine($"Name: {Student_Name}");
        Console.WriteLine($"Semester: {Semester}");
        Console.WriteLine($"CPI: {CPI}");
        Console.WriteLine($"SPI: {SPI}");
    }
}

