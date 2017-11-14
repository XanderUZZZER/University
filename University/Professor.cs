﻿using System;
using System.Threading;

namespace University
{
    class Professor : Person
    {
        private Subject subject { get; }

        public double nastiness { get; private set; }

        public Professor(string name, Subject subject) : base(name)
        {
            this.subject = subject;
        }

        public void Examine(Student student)
        {
            Random r = new Random();
            Thread.Sleep(10); //to be sure the random generated value differs of other instances
            nastiness = (double)(r.Next(5, 10)) / 10.0;
            int grade = (int)(nastiness * student.Luck);
            student.PassExam(subject, grade);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Today Professor {Name}'s nastiness level is: {nastiness}");
        }
    }
}
