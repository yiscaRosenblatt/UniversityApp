using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace University
{
    public partial class Sign_up_student : Form
    {
        private string name;
        private string lestName;
        private string password;
        private string email;
        private string ID;
        private string userName;
        private string chekPassword;
        public static List<User> userStudemt = new List<User>();
        public static int corentUserStudent { get; set; }



        public Sign_up_student()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Join_in_student Join_in_student = new Join_in_student();
            Join_in_student.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lestName = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ID = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            email = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            userName = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            password = textBox6.Text;
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            chekPassword = textBox7.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name == null)
            {
                MessageBox.Show("You have to enter a name");
            }
            else if (lestName == null)
            {
                MessageBox.Show("You have to enter a lest name");
            }
            else if (ID == null)
            {
                MessageBox.Show("You have to enter a ID");
            }
            else if (email == null)
            {
                MessageBox.Show("You have to enter a email");
            }
            else if (userName == null)
            {
                MessageBox.Show("You have to enter a user name");
            }
            else if (password == null)
            {
                MessageBox.Show("You have to enter a password");
            }
            else if (chekPassword == null)
            {
                MessageBox.Show("You have to enter a Password Authentication");
            }
            else if (!password.Equals(chekPassword))
            {
                MessageBox.Show("the password and the chekPassword not the same");
            }
            else
            {
                User newUser = new User(name, lestName, email, ID, userName, password);
                AddUser(newUser);
            }
        }

        private void AddUser(User newUser)
        {
            bool isTaking = false;
            for (int i = 0; i < userStudemt.Count; i++)
            {
                if (userStudemt[i].GetID().Equals(newUser.GetID()))
                {
                    MessageBox.Show("this ID in the system");
                    isTaking = true;
                }
                else if (userStudemt[i].GetUserName().Equals(newUser.GetUserName()))
                {
                    MessageBox.Show("this User Name is taking");
                    isTaking = true;
                }
                else if (userStudemt[i].GetPassword().Equals(newUser.GetPassword()))
                {
                    MessageBox.Show("this Password is taking");
                    isTaking = true;
                }
            }
            if (!isTaking)
            {
                userStudemt.Add(newUser);
                MessageBox.Show("you sign up sucssfly");
            }

            

        }
    }
}
