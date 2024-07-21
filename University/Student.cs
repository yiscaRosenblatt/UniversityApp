using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Student : Person
    {
        private int numStudent;
        private String Route;
        private string specialization;
        private int currentNkz;
        private int totalNkz;
        private bool isTeach;
        


       public Student(int numStudent, String Route, string specialization, int currentNkz, int totalNkz, bool isTeach) 
        {
            this.numStudent = numStudent;
            this.Route = Route;
            this.specialization = specialization;
            this.currentNkz = currentNkz;
            this.totalNkz = totalNkz;
            if (isTeach)
            {
                this.isTeach = true;
                List<string> course = new List<string>();
            }else
            {
                this.isTeach = false;
            }
        }


    }
}
