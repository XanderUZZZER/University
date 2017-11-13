using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace University
{
    class Professor : Person
    {
        private Subject subject { get; }
        private double nastiness;

        public Professor(string name, Subject subject) : base(name)
        {
            this.subject = subject;
            Random r = new Random();
            Thread.Sleep(10); //to be sure the random generates different value from other instances
            nastiness = (double)(r.Next(5, 10)) / 10.0;            
        }

        public void Examine(Student student)
        {            
            int grade = (int)(nastiness * student.Luck);
            student.PassExam(subject, grade);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Today Professor {Name}'s nastiness level is: {nastiness}");
        }
    }
}
