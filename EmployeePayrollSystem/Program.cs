using EmployeePayrollSystem.Models;


class Program
{
    
    public static void Main()
    {
        
        Employee emp1 = new FullTimeEmployee(
            "Farzan","T2F1",50000
        );

           Employee emp2 = new PartTimeEmployee(
            "Harry","T2G1",40,250
        );

        
        emp1.DisplayInfo();
        Console.WriteLine($"Salary: {emp1.CalculateSalary()}");

        Console.WriteLine();

        emp2.DisplayInfo();
        Console.WriteLine($"Salary: {emp2.CalculateSalary()}");
    }
}