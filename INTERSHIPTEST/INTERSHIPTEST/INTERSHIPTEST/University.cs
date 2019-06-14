using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERSHIPTEST
{
    public class University : Institutions
    {
        private string name;
        private List<Student> personList = new List<Student>();
        public University (string name)
        {
            this.name = name;
        }      
        public override void AddStudent(Student student)
        {
            this.personList.Add(student);
        }
        public override List<Student> getStudents()
        {
            return personList;
        }
    }
}
