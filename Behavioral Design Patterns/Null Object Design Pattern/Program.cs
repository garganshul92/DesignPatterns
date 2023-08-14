using Null_Object_Design_Pattern.Models;

var emp1 = EmployeesData.GetEmployee("Anshul");
var emp2 = EmployeesData.GetEmployee("Ayush");
var emp3 = EmployeesData.GetEmployee("Rohit");
var emp4 = EmployeesData.GetEmployee("Ankit");

Console.WriteLine(emp1.GetName());
Console.WriteLine(emp2.GetName());
Console.WriteLine(emp3.GetName());
Console.WriteLine(emp4.GetName());
