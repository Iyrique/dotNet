using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Student
    {
        private string lastName { set; get; }
        private string firstName { set; get; }
        private DateTime dateOfBirthday { set; get; }
        private Dictionary<int, Dictionary<string, int>> gradesBySemester { set; get; }
        private int course { set; get; }
        private string group { set; get; }
        private Dictionary<int, List<string>> subjectsBySemester { set; get; }

        public Student(string lastName, string firstName, DateTime dateOfBirthday, int course, string group, Dictionary<int, List<string>> subjectsBySemester)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.dateOfBirthday = dateOfBirthday;
            this.course = course;
            this.group = group;
            this.subjectsBySemester = subjectsBySemester;
            this.gradesBySemester = InitializeGradesBySemester(this.subjectsBySemester);
        }

        public Student(string lastName, string firstName, DateTime dateOfBirthday, int course, string group)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.dateOfBirthday = dateOfBirthday;
            this.course = course;
            this.group = group;
            this.subjectsBySemester = new Dictionary<int, List<string>>();
            this.gradesBySemester = new Dictionary<int, Dictionary<string, int>>();
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
            if (gradesBySemester.Count == 0)
                return 0;

            double totalGrade = 0;
            int totalSubjects = 0;

            foreach (var semesterGrades in gradesBySemester)
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

            foreach (var semesterGrades in gradesBySemester)
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
            if (gradesBySemester.Count == 0)
                return 0;

            double totalGrade = 0;
            int totalSubjects = 0;

            foreach (var semesterGrades in gradesBySemester)
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
            if (!gradesBySemester.ContainsKey(semester))
                return 0;

            var semesterGrades = gradesBySemester[semester];

            if (semesterGrades.Count == 0)
                return 0;

            double totalGrade = semesterGrades.Sum(g => g.Value);
            return totalGrade / semesterGrades.Count;
        }

    }
}
