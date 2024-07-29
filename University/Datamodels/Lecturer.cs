using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Lecturer
    {
        public string firstName {  get; set; }
        public string lastName {  get; set; }
        public int numEmployee { get; private set; }

        public List<string> techCourse = new List<string>();
        public string specialization { get; private set; }

        public int numStar { get; private set; }


        public Lecturer(string firstName, string lastName, int numEmployee) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.numEmployee = numEmployee;
        }
    }
}
