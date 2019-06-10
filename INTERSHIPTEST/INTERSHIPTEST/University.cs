using System;
using System.Collections.Generic;
using InternshipTest.Person;


namespace InternshipTest.Institution
{
    public class University
    {
        private string name;
        private List<Student> list = new List<Student>();
        public List<Student> getStudentList
        {
            get { return list; }
        }
        public University (string name)
        {
            this.name = name;
        }
        public void AddStudent(Student student)
        {
            this.list.Add(student);
        }
    }
}
