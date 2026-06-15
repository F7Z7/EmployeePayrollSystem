using  EmployeePayrollSystem.Models;


public class FullTimeEmployee : Employee
{

 private double monthlySalary;
    public FullTimeEmployee(string Name,string EmployeeId,double monthlySalary): base(Name, EmployeeId)
    {
        this.monthlySalary=monthlySalary;
    }

    public override double CalculateSalary()
    {
        return monthlySalary;
    }
}



