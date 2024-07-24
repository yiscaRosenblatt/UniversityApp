using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Routes
    {
        public string name;
        public List<Course> courses = new List<Course>();
        public List<Student> Student = new List<Student>();

        public Routes(string name, List<Course> courses, List<Student> Student) 
        {
            this.name = name;
            this.courses = courses;
            this.Student = Student;
        }
    }
}
