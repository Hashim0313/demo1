namespace BlazorWorkshop.Models
{
    public class Job
    {

        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string Salary { get; set; }

        public int JobProviderID { get; set; }

        public JobProvider JobProvider { get; set; }

    }
}
