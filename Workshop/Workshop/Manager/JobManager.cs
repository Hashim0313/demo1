using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Manager
{
    public class JobManager : IJobProvider
    {
        private List<Job> jobs = new List<Job>();
        public void PostJob(Job job)
        {
            job.Id = jobs.Count;
            jobs.Add(job);
        }

        public List<Job> GetJobs()
        {
            return jobs;
        }
    }
}
