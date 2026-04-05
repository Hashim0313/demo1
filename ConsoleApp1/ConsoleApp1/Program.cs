using ConsoleApp1.models;
public class Program
{
    private static void Main(string[] args)
    {
        Student s = new Student(1,"kevin","77");


        Console.WriteLine($"  id : {s.Id}\n name : {s.Name}\n mark : {s.Mark}\n\n");




        Console.WriteLine("Id");
        int Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Name");
        string Name = Console.ReadLine();

        Console.WriteLine("Mark");
        string Mark = Console.ReadLine();

        

        s.Id = Id;

        s.Name = Name;

        s.Mark = Mark;

        s.Print();
    }
}