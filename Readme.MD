# Employee Payroll Processing System


A concise C# console application demonstrating core .NET and object-oriented programming concepts through an employee payroll management system. Ideal for portfolio reviews, technical interviews, and learning-by-building.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [OOP Concepts Demonstrated](#oop-concepts-demonstrated)
- [Project Structure](#project-structure)
- [Sample Console Output](#sample-console-output)
- [How to Run](#how-to-run)
- [Learning Outcomes](#learning-outcomes)
- [Future Improvements](#future-improvements)
- [Contributing](#contributing)
- [License](#license)

## Overview

This is a C# console application built to demonstrate object-oriented design, LINQ-based analytics, multithreading, asynchronous payroll processing, and separation of concerns by creating a small, realistic Employee Payroll Processing System.

Use cases covered:
- Add and manage Full-Time and Part-Time employees
- Calculate payrolls using polymorphic salary calculations
- Classify employees by earnings
- Generate payroll reports and analytics

## Features

- Add Full-Time and Part-Time employees
- Calculate salaries using polymorphism
- Employee classification (High, Medium, Low earner)
- Input validation using exception handling
- Payroll processing using Tasks and async/await
- Payroll report generation using Threads
- LINQ-based reporting and analytics
- Console-based user interface suitable for demos and interviews

## Technologies Used

- C# (object-oriented programming)
- .NET SDK (6.0 or later recommended)
- LINQ for in-memory queries and analytics
- Tasks and async/await for asynchronous operations
- Multithreading (Threads) for report generation
- Collections: List<T>

## OOP Concepts Demonstrated

- Classes and Objects — concrete employee instances stored in collections
- Inheritance — `FullTimeEmployee` and `PartTimeEmployee` inherit from `Employee`
- Abstract Classes — `Employee` as the base abstract class
- Polymorphism — salary calculation and classification via overridden methods
- Encapsulation — properties and controlled access to internal state
- Exception Handling — robust input validation and error reporting
- Separation of Concerns — model, service, and utility layers

## Project Structure

Top-level layout:

- Models/
  - Employee.cs (abstract base class)
  - FullTimeEmployee.cs
  - PartTimeEmployee.cs
- Services/
  - PayrollService.cs
  - ReportService.cs
- Utilities/
  - InputValidator.cs
- Program.cs
- Readme.MD

Tree view (example)

```
EmployeePayrollSystem/
├─ Models/
│  ├─ Employee.cs
│  ├─ FullTimeEmployee.cs
│  └─ PartTimeEmployee.cs
├─ Services/
│  ├─ PayrollService.cs
│  └─ ReportService.cs
├─ Utilities/
│  └─ InputValidator.cs
├─ Program.cs
└─ Readme.MD
```
```
=========================================
      EMPLOYEE PAYROLL SYSTEM
=========================================

Choose Type of Employee:
F - Full Time
P - Part Time

Enter Name:
Farzan

Enter ID:
FT001

Monthly Salary:
50000

Add another employee? (Y/N)
Y

Choose Type of Employee:
F - Full Time
P - Part Time

Enter Name:
Sarah

Enter ID:
FT002

Monthly Salary:
65000

Add another employee? (Y/N)
Y

Choose Type of Employee:
F - Full Time
P - Part Time

Enter Name:
Harry

Enter ID:
PT001

Enter Hours Worked:
40

Enter Wage:
250

Add another employee? (Y/N)
Y

Choose Type of Employee:
F - Full Time
P - Part Time

Enter Name:
John

Enter ID:
PT002

Enter Hours Worked:
80

Enter Wage:
300

Add another employee? (Y/N)
N

Processing Salary for Farzan...
Processing Salary for Sarah...
Processing Salary for Harry...
Processing Salary for John...

Generating Payroll Report...

Salary Processed for Farzan
Salary Processed for Sarah
Salary Processed for Harry
Salary Processed for John

Generating Payroll Report...
Generating Payroll Report...
Generating Payroll Report...
Generating Payroll Report...

=========================================
         EMPLOYEE REPORT
=========================================

-----------------------------------------
Name   : Farzan
ID     : FT001
Salary : ₹50,000.00
Type   : High Earner
-----------------------------------------

-----------------------------------------
Name   : Sarah
ID     : FT002
Salary : ₹65,000.00
Type   : High Earner
-----------------------------------------

-----------------------------------------
Name   : Harry
ID     : PT001
Salary : ₹10,000.00
Type   : Low Earner
-----------------------------------------

-----------------------------------------
Name   : John
ID     : PT002
Salary : ₹24,000.00
Type   : Medium Earner
-----------------------------------------

=========================================
            LINQ REPORT
=========================================

High Earners:
 - Farzan
 - Sarah

Total Payroll:
₹149,000.00

Highest Paid Employee:
Sarah (₹65,000.00)



```

## How to Run

Prerequisites:
- .NET SDK 6.0 or later (https://dotnet.microsoft.com/)

Commands:

1. Clone the repository
   - git clone https://github.com/F7Z7/EmployeePayrollSystem.git
2. Change directory
   - cd EmployeePayrollSystem
3. Build the project
   - dotnet build
4. Run the application
   - dotnet run

## Learning Outcomes

This project is an entry-level but practical demonstration of how to design and implement a small C# application using modern .NET practices:

- Apply OOP fundamentals in real-world scenarios
- Implement polymorphic behavior for domain-specific calculations
- Use LINQ to write concise in-memory analytics queries
- Use Tasks and async/await to perform asynchronous work (simulating I/O-bound payroll operations)
- Spawn threads for background tasks like report generation
- Validate input and handle runtime errors gracefully
- Organize code with separation of concerns to make the codebase testable and maintainable

