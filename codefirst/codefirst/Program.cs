using codefirst.models;
public class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n crud operations :");
            Console.WriteLine(" 1. create students");
            Console.WriteLine(" 2. read students");
            Console.WriteLine(" 3. update students");
            Console.WriteLine(" 4. delete students ");
            Console.WriteLine(" 5. exit ");
            Console.WriteLine(" select an option : ");

            var options = Console.ReadLine();

            switch(options)
            {
                case "1":
                    CreateStudent();
                    break;

                case "2":
                    ReadStudents();
                    break;

                case "3":
                    UpdateStudent();
                    break;

                case "4":
                    DeleteStudent();
                    break;

                case "5":
                    return;
                default:
                    Console.WriteLine("invalid option try again.");
                    break;
            }
        }
    }


    static void CreateStudent()
    {

        var context = new AppDbContext();

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter mark: ");
        int mark = int.Parse(Console.ReadLine());

        var student = new students { name = name, mark = mark };
        context.student.Add(student);
        context.SaveChanges();

        Console.WriteLine("Student Added Successfully!");
    }


    static void ReadStudents()
    {
        var context = new AppDbContext();

        var students = context.student.ToList();
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Console.WriteLine("Students List:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.id}, Name: {student.name}, mark: {student.mark}");
        }
    }

    static void UpdateStudent()
    {
        var context = new AppDbContext();

        Console.Write("Enter Student ID to Update: ");
        int id = int.Parse(Console.ReadLine());

        var student = context.student.Find(id);
        if (student == null)
        {
            Console.WriteLine("Student Not Found!");
            return;
        }

        Console.Write("Enter New Name: ");
        student.name = Console.ReadLine();

        Console.Write("Enter New mark: ");
        student.mark = int.Parse(Console.ReadLine());

        context.SaveChanges();
        Console.WriteLine("Student Updated Successfully!");
    }


    static void DeleteStudent()
    {
        var context = new AppDbContext();

        Console.Write("Enter Student ID to Delete: ");
        int id = int.Parse(Console.ReadLine());

        var student = context.student.Find(id);
        if (student == null)
        {
            Console.WriteLine("Student Not Found!");
            return;
        }

        context.student.Remove(student);
        context.SaveChanges();
        Console.WriteLine("Student Deleted Successfully!");
    }




}