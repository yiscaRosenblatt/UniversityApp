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
    public partial class ShowLecturers : Form
    {
        public ShowLecturers()
        {
            InitializeComponent();
        }

        private void ShowLecturers_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("first name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Last Name", -2);

            displayAllLecturer();
        }

        private void displayAllLecturer()
        {
            listView1.Items.Clear();
            foreach (Lecturer lecturer in Sign_up_lecturer.lecturers)
            {
                string[] row = { lecturer.firstName, lecturer.lastName };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }

            foreach (ColumnHeader column in this.listView1.Columns)
            {
                column.Width = -2;
            }

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            EditLecturer EditLecturer = new EditLecturer();
            EditLecturer.Show();
            this.Hide();
        }

        private void clicked_lecturer_item(object sender, EventArgs e)
        {
            /*if (listView1.SelectedItems.Count > 0)
            {*//*
                ListViewItem clickedStudent = listView1.SelectedItems[0];
                string firstName = clickedStudent.SubItems[0].Text;
                string lestName = clickedStudent.SubItems[1].Text;*/

                /*this.Hide();*/
           /* }*/
            EditLecturer EditLecturer = new EditLecturer();
            EditLecturer.Show();
            this.Hide();
        }


    }
}
