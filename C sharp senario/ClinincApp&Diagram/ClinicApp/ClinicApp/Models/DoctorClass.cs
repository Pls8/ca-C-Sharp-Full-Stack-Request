using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Models
{
    public class DoctorClass
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }

        public DoctorClass(int doctorId, string name, string specialty)
        {
            DoctorId = doctorId;
            Name = name;
            Specialty = specialty;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {DoctorId} | Dr. {Name} | {Specialty}");
        }
    }
}
