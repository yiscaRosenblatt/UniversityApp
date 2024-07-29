using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class peopleSearch : Form
    {

        public peopleSearch()
        {
            InitializeComponent();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            people_listView.Items.Clear();
            if (!this.textBox1.Text.Equals(""))
            {
                foreach (User student in Sign_up_lecturer.users)
                {
                    if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].isStident == true)
                    {
                        if (student.isStident) continue;

                        if ((student.FirstName + " " + student.LastName).Contains(textBox1.Text))
                        {
                            string[] row = { student.FirstName, student.LastName, student.Email };
                            ListViewItem item = new ListViewItem(row);
                            people_listView.Items.Add(item);
                        }
                    }
                    else
                    {
                        if ((student.FirstName + " " + student.LastName).Contains(textBox1.Text))
                        {
                            string[] row = { student.FirstName, student.LastName, student.Email };
                            ListViewItem item = new ListViewItem(row);
                            people_listView.Items.Add(item);
                        }
                    }

                }
                foreach (ColumnHeader column in this.people_listView.Columns)
                {
                    column.Width = -2; // Auto resize based on content
                }
            }
            else
            {
                if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].isStident == true)
                {
                    displayAllStudent();
                }
                else
                {
                    displayAllStudentAndlecturer();
                }
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
        }

        private void peopleSearch_Load(object sender, EventArgs e)
        {
            people_listView.View = View.Details;
            people_listView.Columns.Add("first name", -2, HorizontalAlignment.Left);
            people_listView.Columns.Add("Last Name", -2);
            people_listView.Columns.Add("Email", -2);
            if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].isStident == true)
            {
                displayAllStudent();
            }
            else
            {
                displayAllStudentAndlecturer();
            }
            
        }

        private void displayAllStudent()
        {
            people_listView.Items.Clear();
            foreach (User student in Sign_up_lecturer.users)
            {

                if (!student.isStident) continue;
                string[] row = { student.FirstName, student.LastName, student.Email };
                ListViewItem item = new ListViewItem(row);
                people_listView.Items.Add(item);
            }

            foreach (ColumnHeader column in this.people_listView.Columns)
            {
                column.Width = -2; 
            }

        }

        private void displayAllStudentAndlecturer()
        {
            people_listView.Items.Clear();
            foreach (User student in Sign_up_lecturer.users)
            {
                string[] row = { student.FirstName, student.LastName, student.Email };
                ListViewItem item = new ListViewItem(row);
                people_listView.Items.Add(item);
            }

            foreach (ColumnHeader column in this.people_listView.Columns)
            {
                column.Width = -2; 
            }
        }


        private void clicked_user_item(object sender, EventArgs e)
        {
            ListViewItem clickedUser = people_listView.SelectedItems[0];
            string userEmail = clickedUser.SubItems[2].Text;
            string userName = clickedUser.SubItems[0].Text + " " + clickedUser.SubItems[1].Text;
            User U = Sign_up_lecturer.users.FirstOrDefault(x => x.Email.Equals(userEmail));
            sendMessage sendMessage = new sendMessage(userName, U);
            sendMessage.Show();


        }

        private void people_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
