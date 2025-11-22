using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Models
{
    public class AppointmentClass
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public AppointmentClass(int appointmentId, int patientId, int doctorId, string date, string time)
        {
            AppointmentId = appointmentId;
            PatientId = patientId;
            DoctorId = doctorId;
            Date = date;
            Time = time;
        }

        public void Display()
        {
            Console.WriteLine($"Appointment {AppointmentId}: Patient {PatientId} with Doctor {DoctorId} on {Date} at {Time}");
        }
    }
}
