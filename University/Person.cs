﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    abstract class Person
    {
        protected string Name { get; }
        protected Random r = new Random();

        public Person(string name)
        {
            Name = name;
        }

        public abstract void ShowInfo();
    }
}
