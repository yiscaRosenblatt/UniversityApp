using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University.Forms
{
    public partial class EditCourses : Form
    {
        public EditCourses(string nameCourse)
        {
            InitializeComponent();
            this.Name = nameCourse;
        }


        private void button_AddNewCourses_Click(object sender, EventArgs e)
        {
            if (textBox_nameCourse != null)
            {
                if (isCourseExists() == -1)
                {
                    List<Student> students = new List<Student>();

                    Course course = new Course(textBox_nameCourse.Text, students);
                    Courses.ListCourse.Add(course);
                    MessageBox.Show("Add Successfully");
                    Courses paeg_Courses = new Courses();
                    paeg_Courses.Show();
                    this.Close();
                }
               
            }



            else
            {
                MessageBox.Show("The name or student is empty");
            }

        }



        public int isCourseExists()
        {
            string courseName = textBox_nameCourse.Text.Trim();

            for (int i = 0; i < Courses.ListCourse.Count; i++)
            {
                if (courseName.Equals(Courses.ListCourse[i].Name))
                {
                    return i;
                }
            }
            return -1;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_nameCourse != null)
            {
                if (isCourseExists() != -1)
                {
                    Courses.ListCourse.RemoveAt(isCourseExists());
                    MessageBox.Show("Course deleted successfully.");
                    Courses paeg_Courses = new Courses();
                    paeg_Courses.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ther is no this course");
                }
            }
        }

       /* private void button_EditCourses_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Courses.ListCourse.Count; i++)
            {
                if (Courses.ListCourse[i].Equals(Name))
                {
                    Courses.ListCourse[i].Name = Name;
                    MessageBox.Show("name chang successfully");
                    Courses paeg_Courses = new Courses();
                    paeg_Courses.Show();
                    this.Close();
                }

            }
        }*/

        private void EditCourses_Load(object sender, EventArgs e)
        {
            button_AddNewCourses.Visible = false;
            button_delete.Visible = false;
            button_EditCourses.Visible = false;

            if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].isDepartmentHead == true)
            {
                button_AddNewCourses.Visible = true;
                button_delete.Visible = true;
                button_EditCourses.Visible = true;

            }

        }
    }
}
