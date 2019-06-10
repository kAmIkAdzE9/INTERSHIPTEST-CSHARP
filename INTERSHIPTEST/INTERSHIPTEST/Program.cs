using System;
using System.Collections.Generic;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace INTERSHIPTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            University university = new University("CH.U.I.");
            Object[] list = { new Student("Alex"), new Student("Andrew Kostenko"), new Student("Julia Veselkina"), new Student("Maria Perechrest")};
            foreach(Student student in list)
            {
                student.SetKnowledge(new Knowledge(rnd.Next(1, 6)));
                university.AddStudent(student);

            }
            Internship internship = new Internship("Interlink");
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents(university));
            Console.ReadKey();
        }
    }
}
