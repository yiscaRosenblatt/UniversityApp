using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace University
{
    public partial class Sign_up_lecturer : Form
    {
        private string P_name;
        private string P_lastName;
        private string P_password;
        private string P_email;
        private string P_ID;
        private string P_userName;
        private string P_passwordAuthentication;
/*        private string P_codeLecturer;
*/        public static List<User> users = new List<User>();
        public Sign_up_lecturer()
        {
            InitializeComponent();
        }



        private void titleLecturer_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Join_in_lecturer Join_in_lecturer = new Join_in_lecturer();
            Join_in_lecturer.Show();
            this.Hide();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (P_name == null)
            {
                MessageBox.Show("You have to enter a name");
            }
            else if (P_lastName == null)
            {
                MessageBox.Show("You have to enter a lest name");
            }
            else if (P_ID == null)
            {
                MessageBox.Show("You have to enter a ID");
            }
            else if (P_email == null)
            {
                MessageBox.Show("You have to enter a email");
            }
            else if (P_userName == null)
            {
                MessageBox.Show("You have to enter a user name");
            }
            else if (P_password == null)
            {
                MessageBox.Show("You have to enter a password");
            }
            else if (P_passwordAuthentication == null)
            {
                MessageBox.Show("You have to enter a Password Authentication");
            }
          /*  else if (P_codeLecturer == null)
            {
                MessageBox.Show("You have to enter the code from the lecturer");
            }
            else if (P_codeLecturer != "3242")
            {
                MessageBox.Show("The code is incorrect");

            }*/
            else if (!P_password.Equals(P_passwordAuthentication))
            {
                MessageBox.Show("the password and the chekPassword not the same");
            }
            else
            {
                User newUser = new User(P_name, P_lastName, P_email, P_ID, P_userName, P_password);
                AddUser(newUser);
            }
        }
        private void AddUser(User newUser)
        {
            bool isTaking = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].GetID().Equals(newUser.GetID()))
                {
                    MessageBox.Show("this ID in the system. Are you pretending to be someone else????????? ");
                    isTaking = true;
                }
                else if (users[i].GetUserName().Equals(newUser.GetUserName()))
                {
                    MessageBox.Show("this User Name is taking. Try something else");
                    isTaking = true;
                }
                else if (users[i].GetPassword().Equals(newUser.GetPassword()))
                {
                    MessageBox.Show("this Password is taking. Try something else");
                    isTaking = true;
                }
            }
            if (!isTaking)
            {
                users.Add(newUser);
                MessageBox.Show("Your sign up was successful");
            }

        }

        private void inputFirstName_TextChanged(object sender, EventArgs e)
        {
            P_name = inputFirstName.Text;
        }

        private void inputLastName_TextChanged(object sender, EventArgs e)
        {
            P_lastName = inputLastName.Text;
        }

        private void inputID_TextChanged(object sender, EventArgs e)
        {
            P_ID = inputID.Text;
        }

        private void inputEmail_TextChanged(object sender, EventArgs e)
        {
            P_email = inputEmail.Text;
        }

        private void inputUserName_TextChanged(object sender, EventArgs e)
        {
            P_userName = inputUserName.Text;
        }

        private void inputPassword_TextChanged(object sender, EventArgs e)
        {
            P_password = inputPassword.Text;
        }

        private void inputPasswordAuthentication_TextChanged(object sender, EventArgs e)
        {
            P_passwordAuthentication = inputPasswordAuthentication.Text;
        }

     /*   private void inputCodeLecturer_TextChanged(object sender, EventArgs e)
        {
            P_codeLecturer = inputCodeLecturer.Text;
        }*/
    }
}
