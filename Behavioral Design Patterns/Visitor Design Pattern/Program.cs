using Visitor_Design_Pattern.Models;

Employees employees = new Employees();
employees.AddEmployee(new Employee("Alex", 1000000, 20));
employees.AddEmployee(new Employee("Bob", 989878, 18));
employees.AddEmployee(new Employee("Henry", 1008760, 16));

employees.Accept(new IncomeVisitor());

employees.Accept(new VacationVisitor());