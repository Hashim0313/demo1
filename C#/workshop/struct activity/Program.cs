internal class Program
{
    public struct student
    {
        public int id;
        public string name;
        public float marks;


        public student (int id, string name, float mark)
        {
            this.id = id;
            this.name = name;
            this.marks = mark;
        }

public void DisplayDetails()
        {
            Console.WriteLine($"{id} - {name} - {marks}");
        }

        public static void Main(string[]args)
        {
            student s1 = new student();
            Console.WriteLine("Enter student id:");
            s1.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name:");
            s1.name=Console.ReadLine();
            Console.WriteLine("Enter student marks:");
            s1.marks = Convert.ToInt32(Console.ReadLine());
            


            student s2 = new student();
            Console.WriteLine("Enter student id:");
            s2.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name:");
            s2.name = Console.ReadLine();
            Console.WriteLine("Enter student marks:");
            s2.marks = Convert.ToInt32(Console.ReadLine());
           


          


            s1.DisplayDetails();
            s2.DisplayDetails();
            





        }


    }
}