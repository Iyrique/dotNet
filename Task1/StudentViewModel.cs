using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class StudentViewModel
    {
        private Student student = new Student("Voronezhskiy", "Nikita", new DateTime(2003, 08, 11), 3, "10.1");

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
    }
}
