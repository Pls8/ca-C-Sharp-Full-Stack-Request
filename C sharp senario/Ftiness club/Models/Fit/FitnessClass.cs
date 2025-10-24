using FtinessClass.Models.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FtinessClass.Models.Fit
{
    public class FitnessClass
    {
        public string className { get; set; }
        public string schedulE { get; set; }
        public TrainerClass traineR { get; set; }   // has a trainer 
        List<MemberClass> enrolledMember;           // has many member

        public FitnessClass(string className, string schedulE)
        {
            this.className = className;
            this.schedulE = schedulE;
            traineR = null;
            enrolledMember = new List<MemberClass>();
        }

        public void addMember(MemberClass member) {
            if (!enrolledMember.Contains(member)) { 
                enrolledMember.Add(member);
            }
        }

        public void showClassDetails() {
            Console.WriteLine($"class details: [ {className} ]");
            Console.WriteLine($"schedul [ {schedulE} ]");

            if (traineR != null)
            {
                Console.WriteLine($"Trainer: [ {traineR.fullName} ] - [ {traineR.spcilaziztioN} ]");
            }
            else { Console.WriteLine("trainer not assigned!"); }


            Console.WriteLine($"Enrolled member [ {enrolledMember.Count} ]");
            if (enrolledMember.Count > 0 )
            {
                Console.WriteLine(".......Member List.......");
                foreach (MemberClass member in enrolledMember)
                {
                    Console.WriteLine($"\t[ {member.fullName} ]");
                }                
            }
            Console.WriteLine(".................................");
        }

        public MemberClass[] getEntrolledMember() { 
            return enrolledMember.ToArray();
        }

        



    }
}
