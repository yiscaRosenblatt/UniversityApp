using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student
    {
        public String lestName { get; set; }
        public String firstName { get; set; }
        public int numStudent { get; private set; }
        public String Route { get; private set; }
        public string specialization { get; private set; }
        public int currentNkz { get; private set; }
        public int totalNkz { get; private set; }
        public bool isTeach { get; private set; }
        


       public Student(string lestName, String firstName, int numStudent) 
        {
            this.firstName = firstName;
            this.lestName = lestName;
            this.numStudent = numStudent;
           /* this.Route = Route;
            this.currentNkz = currentNkz;
            this.totalNkz = totalNkz;
            if (isTeach)
            {
                this.isTeach = true;
                List<string> course = new List<string>();
            }else
            {
                this.isTeach = false;
            }*/
        }


    }
}
