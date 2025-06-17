using System;

class Program
{
    static void Main()
    {
        //Changing_Datatype changingDatatype = new Changing_Datatype();
        //int intResult = changingDatatype.Add(5, 10);
        //float floatResult = changingDatatype.Add(5.5f, 10.2f);
        //Console.WriteLine($"Integer Addition Result: {intResult}");
        //Console.WriteLine($"Float Addition Result: {floatResult}");

        //Changing_number_of_arguments changingNumberOfArguments = new Changing_number_of_arguments();    
        //int areaSquare = changingNumberOfArguments.CalculateArea(5);
        //int areaRectangle = changingNumberOfArguments.CalculateArea(5, 10);
        //Console.WriteLine($"Area of Square: {areaSquare}");
        //Console.WriteLine($"Area of Rectangle: {areaRectangle}");

        //RBI_Bank rbiBank = new RBI_Bank();
        //rbiBank.CalculateInterest(10000, 5, 2);
        //HDFC hdfc = new HDFC();
        //hdfc.CalculateInterest(10000, 5, 2);
        //SBI sbi = new SBI();
        //sbi.CalculateInterest(10000, 5, 2);
        //ICICI icici = new ICICI();
        //icici.CalculateInterest(10000, 5, 2);

        //Hospital hospital = new Hospital();
        //hospital.HospitalDetails();
        //Apollo apollo = new Apollo();
        //apollo.HospitalDetails();
        //Wockhardt wockhardt = new Wockhardt();
        //wockhardt.HospitalDetails();
        //Gokul_Superspeciality gokulSuperspeciality = new Gokul_Superspeciality();
        //gokulSuperspeciality.HospitalDetails();

        //Area_Calculate areaCalculate = new Area_Calculate();
        //double areaSquare = areaCalculate.CalculateArea(5);
        //double areaRectangle = areaCalculate.CalculateArea(5, 10);
        //double areaCircle = areaCalculate.CalculateArea(7, true);
        //Console.WriteLine($"Area of Square: {areaSquare}");
        //Console.WriteLine($"Area of Rectangle: {areaRectangle}");
        //Console.WriteLine($"Area of Circle: {areaCircle}");

        BankAccount bankAccount = new BankAccount("Jeet Bhalodi", 30000);
        bankAccount.Deposit(5000);
        bankAccount.Deposit(2000, "CHK12345");
        bankAccount.Withdraw(1000);
        bankAccount.Withdraw(1500, "CHK67890");
        bankAccount.Withdraw(50000);
    }

}