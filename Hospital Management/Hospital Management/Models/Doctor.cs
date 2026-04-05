using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management.Models
{
    public class Doctor
    {
        private int doctorid { get; set; }
        private string name { get; set; }
        private string specialization { get; set; }
        private int availableslots { get; set; }


        public int DoctorId
        {
            get { return doctorid; }
            set
            {
                doctorid = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public string Specialization
        {
            get { return specialization; }
            set
            {
                specialization = value;
            }
        }

        public int AvailableSlots
        {
            get { return availableslots; }
            set
            {
                availableslots = value;
            }
        }


        public Doctor(int DoctorId, string Name, string Specialization, int AvailableSlots)
        {
            doctorid = DoctorId;
            name = Name;
            specialization = Specialization;
            availableslots = AvailableSlots;
        }
    }
}
