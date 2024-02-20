using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class StudentViewModel
    {
        private Student student = new Student("Voronezhskiy", "Nikita", new DateTime(2003, 8, 11), 3, "10.1");

        public string PrintInfo()
        {
            return $"Name: {student.LastName} {student.FirstName}, Birthday: {student.DateOfBirthday.Date}, Course: {student.Course}, Group: {student.Group}";
        }
         
    }
}
