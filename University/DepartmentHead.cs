using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class DepartmentHead : lecturer
    {
        private List<Routes> chargeRoutes = new List<Routes>();
        private List<lecturer> teach = new List<lecturer>();
        private List<Student> students = new List<Student>();
       

        public DepartmentHead(List<Routes> chargeRoutes, List<lecturer> teach, List<Student> students, int numEmployee, List<string> techCourse, string specialization, int numStar)
        {
            this.chargeRoutes = chargeRoutes;
            this.teach = teach;
            this.students = students;
            this.numEmployee = numEmployee;
            this.techCourse = techCourse;
            this.specialization = specialization;
            this.numStar = numStar;
        }
    }
}
