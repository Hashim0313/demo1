using Static.models;


internal class Program
{
    public static void Main()
    {
        Student student1 = new Student("jon");
        Student student2 = new Student("ben");
        Student student3 = new Student("jane");

        Console.WriteLine(Student.Count);

    }
}