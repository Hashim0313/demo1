internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int , string> Students = new Dictionary<int , string>();
     
        Students.Add(1, "John");
        Students.Add(2, "Jane");
        Students.Add(3, "Jack");

        int SearchKey = 2;
        if (Students.ContainsKey(SearchKey))
        {
            Console.WriteLine($"Student id {SearchKey}: {Students[SearchKey]}");
        }
        else
        {
            Console.WriteLine($"Key {SearchKey} not found.");
        }

        int RemoveKey = 2;
        if(Students.ContainsKey(RemoveKey))
        {
            Students.Remove(RemoveKey);
            Console.WriteLine($"Student id {RemoveKey} removed.");
        }

        Console.WriteLine("All Students:");
        foreach (var student in Students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }

        Students.Clear();
        Console.WriteLine("All records of students cleared.");

        if (Students.Count==0)
        {
                       Console.WriteLine("No records found.");
        }
        Console.ReadLine();



    }

}