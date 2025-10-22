using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment 2: Student Grade Tracker 

namespace ConsoleApp12_10_2025.Models
{
    public class StudentClass
    {
        public StudentClass(int stdID, string stdName)
        {
            this.stdID = stdID;
            this.stdName = stdName;
            stdGrade = new int[3];
            stdGradeIndex = 0;
        }

        //type [ prop ] faster init for memeber 
        public int stdID { get; }
        public string stdName { get; set; }
        public int[] stdGrade { get; set; }
        public int stdGradeIndex { get; set; }


        public string AddGrade(int grade) {
            if (grade < 0 || grade > 100)
            {
                return $"{grade} is invalid ";
            }
            else {
                stdGrade[stdGradeIndex] = grade;
                stdGradeIndex++;
                return $"Grade: {grade}, add to {this.stdName}";
            }
        }


        //avg calculation
        public double CalculateAvg() {
            if (stdGradeIndex != 0) {
                int total = 0;
                for (int i = 0; i < stdGradeIndex; i++) {
                    total += stdGrade[i];
                }
                return (double) total / stdGradeIndex;
            }
            else
            {
                return 0;
            }
        }


        public string PrintStdReport() {
            string gradeList = "";
            for (int i = 0; i < stdGradeIndex; i++) {
                //from AI -------------------------------v
                 gradeList = string.Join(", ", stdGrade.Take(stdGradeIndex));
            }
            return $"ID: {this.stdID} | Name: {this.stdName} | Grade List : {gradeList}";

        }






    }
}
