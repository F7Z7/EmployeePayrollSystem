using EmployeePayrollSystem.Models;


class Program
{


    public static void ListEmployees(List<Employee> employees)
    {
        foreach(Employee employee in employees)
        {
            employee.DisplayInfo();
           Console.WriteLine(
    $"Salary: {employee.CalculateSalary()}");
        }
    }
    
    public static void Main()
    {

        List<Employee> emplist= new List<Employee>();


while(true){
        Console.WriteLine("Choose Type of Employee:  F for Full time : P for Part time");
        char type = Console.ReadLine().ToUpper()[0];

        if (type == 'F') {
            Console.WriteLine("Enter Name:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter ID:");
    string id = Console.ReadLine();

    Console.WriteLine("Enter Monthly Salary:");
    double salary = Convert.ToDouble(Console.ReadLine());


    Employee emp=new FullTimeEmployee(name,id,salary);
    emplist.Add(emp);
        }
        else if (type == 'P') {
            Console.WriteLine("Enter Name:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter ID:");
    string id = Console.ReadLine();

    Console.WriteLine("Enter Hours Worked:");
    double HoursWorked = Convert.ToDouble(Console.ReadLine());

    
    Console.WriteLine("Enter Wage:");
    double Wage = Convert.ToDouble(Console.ReadLine());

    Employee emp=new PartTimeEmployee(name,id,HoursWorked,Wage);

    emplist.Add(emp);

        
        
        }

 Console.WriteLine("Add another employee? (Y/N)");

    char choice = Console.ReadLine().ToUpper()[0];

    if(choice == 'N')
        break;

        }


        
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
    
    }


}