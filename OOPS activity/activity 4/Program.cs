using activity_4.models;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student1 = new Student(1, "kent", 50);
        student1.CheckResult();

        Student student2 = new Student(2, "clark", 30);
        student2.CheckResult();

        Student student3 = new Student(3, "superman", 40);
        student3.CheckResult();

    }
}