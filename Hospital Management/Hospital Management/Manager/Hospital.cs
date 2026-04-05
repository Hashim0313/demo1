using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Management.Interface;
using Hospital_Management.Models;
using Hospital_Management.Exceptions;

namespace Hospital_Management.Manager
{
    public class Hospital : IHospital
    {
        public static List<Doctor> doctors = new List<Doctor>();
        public static int  slot=0;

        public  void AddDoctor()
        {
            Console.WriteLine("Enter Doctor Id");
            int DoctorId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Doctor Name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Specialization");
            string Specialization = Console.ReadLine();

            Console.WriteLine(" Available Slots ");
            int AvailableSlots = Convert.ToInt32(Console.ReadLine());

            doctors.Add(new Doctor( DoctorId, Name, Specialization, AvailableSlots));

        }

        public void DisplayDoctors()
        {

            foreach (var d in doctors)
            {
                Console.WriteLine("Doctors\n");
                Console.WriteLine($"\n Doctor id : {d.DoctorId}");
                Console.WriteLine($"\n Doctor Name : {d.Name}");
                Console.WriteLine($"\n Doctor Specialization : {d.Specialization}");
                Console.WriteLine($"\n Doctor Available slots : {d.AvailableSlots}\n\n");
            }

        }

        public void RemoveDoctor()
        {
            try
            {
                Console.WriteLine("Enter id");
                int Id = Convert.ToInt32(Console.ReadLine());
                Doctor d = doctors.Find(x => x.DoctorId == Id);
                if (d != null)
                {
                    doctors.Remove(d);
                }
                else
                {
                    throw new DoctorDoesnotExist(" Doctor not found ");
                }
            }
            catch(DoctorDoesnotExist ex )
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void BookAppointment()
        {
            try
            {
                Console.WriteLine("enter Id");
                int Id = Convert.ToInt32(Console.ReadLine());

                Doctor D = doctors.Find(x => x.DoctorId == Id);
                if (D != null)
                {
                    Console.WriteLine("How many slots");
                    slot= Convert.ToInt32(Console.ReadLine());
                    if(D.AvailableSlots >= slot)
                    {
                        D.AvailableSlots -= slot;
                    }
                    else
                    {
                        throw new SlotException("enter valid slot");
                    }
                   

                    //D.AvailableSlots = D.AvailableSlots - slot;
                }
                else
                {
                    throw new DoctorDoesnotExist(" Doctor not found ");
                }
            }
            catch(DoctorDoesnotExist ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(SlotException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void CancelAppointment()
        {
            try
            {
                Console.WriteLine("Enter id");
                int id = Convert.ToInt32(Console.ReadLine());

                Doctor T = doctors.Find(x => x.DoctorId == id);
                if(T != null)
                {
                    Console.WriteLine("how many slots you want to cancel ?");
                    int Cslot = Convert.ToInt32(Console.ReadLine());
                    if(Cslot <= slot)
                    {
                        T.AvailableSlots += Cslot; 
                    }
                    else
                    {
                        throw new SlotException("enter valid slot");
                    }

                }
                else
                {
                    throw new DoctorDoesnotExist("doctor not found");
                }
            }
            catch(DoctorDoesnotExist ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(SlotException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       



    }
}
