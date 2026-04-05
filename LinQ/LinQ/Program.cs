using LinQ.models;

internal class Program
{
    private static void Main(string[] args)
    {
        //step one obtain data source

        List<Employees> employees = new List<Employees>() {

        new Employees("John", "50000", "accountant"),

        new Employees("ben", "1000", "Manager"),

        new Employees("ken", "2000", "Manager"),
            };

        //step two: create query
        var emp = from e in employees
                  where e.Designation =="Manager"
                  select e;

        //step three: execute query

        foreach(Employees e in emp)
        {
            Console.WriteLine("Name: "+e.Name);
        }
    }
}