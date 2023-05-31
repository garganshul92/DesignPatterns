using ProtoType_Design_Pattern.Models;

Console.WriteLine("With ShallowCopy:\n");
StudentWithShallowCopy student1 = new StudentWithShallowCopy("Anshul", 30, new Address("Jind"));
var student2 = (StudentWithShallowCopy)student1.Clone();
student2.Name = "Isha";
student2.Address.City = "Hissar";

Console.WriteLine($"Student1 Details:");
student1.DisplayStudent();

Console.WriteLine("------------------------------\n\n");

Console.WriteLine($"Student2 Details:");
student2.DisplayStudent();


Console.WriteLine("\n\n\n\n");
Console.WriteLine("With DeepCopy:\n");

StudentWithDeepCopy student3 = new StudentWithDeepCopy("Anshul", 30, new Address("Jind"));
var student4 = (StudentWithDeepCopy)student3.Clone();
student4.Name = "Isha";
student4.Address.City = "Hissar";

Console.WriteLine($"Student1 Details:");
student3.DisplayStudent();

Console.WriteLine("------------------------------\n\n");

Console.WriteLine($"Student2 Details:");
student4.DisplayStudent();