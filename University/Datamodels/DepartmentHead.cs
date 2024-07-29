using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    namespace University
    {
        public class DepartmentHead : Lecturer
        {
            public List<Lecturer> teach { get; set; }
            public List<Student> students { get; set; }

            public DepartmentHead(List<Lecturer> teach, List<Student> students, int numEmployee, string firstName,string listName)
                : base(firstName, listName, numEmployee) 
            {
                this.teach = teach;
                this.students = students;
            }
        }
    }
}
