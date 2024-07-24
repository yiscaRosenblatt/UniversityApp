using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Course
    {
        public string Name { get; set; }
        public List<Student> Student = new List<Student>();


        public Course(string name, List<Student> student)
        {
            Name = name;
            Student = student;
        }
    }
}
