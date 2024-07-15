using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class user
    {
        private static List<User> users = new List<User>();
     
        private String firstName { get; set; }
        private String lastName { get; set; }
        private String email { get; set; }
        private int ID { get; set; }
        private String userName { get; set; }
        private String password { get; set; }

        

        public user( string firstName, string lastName, string email, int iD, string userName, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            ID = iD;
            this.userName = userName;
            this.password = password;
        }

        public static void addUser(user user)
        {
           for (int i = 0; i < users.Count; i++)
            {
                if (users[i].userName)
            }
        }

       
        
       

    }


}
