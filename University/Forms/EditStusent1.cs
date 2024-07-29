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
    public partial class EditStusent1 : Form
    {
        public EditStusent1()
        {
            InitializeComponent();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_firstName != null && textBox_lestName != null)
            {
                if (isStudentExists() != -1)
                {
                    Sign_up_student.students.RemoveAt(isStudentExists());
                    MessageBox.Show("student deleted successfully.");
                    show_student show_student = new show_student();
                    show_student.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ther is no this student");
                }
            }
        }

        public int isStudentExists()
        {
            string firstName = textBox_firstName.Text.Trim();

            string lestName = textBox_lestName.Text.Trim();
            for (int i = 0; i < Sign_up_student.students.Count; i++)
            {
                if (firstName.Equals(Sign_up_student.students[i].firstName) && lestName.Equals(Sign_up_student.students[i].lestName))
                {
                    return i;
                }
            }
            return -1;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_firstName != null && textBox_lestName != null)
            {
                if (isStudentExists() == -1)
                {
                    Student Student = new Student(textBox_lestName.Text, textBox_firstName.Text, 0);
                    if ((Sign_up_student.students.Count) == 0)
                    {
                        Student = new Student(textBox_lestName.Text, textBox_firstName.Text, 0);
                    }
                    else
                    {
                        Student = new Student(textBox_lestName.Text, textBox_firstName.Text, Sign_up_student.students[Sign_up_student.students.Count - 1].numStudent + 1);
                    }

                    
                    Sign_up_student.students.Add(Student);
                    MessageBox.Show("Add Successfully");
                    show_student show_student = new show_student();
                    show_student.Show();
                    this.Close();
                }

            }



            else
            {
                MessageBox.Show("The name or student is empty");
            }
        }

       
    }
}
