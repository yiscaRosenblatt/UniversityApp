﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using University.Datamodels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University
{
    public class User
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string ID { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public bool isStident { get; set; }
        public int age { get; set; }
        public string phon { get; set; }
        public Image image { get; set; }
        public bool isDepartmentHead { get; set; }
        public List<Messages_setting> mesges;
        public static string path = $"{Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\"))}\\Resources\\na,na.png";





        public User(string firstName, string lastName, string email, string id, string userName, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.ID = id;
            this.UserName = userName;
            this.Password = password;
            this.isStident = false;
            this.isDepartmentHead = false;
            this.image = Image.FromFile(path);
            this.mesges = new List<Messages_setting>();
        }

        public string GetID()
        {
            return ID;
        }

        private void SetID(string value)
        {
            ID = value;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        private void SetFirstName(string value)
        {
            FirstName = value;
        }

        public string GetLastName()
        {
            return LastName;
        }

        private void SetLastName(string value)
        {
            LastName = value;
        }
        public string GetEmail()
        {
            return Email;
        }

        private void SetEmail(string value)
        {
            Email = value;
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
            return Password;
        }
        private void SetPassword(string value)
        {
            Password = value;
        }

        
       


    }


}
