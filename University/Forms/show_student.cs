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

namespace University.Forms
{
    public partial class show_student : Form
    {
        public show_student()
        {
            InitializeComponent();
        }

        private void show_student_Load(object sender, EventArgs e)
        {
            button_Add.Visible = false;

            if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].isDepartmentHead)
            {
                button_Add.Visible = true;
            }

            listView1.View = View.Details;
            listView1.Columns.Add("first name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Last Name", -2);

            displayAllStudent();
        }

        private void displayAllStudent()
        {
            listView1.Items.Clear();
            foreach (Student student in Sign_up_student.students)
            {

               
                string[] row = { student.firstName, student.lestName };
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
            EditStusent1 EditStusent1 = new EditStusent1();
            EditStusent1.Show();
            this.Close();
        }

        private void clicked_student_item(object sender, EventArgs e)
        {
            /*ListViewItem clickedStudent = listView1.SelectedItems[0];
            string firstName = clickedStudent.SubItems[0].Text;
            string lestName = clickedStudent.SubItems[1].Text;*/
            EditStusent1 editStusent1 = new EditStusent1();
            editStusent1.Show();
            this.Close();
        }
    }
}
