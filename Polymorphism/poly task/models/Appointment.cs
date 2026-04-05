using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace poly_task.models
{
    internal abstract class Appointment
    {
        public Patient Patient;

        public Staff Staff;


        public Appointment(Patient patient, Staff staff)
        {
            Patient = patient;
            Staff = staff;
        }

        public abstract void ScheduleAppointment();


    }


     class OnlineAppointment : Appointment
    {
        public OnlineAppointment(Patient patient, Staff staff) : base(patient, staff)
        {

        }
        public override void ScheduleAppointment()
        {
            Console.WriteLine($"Online appointment scheduled for patient {Patient.getName()} with  {Staff.Name}");
        }
    }

    class OfflineAppointment : Appointment
    {
        public OfflineAppointment(Patient patient, Staff staff) : base(patient, staff)
        {
        }
        public override void ScheduleAppointment()
        {
            Console.WriteLine($"Offline appointment scheduled for patient {Patient.getName()} with  {Staff.Name}");
        }
    }


}
