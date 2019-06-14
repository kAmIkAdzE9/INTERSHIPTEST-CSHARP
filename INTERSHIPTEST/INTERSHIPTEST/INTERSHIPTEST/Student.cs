using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERSHIPTEST
{
    public class Student
    {
        private string name;
        private int level;
        public string getName
        {
            get { return name; }
        }
        public int getLevel
        {
            get { return level; }
        }
        public Student(string name)
        {
            this.name = name;
        }
        public void SetKnowledge(Knowledge knowledge)
        {
            this.level = knowledge.setLevel;
        }
    }
}
