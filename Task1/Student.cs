using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Student
    {
        public string LastName;
        public string FirstName;
        public DateTime DateOfBirthday;
        public Dictionary<int, Dictionary<string, int>> GradesBySemester;
        public int Course;
        public string Group;
        public Dictionary<int, List<string>> SubjectsBySemester;

        public Student(string lastName, string firstName, DateTime dateOfBirthday, int course, string group, Dictionary<int, List<string>> subjectsBySemester)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.DateOfBirthday = dateOfBirthday;
            this.Course = course;
            this.Group = group;
            this.SubjectsBySemester = subjectsBySemester;
            this.GradesBySemester = InitializeGradesBySemester(this.SubjectsBySemester);
        }

        public Student(string lastName, string firstName, DateTime dateOfBirthday, int course, string group)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.DateOfBirthday = dateOfBirthday;
            this.Course = course;
            this.Group = group;
            this.SubjectsBySemester = new Dictionary<int, List<string>>();
            this.GradesBySemester = new Dictionary<int, Dictionary<string, int>>();
        }

        private Dictionary<int, Dictionary<string, int>> InitializeGradesBySemester(Dictionary<int, List<string>> subjectsBySemester)
        {
            Dictionary<int, Dictionary<string, int>> grades = new Dictionary<int, Dictionary<string, int>>();
            foreach (var semesterSubjects in subjectsBySemester)
            {
                Dictionary<string, int> semesterGrades = new Dictionary<string, int>();
                foreach (var subject in semesterSubjects.Value)
                {
                    semesterGrades.Add(subject, 0); // Например, все оценки инициализированы нулем
                }
                grades.Add(semesterSubjects.Key, semesterGrades);
            }
            return grades;
        }

        public double CalculateAverageGrade(string subject)
        {
            if (GradesBySemester.Count == 0)
                return 0;

            double totalGrade = 0;
            int totalSubjects = 0;

            foreach (var semesterGrades in GradesBySemester)
            {
                if (semesterGrades.Value.ContainsKey(subject))
                {
                    totalGrade += semesterGrades.Value[subject];
                    totalSubjects++;
                }
            }

            if (totalSubjects == 0)
                return 0;

            return totalGrade / totalSubjects;
        }

        public List<string> GetSubjectsWithDebt()
        {
            List<string> subjectsWithDebt = new List<string>();

            foreach (var semesterGrades in GradesBySemester)
            {
                foreach (var grade in semesterGrades.Value)
                {
                    if (grade.Value < 3) 
                    {
                        subjectsWithDebt.Add(grade.Key);
                    }
                }
            }

            return subjectsWithDebt;
        }

        public double CalculateAverageGradeForAllSubjects()
        {
            if (GradesBySemester.Count == 0)
                return 0;

            double totalGrade = 0;
            int totalSubjects = 0;

            foreach (var semesterGrades in GradesBySemester)
            {
                totalGrade += semesterGrades.Value.Sum(g => g.Value);
                totalSubjects += semesterGrades.Value.Count;
            }

            if (totalSubjects == 0)
                return 0;

            return totalGrade / totalSubjects;
        }

        public double CalculateAverageGradeForSemester(int semester)
        {
            if (!GradesBySemester.ContainsKey(semester))
                return 0;

            var semesterGrades = GradesBySemester[semester];

            if (semesterGrades.Count == 0)
                return 0;

            double totalGrade = semesterGrades.Sum(g => g.Value);
            return totalGrade / semesterGrades.Count;
        }

        
    }
}
