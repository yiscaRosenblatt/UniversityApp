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
            public List<Routes> chargeRoutes {  get; set; }
            public List<Lecturer> teach { get; set; }
            public List<Student> students { get; set; }

            public DepartmentHead(List<Routes> chargeRoutes, List<Lecturer> teach, List<Student> students, int numEmployee)
                : base(numEmployee) 
            {
                this.chargeRoutes = chargeRoutes;
                this.teach = teach;
                this.students = students;
            }
        }
    }
}
