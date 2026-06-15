using EmployeePayrollSystem.Models;

namespace EmployeePayrollSystem.Services;



public static class ReportService{
    public static string GetEarnerType(Employee emp)
    {
        double salary = emp.CalculateSalary();

        if (salary >= 50000)
            return "High Earner";

        else if (salary >= 20000)
            return "Medium Earner";

        return "Low Earner";
    }
}