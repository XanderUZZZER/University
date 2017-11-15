using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace University
{
    class Student : Person
    {
        private Dictionary<Subject, int> grades = new Dictionary<Subject, int>();

        public int Luck
        {
            get
            {
                return r.Next(80, 100);
            }
        }

        public Student(string name) : base(name)
        {
        }

        public void PassExam(Subject subject, int grade)
        {
            this.grades[subject] = grade;
        }

        public void ShowGardes()
        {
            Console.WriteLine($"***   {Name}'s grades   ***\n{"Subject",-18}Grade");
            Console.WriteLine($"--------------------------");
            foreach (KeyValuePair<Subject, int> grade in grades)
            {
                if (grade.Value != 0)
                {
                    Console.WriteLine($"{grade.Key.ToString(),-18}{grade.Value}");
                }
            }
            Console.WriteLine("--------------------------\n");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Today student {Name}'s luck level is: {Luck}");
        }
    }
}
