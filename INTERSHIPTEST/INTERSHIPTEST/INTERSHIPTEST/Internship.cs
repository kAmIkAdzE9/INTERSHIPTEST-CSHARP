using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERSHIPTEST
{
    public class Internship : Institutions
    {
        string name;
        public Internship (string name)
        {
            this.name = name;
        }
        private List<Student> personList = new List<Student>();
        public override void AddStudent(Student student)
        {
            if(student.getLevel > 3)
                this.personList.Add(student);
        }

        public override List<Student> getStudents()
        {
            return personList;
        }
    }
}
