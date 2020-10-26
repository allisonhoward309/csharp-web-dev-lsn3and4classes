using System;
using System.Security.Cryptography.X509Certificates;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double totalQualityScore = Gpa * NumberOfCredits;
            totalQualityScore += courseCredits * grade;
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }




        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (this.NumberOfCredits < 30 && this.NumberOfCredits > 0)
            {
                return "Freshman";
            }
            else if (this.NumberOfCredits < 60)
            {
                return "Sophmore";
            }
            else if (this.NumberOfCredits < 90)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override Boolean Equals(object toBeCompared)
            {
            if (toBeCompared == this)
            {
                return true;
            }
            if (toBeCompared == null)
            {
                return false;
            }
                if(toBeCompared.GetType() != this.GetType())
            {
                return false;
            }
            Student s = toBeCompared as Student;
            return s.studentId == studentId;
            }
   
    }  
}
