internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<int, string> StudentGrades = new SortedList<int, string>();

        StudentGrades.Add(313, " C+");
        StudentGrades.Add(311, " A");
        StudentGrades.Add(314, " B");
        StudentGrades.Add(315, " B");
        StudentGrades.Add(312, " A+");
        
       

        Console.WriteLine("All Student Grades: (Sorted by ID)");
        foreach (var student in StudentGrades)
        {
            Console.WriteLine($"ID: {student.Key}, Grade: {student.Value}");
        }

        int searchId = 313;
        if (StudentGrades.ContainsKey(searchId))
        {
            Console.WriteLine($"student id {searchId} :{StudentGrades[searchId]}");
        }

        StudentGrades.Remove(314);

        Console.WriteLine("Student list After removing student id 314:");

        foreach (var student in StudentGrades)
        {
            Console.WriteLine($"ID: {student.Key}, Grade: {student.Value}");
        }
        Console.ReadLine();



    }
}