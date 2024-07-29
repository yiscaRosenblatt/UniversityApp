using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace University.Forms
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();


        }
        public static List<Course> ListCourse = new List<Course>();

        private void Courses_Load(object sender, EventArgs e)
        {
            button_Add.Visible = false;

            if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].isDepartmentHead)
            {
                button_Add.Visible = true;
            }

            listView1.View = View.Details;
            listView1.Columns.Add("name");

            displayALLCourses();

        }

        private void displayALLCourses()
        {
            listView1.Items.Clear();
            for (int i = 0; i < Courses.ListCourse.Count; i++)
            {
                if (ListCourse.Count > 0)
                {
                   
                    string nameCorse = ListCourse[i].Name;
                    string[] row = {nameCorse};
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);
                   

                }
            }

        }

        private void clicked_listView1_item(object sender, EventArgs e)
        {

           
                ListViewItem clickedlistView1 = listView1.SelectedItems[0];
                string nameCourse = clickedlistView1.SubItems[0].Text;
                EditCourses EditCourses = new EditCourses(nameCourse);
                EditCourses.Show();
            

            /*  ListViewItem clickedUser = people_listView.SelectedItems[0];
              string userEmail = clickedUser.SubItems[2].Text;
              string userName = clickedUser.SubItems[0].Text + " " + clickedUser.SubItems[1].Text;
              User U = Sign_up_lecturer.users.FirstOrDefault(x => x.Email.Equals(userEmail));
              sendMessage sendMessage = new sendMessage(userName, U);
              sendMessage.Show();*/


        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            
            EditCourses EditCourses = new EditCourses("x");
            EditCourses.Show();
            this.Close();
        }
    }
}
