using System;

namespace InterviewSchedule
{
    internal class Program
    {
        struct interview
        {
            public string title;
            public DateTime date;
            public string time;
            public string location; 
        }
         static void Main(string[] args)
        {
            interview[] schedule = new interview[10];
            int InterviewCount = 0;
            Console.WriteLine("\n ----------schedule an interview for job seekers-------\n");
            string choice;
            do
            {
                Console.WriteLine("A - schedule an interview");
                Console.WriteLine("B - display scheduled interviews");
                Console.WriteLine("Select an option: ");
                string command = Console.ReadLine()?.Trim().ToUpper();

                switch (command)
                {
                    case "A":
                        Console.WriteLine("How many interviews do you want to schedule?");
                        int count = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < count && InterviewCount < schedule.Length; i++)
                        {
                            Console.WriteLine($"\n---- Interview Schedule {InterviewCount + 1} ----");
                            Console.Write("enter the job title : ");
                            schedule[InterviewCount].title = Console.ReadLine();

                            Console.Write("enter the date (dd-mm-yyyy): ");
                            schedule[InterviewCount].date = DateTime.Parse(Console.ReadLine());

                            Console.Write("enter the time (hh:mm): ");
                            schedule[InterviewCount].time = Console.ReadLine();

                            Console.WriteLine("enter the location: ");
                            schedule[InterviewCount].location = Console.ReadLine();

                            InterviewCount++;
                        }
                        break;
                    case "B":
                        Console.WriteLine("\n--------------- Scheduled Interviews ---------------");

                        if (InterviewCount == 0)
                        {
                            Console.WriteLine("No interviews scheduled yet.");
                        }

                        else
                        {
                            for (int i = 0; i < InterviewCount; i++)
                            {
                                Console.WriteLine($"Interview {i + 1}:");
                                Console.WriteLine($"Title: {schedule[i].title}");
                                Console.WriteLine($"Date: {schedule[i].date.ToString("dd-MM-yyyy")}");
                                Console.WriteLine($"Time: {schedule[i].time}");
                                Console.WriteLine($"Location: {schedule[i].location}");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("Do you want to continue? (Y/N)");
                choice = Console.ReadLine()?.Trim().ToUpper();

            } while (choice == "Y") ;


            }    

        }
    }
