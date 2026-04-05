using activity_7.models;

internal class Program
{
    public static void Main(string[] args)
    {
        Employee employee1 = new Employee (1, "john",10000);
        employee1.CalculateSalary();

        Console.WriteLine();

        Employee employee2 = new Employee (2, "wick", 25000);
        employee2.CalculateSalary();
    }
}