using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class User
    {
        private static List<User> users = new List<User>();
     
        private String firstName { get; set; }
        private String lastName { get; set; }
        private String email { get; set; }
        private int ID { get; set; }
        private String UserName { get; set; }
        private String password { get; set; }

        

        public User(string firstName, string lastName, string email, int iD, string userName, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            ID = iD;
            this.UserName = userName;
            this.password = password;
        }

       public static void addUser(User user)
        {
            bool userExists = users.Any(u => u.UserName == user.UserName);

            if (!userExists)
            {
                users.Add(user);
                Console.WriteLine("User added successfully.");
            }
            else
            {
                Console.WriteLine("Username already exists. User not added.");
            }
        }

       
        
       

    }


}
