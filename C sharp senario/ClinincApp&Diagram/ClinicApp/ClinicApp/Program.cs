using ClinicApp.Models;

namespace ClinicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ClinicManagmentClass clinic = new ClinicManagmentClass();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("CLINIC MANAGEMENT SYSTEM");
                Console.WriteLine("1. Register Patient");
                Console.WriteLine("2. Register Doctor");
                Console.WriteLine("3. Search Doctors by Specialty");
                Console.WriteLine("4. Book Appointment");
                Console.WriteLine("5. View Patient Appointments");
                Console.WriteLine("6. View All Appointments");
                Console.WriteLine("7. View All Patients");
                Console.WriteLine("8. View All Doctors");
                Console.WriteLine("9. Exit");
                Console.Write("Choose: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter patient name: ");
                        string patientName = Console.ReadLine();
                        Console.Write("Enter phone: ");
                        string patientPhone = Console.ReadLine();
                        clinic.RegisterPatient(patientName, patientPhone);
                        break;

                    case "2":
                        Console.Write("Enter doctor name: ");
                        string doctorName = Console.ReadLine();
                        Console.Write("Enter specialty: ");
                        string specialty = Console.ReadLine();
                        clinic.RegisterDoctor(doctorName, specialty);
                        break;

                    case "3":
                        Console.Write("Enter specialty to search: ");
                        string searchSpecialty = Console.ReadLine();
                        clinic.SearchDoctors(searchSpecialty);
                        break;

                    case "4":
                        clinic.ShowAllPatients();
                        Console.Write("Enter patient ID: ");
                        int patientId = int.Parse(Console.ReadLine());

                        clinic.ShowAllDoctors();
                        Console.Write("Enter doctor ID: ");
                        int doctorId = int.Parse(Console.ReadLine());

                        Console.Write("Enter date (dd/mm/yyyy): ");
                        string date = Console.ReadLine();

                        Console.Write("Enter time: ");
                        string time = Console.ReadLine();

                        clinic.BookAppointment(patientId, doctorId, date, time);
                        break;

                    case "5":
                        clinic.ShowAllPatients();
                        Console.Write("Enter patient ID: ");
                        int patId = int.Parse(Console.ReadLine());
                        clinic.ShowPatientAppointments(patId);
                        break;

                    case "6":
                        clinic.ShowAllAppointments();
                        break;

                    case "7":
                        clinic.ShowAllPatients();
                        break;

                    case "8":
                        clinic.ShowAllDoctors();
                        break;

                    case "9":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();







            }
        }
    }
}
