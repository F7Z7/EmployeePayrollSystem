using EmployeePayrollSystem.Models;
using EmployeePayrollSystem.Services;
using EmployeePayrollSystem.Utitlities;
using System.Linq;

class Program
{


    public static void ListEmployees(List<Employee> employees)
    {
        Console.WriteLine("\n==================================");
Console.WriteLine("      EMPLOYEE PAYROLL REPORT");
Console.WriteLine("==================================");
        foreach (Employee employee in employees)
        {
            employee.DisplayInfo();
            Console.WriteLine("----------------------------------");
Console.WriteLine($"Name   : {employee.EmployeeName}");
Console.WriteLine($"Salary : ₹{employee.CalculateSalary():N2}");
Console.WriteLine($"Type   : {ReportService.GetEarnerType(employee)}");
Console.WriteLine("----------------------------------");
        }
    }
    public static void FinalReport(List<Employee> employees)
    {
        var highEarners = employees
            .Where(emp => emp.CalculateSalary() >= 50000)
            .Select(emp => emp.EmployeeName);

        Console.WriteLine("\n==================================");
Console.WriteLine("          LINQ REPORT");
Console.WriteLine("==================================");

Console.WriteLine("\nHigh Earners:");

        foreach(string name in highEarners)
        {
            Console.WriteLine(name);
        }

        double totalPayroll=employees.Sum(emp=>emp.CalculateSalary());
       Console.WriteLine($"Total Payroll: {totalPayroll}");

       var highestEarner=employees.OrderByDescending(emp=>emp.CalculateSalary()).First();

       Console.WriteLine($"Highest Paid Employee {highestEarner.EmployeeName}");

    }

    public static async Task Main()
    {

        List<Employee> emplist = new List<Employee>();


        while (true)
        {
            Console.WriteLine("Choose Type of Employee:  F for Full time : P for Part time");
            char type = Console.ReadLine().ToUpper()[0];

            if (type == 'F')
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter ID:");
                string id = Console.ReadLine();

                double salary = InputValidator.GetDouble("Monthly Salary");


                Employee emp = new FullTimeEmployee(name, id, salary);
                emplist.Add(emp);
            }
            else if (type == 'P')
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter ID:");
                string id = Console.ReadLine();


                double HoursWorked = InputValidator.GetDouble("Enter Hours Worked:");


                double Wage = InputValidator.GetDouble("Enter Wage");

                Employee emp = new PartTimeEmployee(name, id, HoursWorked, Wage);

                emplist.Add(emp);



            }

            Console.WriteLine("Add another employee? (Y/N)");

            char choice = Console.ReadLine().ToUpper()[0];

            if (choice == 'N')
                break;

        }
       

        List<Task> tasks = new();

        foreach (Employee emp in emplist)
        {
            tasks.Add(
                PayrollService.ProcessSalary(emp)
            );
        }

        await Task.WhenAll(tasks);
        
         Thread reportThread = new Thread(PayrollService.GeneratePayrollReport);
        reportThread.Start();
        reportThread.Join();

        // Employee emp1 = new FullTimeEmployee(
        //     "Farzan","T2F1",50000
        // );

        //    Employee emp2 = new PartTimeEmployee(
        //     "Harry","T2G1",40,250
        // );


        // emp1.DisplayInfo();
        // Console.WriteLine($"Salary: {emp1.CalculateSalary()}");

        // Console.WriteLine();

        // emp2.DisplayInfo();
        // Console.WriteLine($"Salary: {emp2.CalculateSalary()}");


        ListEmployees(emplist);
        FinalReport(emplist);

    
    }

}