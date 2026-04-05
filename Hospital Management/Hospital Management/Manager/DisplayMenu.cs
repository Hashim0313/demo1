using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management.Manager
{
    public class DisplayMenu
    {
        Hospital manage = new Hospital();
        public void Display()
        {
            Console.WriteLine("Choose an option \n 1 : Add doctor \n 2 : List Doctor \n 3 : Remove Doctor \n 4 : Book Appointment \n 5 : Cancel Appointment ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    manage.AddDoctor();
                    Display();
                    break;

                case "2":
                    manage.DisplayDoctors();
                    Display();
                    break;

                case "3":
                    manage.RemoveDoctor();
                    Display();
                    break;

                case "4":
                    manage.BookAppointment();
                    Display();
                    break;

                case "5":
                    manage.CancelAppointment();
                    Display();
                    break;
            }
        }
    }
}
