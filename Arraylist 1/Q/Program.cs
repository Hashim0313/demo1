
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Queue job = new Queue();

        job.Enqueue("job 1");
        job.Enqueue("job 2");
        job.Enqueue("job 3");
        job.Enqueue("job 4");

        Console.WriteLine("Jobs in the queue:");
        while (job.Count > 0)
        {
            job.Dequeue();
            //Console.WriteLine(job.Dequeue());
        }
        Console.WriteLine($"\nTotal number of jobs in the queue: {job.Count}");
    }
}