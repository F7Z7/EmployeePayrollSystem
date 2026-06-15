namespace EmployeePayrollSystem.Models;



public abstract class Employee
{
    protected string Name;
    protected string EmployeeId;

 public string EmployeeName => Name;
    public Employee(string Name, string EmployeeId)
    {
        this.Name=Name;
        this.EmployeeId=EmployeeId;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Employee {Name} : Id {EmployeeId}");
    }

    public abstract double CalculateSalary();
}