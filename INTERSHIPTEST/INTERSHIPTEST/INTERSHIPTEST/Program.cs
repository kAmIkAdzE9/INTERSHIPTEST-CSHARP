using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERSHIPTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Institutions university = new University("CNU");
            Institutions internship = new Internship("InterLink");
            Object[] students = { new Student("Alex"), new Student("Andrew Kostenko"), new Student("Julia Veselkina"), new Student("Maria Perechrest") };
            foreach (Student student in students)
            {
                student.SetKnowledge(new Knowledge(rnd.Next(1, 6)));
                university.AddStudent(student);
            }
            foreach (Student student in university.getStudents())
            {
                internship.AddStudent(student);
            }
            foreach (Student student in internship.getStudents())
            {
                Console.WriteLine(student.getName + " " + student.getLevel);
            }
            Console.ReadKey();
        }
    }
}
