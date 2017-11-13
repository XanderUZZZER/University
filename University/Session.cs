using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Session
    {
        private List<Professor> professors;
        private List<Student> group;

        public Session(List<Professor> professors, List<Student> group)
        {
            this.professors = professors;
            this.group = group;
        }

        public void StartSession()
        {
            foreach (Professor professor in professors)
            {
                foreach (Student student in group)
                {
                    professor.Examine(student);
                }
            }
        }

        public void EndSession()
        {
            foreach (Student student in group)
            {
                student.ShowGardes();
            }
        }
    }
}
