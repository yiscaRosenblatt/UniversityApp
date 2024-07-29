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
    public partial class EditLecturer : Form
    {
        public EditLecturer()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_firstName != null && textBox_lestName != null)
            {
                if (isLecturerExists() == -1)
                {
                    Lecturer lecturer = new Lecturer(textBox_firstName.Text, textBox_lestName.Text, 0);
                    if ((Sign_up_lecturer.lecturers.Count) == 0)
                    {
                        lecturer = new Lecturer(textBox_firstName.Text, textBox_lestName.Text, 0);
                    }
                    else
                    {
                        lecturer = new Lecturer(textBox_firstName.Text, textBox_lestName.Text, Sign_up_lecturer.lecturers[Sign_up_lecturer.lecturers.Count - 1].numEmployee + 1);
                    }


                    Sign_up_lecturer.lecturers.Add(lecturer);
                    MessageBox.Show("Add Successfully");
                    ShowLecturers ShowLecturers = new ShowLecturers();
                    ShowLecturers.Show();
                    this.Close();
                }

            }

            else
            {
                MessageBox.Show("The name or student is empty");
            }
        }


        public int isLecturerExists()
        {
            string firstName = textBox_firstName.Text.Trim();

            string lestName = textBox_lestName.Text.Trim();
            for (int i = 0; i < Sign_up_lecturer.lecturers.Count; i++)
            {
                if (firstName.Equals(Sign_up_lecturer.lecturers[i].firstName) && lestName.Equals(Sign_up_lecturer.lecturers[i].lastName))
                {
                    return i;
                }
            }
            return -1;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_firstName != null && textBox_lestName != null)
            {
                if (isLecturerExists() != -1)
                {
                    Sign_up_lecturer.lecturers.RemoveAt(isLecturerExists());
                    MessageBox.Show("lecturer deleted successfully.");
                    ShowLecturers ShowLecturers = new ShowLecturers();
                    ShowLecturers.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ther is no this lecturer");
                }
            }
        }
    }
}
