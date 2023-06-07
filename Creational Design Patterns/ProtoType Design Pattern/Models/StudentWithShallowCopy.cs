namespace ProtoType_Design_Pattern.Models
{
    internal class StudentWithShallowCopy
    {
        private int Age;
        public string Name;
        public Address Address;

        public StudentWithShallowCopy(string name, int age, Address address)
        {
            Age = age;
            Name = name;
            Address = address;
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address.City}");
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
