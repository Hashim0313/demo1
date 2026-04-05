using OOPS.Models;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        JOB jobs = new JOB();

        jobs.id = 1;
        jobs.name = "software developer";
        jobs.category = "IT";
        jobs.salary = 10000;

        jobs.DisplayInfo();

        JOB jobs2 = new JOB();

        jobs2.id = 2;
        jobs2.name = "developer";
        jobs2.salary = 2000;
        jobs2.category = "IT";

        jobs2.DisplayInfo();


        


    }


}
