namespace EmployeePayrollSystem.Services;


using System.Threading;
using EmployeePayrollSystem.Models;

public static class PayrollService
{
    public static void GeneratePayrollReport()
    {
     for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Generating Payroll Report...");
            Thread.Sleep(1000);
        }

    }

    public static async Task ProcessSalary(Employee emp)
    {
         Console.WriteLine(
        $"Processing Salary for {emp.EmployeeName}");

    await Task.Delay(2000);

    Console.WriteLine($"Salary Processed for  {emp.EmployeeName}");
        
    }

    public static async Task GeneratePayslipAsync()
    {
        Console.WriteLine("Generating PDF....");
        await Task.Delay(3000);

         Console.WriteLine("Payslip Generated");

    }

}

