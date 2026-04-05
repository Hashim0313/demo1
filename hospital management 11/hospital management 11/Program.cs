using hospital_management_11.Models;
using Microsoft.EntityFrameworkCore;
internal class Program
{
    private static void Main(string[] args)
    {
        var context = new HospitalmanagementContext();


        while (true)
        {
            Console.WriteLine("\nChoose Operation:");
            Console.WriteLine("1. book appointment");
            Console.WriteLine("2. view appointment");
            Console.WriteLine("3. exit");


            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: 
                    bookappointment();
                    break;
                case 2:
                    viewappointment();
                    break;
                case 3:
                    return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
}



    static void bookappointment()
    {
        var context = new HospitalmanagementContext();
        




            Console.Write("Enter patientName: ");
            string Patientname = Console.ReadLine();

            Console.Write("Enter appointment date: ");
            DateTime Appointmentdate = DateTime.Parse(Console.ReadLine());

        var appointment1 = context.Doctors.ToList();

        if (appointment1.Count == 0 )
        {
            Console.WriteLine("no doctors available\n");
        }

        Console.WriteLine("\navailable doctors");
        foreach(var d in appointment1)
        {
            Console.WriteLine($" Doctor ID : {d.DoctorId}   Doctor Name : {d.Name}   Specialization {d.Specialization}");
        }


            Console.WriteLine("enter doctor ID");
            int doctorID = int.Parse(Console.ReadLine());


            var Appointment = new Appointment { Patientname = Patientname, Appointmentdate = Appointmentdate, DoctorId = doctorID };

            context.Appointments.Add(Appointment);
            context.SaveChanges();

            Console.WriteLine("appointment booked successfully ");

        

    }



    static void viewappointment()
    {
        var context = new HospitalmanagementContext();
        
            var appointment = context.Appointments.Include(i=>i.Doctor).ToList();



        if (appointment.Count == 0)
        {
            Console.WriteLine("no appointments found");
        }



            Console.WriteLine("\n appointments ");

            foreach(var Appointment in appointment)
            {
                Console.WriteLine($" {Appointment.AppointmentId} - {Appointment.Patientname} - {Appointment.Appointmentdate} - {Appointment.Doctor.Name} - {Appointment.Doctor.Specialization}");
            }
        
    }



}