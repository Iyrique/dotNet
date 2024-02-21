using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class StudentViewModel
    {
        private Student student;

        public StudentViewModel()
        {
            Dictionary<int, Dictionary<string, int>> GradesBySemester = new Dictionary<int, Dictionary<string, int>>();
            GradesBySemester.Add(1, new Dictionary<string, int>());
            GradesBySemester.Add(2, new Dictionary<string, int>());
            GradesBySemester[1].Add("Математика", 4);
            GradesBySemester[1].Add("Физика", 5);
            GradesBySemester[1].Add("Литература", 3);
            GradesBySemester[1].Add("Экономика", 2);
            GradesBySemester[1].Add("Электротехника", 2);
            GradesBySemester[2].Add("Электротехника", 3);
            Dictionary<int, List<string>> SubjectsBySemester = new Dictionary<int, List<string>>();
            SubjectsBySemester.Add(2, new List<string> { "История", "Биология", "Химия" });
            SubjectsBySemester.Add(3, new List<string> { "География", "Иностранный язык", "Информатика" });
            student = new Student("Voronezhskiy", "Nikita", new DateTime(2003, 08, 11), 3, "10.1", SubjectsBySemester);
            student.GradesBySemester = GradesBySemester;
        }

        public string PrintInfo()
        {
            return $"Name: {student.LastName} {student.FirstName}, Birthday: {student.DateOfBirthday:dd.MM.yyyy}, Course: {student.Course}, Group: {student.Group}";
        }

        public string GetLastName()
        {
            return student.LastName;
        }

        public string GetFirstName()
        {
            return student.FirstName;
        }

        public int GetCourse()
        {
            return student.Course;
        }

        public string GetGroup()
        {
            return student.Group;
        }

        public DateTime GetDate()
        {
            return student.DateOfBirthday;
        }

        public void SetLastName(string lastName)
        {
            student.LastName = lastName;
        }

        public void SetDate(string lastName)
        {
            student.LastName = lastName;
        }

        public void SetFirstName(string firstName)
        {
            student.FirstName = firstName;
        }

        public void SetCourse(int course)
        {
            student.Course = course;
        }

        public void SetGroup(string group)
        {
            student.Group = group;
        }

        public void SetDate(DateTime dateTime)
        {
            student.DateOfBirthday = dateTime;
        }

        public double CountAverageForAllSubjects()
        {
            return student.CalculateAverageGradeForAllSubjects();
        }

        public string SubjectsWithDept()
        {
            List<string> ans = student.GetSubjectsWithDebt();
            // Преобразуем список в строку, разделяя предметы запятой
            string result = string.Join("\n", ans);
            return result;
        }

        public double AverageForSubject(string subject)
        {
            return student.CalculateAverageGrade(subject);
        }
    }
}
