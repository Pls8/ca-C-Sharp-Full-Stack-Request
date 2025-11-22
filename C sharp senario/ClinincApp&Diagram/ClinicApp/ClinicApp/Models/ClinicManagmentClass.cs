using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Models
{
    public class ClinicManagmentClass
    {
        public List<PatientClass> patients;
        public List<DoctorClass> doctors;
        public List<AppointmentClass> appointments;
        private int patientIdCounter = 1;
        private int doctorIdCounter = 1;
        private int appointmentIdCounter = 1;

        public ClinicManagmentClass()
        {
            patients = new List<PatientClass>();
            doctors = new List<DoctorClass>();
            appointments = new List<AppointmentClass>();

            // Add sample data
            patients.Add(new PatientClass(patientIdCounter++, "Patent 1", "12345678"));
            patients.Add(new PatientClass(patientIdCounter++, "Patent 2", "87654321"));

            doctors.Add(new DoctorClass(doctorIdCounter++, "Dr. 1", "Cardiology"));
            doctors.Add(new DoctorClass(doctorIdCounter++, "Dr. 2", "Pediatrics"));
        }

        public void RegisterPatient(string name, string phone)
        {
            patients.Add(new PatientClass(patientIdCounter++, name, phone));
            Console.WriteLine($"Patient {name} registered!");
        }

        public void RegisterDoctor(string name, string specialty)
        {
            doctors.Add(new DoctorClass(doctorIdCounter++, name, specialty));
            Console.WriteLine($"Doctor {name} registered!");
        }

        public void SearchDoctors(string specialty)
        {
            var foundDoctors = doctors.Where(d => d.Specialty.ToLower() == specialty.ToLower()).ToList();

            if (foundDoctors.Count == 0)
            {
                Console.WriteLine("No doctors found!");
            }
            else
            {
                foreach (var doctor in foundDoctors)
                {
                    doctor.Display();
                }
            }
        }

        public void BookAppointment(int patientId, int doctorId, string date, string time)
        {
            // Check if patient exists
            if (!patients.Any(p => p.PatientId == patientId))
            {
                Console.WriteLine("Patient not found!");
                return;
            }

            // Check if doctor exists
            if (!doctors.Any(d => d.DoctorId == doctorId))
            {
                Console.WriteLine("Doctor not found!");
                return;
            }

            appointments.Add(new AppointmentClass(appointmentIdCounter++, patientId, doctorId, date, time));
            Console.WriteLine("Appointment booked!");
        }

        public void ShowPatientAppointments(int patientId)
        {
            var patientApps = appointments.Where(a => a.PatientId == patientId).ToList();

            if (patientApps.Count == 0)
            {
                Console.WriteLine("No appointments found!");
            }
            else
            {
                foreach (var app in patientApps)
                {
                    app.Display();
                }
            }
        }

        public void ShowAllAppointments()
        {
            if (appointments.Count == 0)
            {
                Console.WriteLine("No appointments!");
            }
            else
            {
                foreach (var app in appointments)
                {
                    app.Display();
                }
            }
        }

        public void ShowAllPatients()
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("No patients!");
            }
            else
            {
                foreach (var patient in patients)
                {
                    patient.Display();
                }
            }
        }

        public void ShowAllDoctors()
        {
            if (doctors.Count == 0)
            {
                Console.WriteLine("No doctors!");
            }
            else
            {
                foreach (var doctor in doctors)
                {
                    doctor.Display();
                }
            }
        }
    }
}
