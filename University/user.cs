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

        private String firstName;
        private String lastName;
        private String email;
        private string iD;
        private String UserName;
        private String password;




        public User(string firstName, string lastName, string email, String iD, string userName, string password)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
            SetEmail(email);
            SetID(iD);
            SetUserName(userName);
            SetPassword(password);
        }

        public string GetID()
        {
            return iD;
        }

        private void SetID(string value)
        {
            iD = value;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        private void SetFirstName(string value)
        {
            firstName = value;
        }

        public string GetLastName()
        {
            return lastName;
        }

        private void SetLastName(string value)
        {
            lastName = value;
        }
        public string GetEmail()
        {
            return email;
        }

        private void SetEmail(string value)
        {
            email = value;
        }
        public string GetUserName()
        {
            return UserName;
        }
        private void SetUserName(string value)
        {
            UserName = value;
        }

        public string GetPassword()
        {
            return password;
        }
        private void SetPassword(string value)
        {
            password = value;
        }

        
       


    }


}
