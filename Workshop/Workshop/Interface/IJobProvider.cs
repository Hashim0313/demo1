using Workshop.Models;

namespace Workshop.Interface
{
    public interface IJobProvider
    {
        void PostJob(Job job);
        List<Job> GetJobs();
    }
}
