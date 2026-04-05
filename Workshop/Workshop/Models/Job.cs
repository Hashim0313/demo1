namespace Workshop.Models
{
    public class Job
    {
        public int Id;
        public string Title;
        public string Description;
        public string Location;
        public string Salary;
        public string Type;
        public string Company;

        public Job() { }

        public Job(string title, string description, string location, string salary, string type, string company)
        {
            Title = title;
            Description = description;
            Location = location;
            Salary = salary;
            Type = type;
            Company = company;

        }
    }
}
