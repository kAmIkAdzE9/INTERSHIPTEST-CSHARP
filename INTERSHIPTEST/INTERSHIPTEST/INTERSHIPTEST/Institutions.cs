using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERSHIPTEST
{
    public abstract class Institutions
    {
        private string name;
        public abstract void AddStudent(Student student);
        public abstract List<Student> getStudents();
    }
}
