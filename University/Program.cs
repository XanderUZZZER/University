using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Professor> Professors = new List<Professor>
            {
                new Professor("Ivan Ivanovich", Subject.Biology),
                new Professor("Petr Petrovich", Subject.Chemistry),
                new Professor("Vasilyi Vasiliyevich", Subject.ComputerScience),
                new Professor("Yuryi Yuryievich", Subject.English),
                new Professor("San Sanych", Subject.History),
                new Professor("Sergey Vladimirovich", Subject.Maths),
                new Professor("Sergey Vladimirovich", Subject.Physics)
            };

            List<Student> Group = new List<Student>()
            {
                new Student("Yura"),
                new Student("Dasha"),
                new Student("Vasya"),
                new Student("Sasha"),
                new Student("Olya"),
                new Student("Sergey"),
                new Student("Lena"),
                new Student("Vadim"),
                new Student("Katya"),
                new Student("Oksana")
            };
            Session winterSession = new Session(Professors, Group);
            winterSession.StartSession();
            winterSession.EndSession();
            Console.ReadLine();
        }
    }
}
