internal class Program
{
    public struct Employee
    {
        public int empid;
        public string empname;
        public double salary;


        public Employee(int empid, string empname, double salary)
        {
            this.empid = empid;
            this.empname = empname;
            this.salary = salary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{empid} - {empname} - {salary}");
        }

        private static void Main(string[] args)

        {
            Employee e1 = new Employee();
            Console.WriteLine("Enter employee id:");
            e1.empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name:");
            e1.empname = Console.ReadLine();
            Console.WriteLine("Enter employee salary:");
            e1.salary = Convert.ToDouble(Console.ReadLine());


            Employee e2 = new Employee();
            Console.WriteLine("Enter employee id:");
            e2.empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name:");
            e2.empname = Console.ReadLine();
            Console.WriteLine("Enter employee salary:");
            e2.salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n ");
            e1.DisplayDetails();
            e2.DisplayDetails();


            Console.WriteLine("\n ");

            if (e1.salary > e2.salary)
            {
                Console.WriteLine($" {e1.empname} has the highest salary ");
            }
            else if (e2.salary>e1.salary)
            {
                Console.WriteLine($" {e2.empname} has the highest salary ");
            }


        }
    }
}