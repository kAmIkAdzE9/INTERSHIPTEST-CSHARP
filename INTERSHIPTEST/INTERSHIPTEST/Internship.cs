using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string name;
        public Internship (string name)
        {
            this.name = name;
        }
        public string GetStudents(University university)
        {
            List <Student> studentsList = university.getStudentList;
            string students = "";
            foreach(Student student in studentsList)
            {
                if (student.getLevel > 3)
                    students += student.getName + "\n";
            }
            return students;
        }
    }
}
