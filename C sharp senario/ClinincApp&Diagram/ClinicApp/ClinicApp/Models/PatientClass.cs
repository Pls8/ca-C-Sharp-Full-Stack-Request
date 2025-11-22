using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Models
{
    public class PatientClass
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public PatientClass(int patientId, string name, string phone)
        {
            PatientId = patientId;
            Name = name;
            Phone = phone;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {PatientId} | Name: {Name} | Phone: {Phone}");
        }


    }
}
