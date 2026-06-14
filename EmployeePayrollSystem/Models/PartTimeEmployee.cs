using  EmployeePayrollSystem.Models;


class PartTimeEmployee : Employee
{

private double HoursWorked;
private double HourlyRate;
    public PartTimeEmployee(string Name,string EmployeeId,double HoursWorked,double HourlyRate): base(Name, EmployeeId)
    {
        this.HourlyRate=HourlyRate;
        this.HoursWorked=HoursWorked;
    }

    public override double CalculateSalary()
    {
       double Salary=HourlyRate*HoursWorked;

       return Salary;
    }
}



