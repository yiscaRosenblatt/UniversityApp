using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace University
{
    public class Routes
    {
        public string name { get; set; }
        public List<Course> courses {  get; set; }
        public List<Student> Student {  get; set; }

        public Routes(string name, List<Course> courses, List<Student> Student) 
        {
            this.name = name;
            this.courses = courses;
            this.Student = Student;
        }
    }
}
