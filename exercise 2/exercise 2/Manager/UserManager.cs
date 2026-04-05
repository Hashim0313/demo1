using exercise_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise_2.Enums;
using exercise_2.UTils;

namespace exercise_2.Manager
{
    public class UserManager : IMenu
    {
        private
            readonly JobManager _jobManager;

        public UserManager(JobManager jobManager)
        {
            _jobManager = jobManager;
        }

        public void DisplayMenu(object?publicManager = null)
        {
            var Printer = new Printer();
            while (true)
            {
                Console.WriteLine("\n...JobSeeker Menu...");
                Console.WriteLine("1. View Jobs");
                Console.WriteLine("2. Logout");

                string?choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        var jobs = _jobManager.GetJob();
                        Printer.Print(jobs);
                        break;
                        case "2":
                        return;
                }
            }
        }
    }
}
