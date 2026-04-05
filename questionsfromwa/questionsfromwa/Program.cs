using questionsfromwa.models;

public class Program
{
    public static void Main(string[] args)
    {
        LibraryMembercs student = new StudentMember(123, "Alice");
        student.CalculateFine(5);

        LibraryMembercs faculty = new FacultyMember(456, "Dr. Smith");
        faculty.CalculateFine(5);
    }
}