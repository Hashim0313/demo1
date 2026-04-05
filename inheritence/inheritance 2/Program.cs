using inheritance_2.models;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person1 = new Person("john","wick",46);
        Person person2 = new Person();
        Employee employee1 = new Employee("Tom","Cruise",60, 1 ,"CIA Agent");
        Employee employee2 = new Employee();

        Console.WriteLine($"Person 1: {person1.GetFullName()}, Age: {person1.Age}\n");
        Console.WriteLine($"Person 2: {person2.GetFullName()}, Age: {person2.Age}\n");
        Console.WriteLine();
        Console.WriteLine($"Employee 1: {employee1.GetEmployeeInfo()}\n");    
        Console.WriteLine($"Employee 2: {employee2.GetEmployeeInfo()}\n");

    }
}