using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Datamodels;
using University.Forms;

namespace University
{
    public partial class PersonalInformation : Form
    {
        private TextBox textBoxAge;
        private Button buttonUpdateAge;
        private TextBox textBoxPhone;
        private Button buttonUpdatePhone;



        public PersonalInformation()
        {
            InitializeComponent();

            textBoxPhone = new TextBox
            {
                Location = new Point(label8.Right + 70, label8.Top),
                Width = 50,
                Visible = false
            };
            this.Controls.Add(textBoxPhone);
            buttonUpdatePhone = new Button
            {
                Text = "Update Phone",
                Location = new Point(textBoxPhone.Right + 5, textBoxPhone.Top),
                Visible = false
            };
            buttonUpdatePhone.Click += new EventHandler(this.ButtonUpdatePhone_Click);
            this.Controls.Add(buttonUpdatePhone);



            textBoxAge = new TextBox
            {
                Location = new Point(label7.Right + 70, label7.Top),
                Width = 50,
                Visible = false
            };
            this.Controls.Add(textBoxAge);


            buttonUpdateAge = new Button
            {
                Text = "Update Age",
                Location = new Point(textBoxAge.Right + 5, textBoxAge.Top),
                Visible = false // Initially hidden
            };
            buttonUpdateAge.Click += new EventHandler(this.ButtonUpdateAge_Click);
            this.Controls.Add(buttonUpdateAge);


        }

        private void label4_Click(object sender, EventArgs e)
        {
            /*if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].isStident)
            {
                label4.Text = "Name: " + Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].FirstName + " " + Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].LastName;
            }*/
        }

        private void label5_Click(object sender, EventArgs e)
        {
            /*if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].isStident)
            {
                label5.Text = "Email: " + Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].Email;
            }*/
        }

        private void label6_Click(object sender, EventArgs e)
        {
            /* if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].isStident)
             {
                 label6.Text = "ID: " + Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].ID;
             }*/
        }

        private void label7_Click(object sender, EventArgs e)
        {



        }

        private void ButtonUpdateAge_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBoxAge.Text, out int newAge) && newAge > 0)
            {

                Sign_up_lecturer.users[Sign_up_lecturer.corentUser].age = newAge;
                textBoxAge.Visible = false;
                buttonUpdateAge.Visible = false;
                label7.Text = "Age: " + newAge;
            }
            else
            {
                MessageBox.Show("Please enter a valid age.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void label8_Click(object sender, EventArgs e)
        {
            /*  if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].phon == null)
                {

                    textBoxPhone.Visible = true;
                    buttonUpdatePhone.Visible = true;
                }*/
            /* else
             {
                 label8.Text = "Phone: " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].phon;
             }*/


        }
        private void ButtonUpdatePhone_Click(object sender, EventArgs e)
        {

            string newPhone = textBoxPhone.Text;
            Sign_up_lecturer.users[Sign_up_lecturer.corentUser].phon = newPhone;
            textBoxPhone.Visible = false;
            buttonUpdatePhone.Visible = false;
            label8.Text = "Phone: " + newPhone;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        Image newImage;
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select a Profile Picture";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    newImage = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.Image = newImage;
                    Sign_up_lecturer.users[Sign_up_lecturer.corentUser].image = newImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Join_in_student Join_in_student = new Join_in_student();
            Join_in_student.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }








        /* private void PersonalInformation_Load(object sender, EventArgs e)
         {

             *//*if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges.Count > 0)
             {
                 listView1.Items.Add(Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges[Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges.Count - 1].text);
             }
             else
             {
                 listView1.Items.Add("No messages available.");
             }*//*
             label4.Text = "Name: " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].FirstName + " " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].LastName;

             label5.Text = "Email: " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].Email;

             label6.Text = "ID: " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].ID;

             if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].age == 0)
             {
                 label7.Text = "Age: ";
                 textBoxAge.Visible = true;
                 buttonUpdateAge.Visible = true;
             }
             else
             {
                 label7.Text = "Age: " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].age;
             }


             if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].phon == null)
             {
                 label8.Text = "Phone: ";
                 textBoxPhone.Visible = true;
                 buttonUpdatePhone.Visible = true;
             }
             else
             {
                 label8.Text = "Phone: " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].phon;
             }
             pictureBox1.Image = Sign_up_lecturer.users[Sign_up_lecturer.corentUser].image;


             button_Course.Visible = false;
             button_lectueer.Visible = false;
             button_Roures.Visible = false;
             button_Student.Visible = false;



             listView1.View = View.Details;
             listView1.Columns.Add("name", -2, HorizontalAlignment.Left);
             listView1.Columns.Add("text", -2);
             listView1.Columns.Add("date", -2);

             displayMseges();

         }*/

        private void displayMseges()
        {
            if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges.Count > 0)
            {
                listView1.Items.Clear();
                string sendName = Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges[Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges.Count - 1].SendedName;
                string text = Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges[Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges.Count - 1].text;
                string date = Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges[Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges.Count - 1].Date.ToString("yyyy-MM-dd HH:mm:ss"); ;

                string[] row = { sendName, text, date };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);


                foreach (ColumnHeader column in this.listView1.Columns)
                {
                    column.Width = -2;
                }

            }

        }

        private void button_lectueer_Click(object sender, EventArgs e)
        {
            ShowLecturers ShowLecturers = new ShowLecturers();
            ShowLecturers.Show();

        }

        private void PersonalInformation_Load_1(object sender, EventArgs e)
        {
            label4.Text = "Name: " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].FirstName + " " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].LastName;

            label5.Text = "Email: " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].Email;

            label6.Text = "ID: " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].ID;

            if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].age == 0)
            {
                label7.Text = "Age: ";
                textBoxAge.Visible = true;
                buttonUpdateAge.Visible = true;
            }
            else
            {
                label7.Text = "Age: " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].age;
            }


            if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].phon == null)
            {
                label8.Text = "Phone: ";
                textBoxPhone.Visible = true;
                buttonUpdatePhone.Visible = true;
            }
            else
            {
                label8.Text = "Phone: " + Sign_up_lecturer.users[Sign_up_lecturer.corentUser].phon;
            }
            pictureBox1.Image = Sign_up_lecturer.users[Sign_up_lecturer.corentUser].image;


            button_Course.Visible = false;
            button_lectueer.Visible = false;
            button_Student.Visible = false;



            listView1.View = View.Details;
            listView1.Columns.Add("name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("text", -2);
            listView1.Columns.Add("date", -2);

            displayMseges();

            listView2.View = View.Details;
            listView2.Columns.Add("name", -2, HorizontalAlignment.Left);
            listView2.Columns.Add("text", -2);
            listView2.Columns.Add("date", -2);
            displayFivoritMseges();


            if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].isDepartmentHead)
            {
                button_Course.Visible = true;
                button_lectueer.Visible = true;
                button_Student.Visible = true;


            }
            if (!Sign_up_lecturer.users[Sign_up_lecturer.corentUser].isStident)
            {
                button_Course.Visible = true;
                button_Student.Visible = true;
            }

            if (Sign_up_lecturer.users[Sign_up_lecturer.corentUser].isStident)
            {
                button_Course.Visible = true;

            }

        }

        private void button_Course_Click(object sender, EventArgs e)
        {
            Courses Courses = new Courses();
            Courses.Show();




        }

        private void button_Student_Click(object sender, EventArgs e)
        {
            show_student show_student = new show_student();
            show_student.Show();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void displayFivoritMseges()
        {
            listView2.Items.Clear();



            foreach (Messages_setting messagest in Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges)
            {
                if (messagest.isFivorit == true)
                {
                    String theSender = messagest.SendedName;
                    String theText = messagest.text;
                    String date = messagest.Date.ToString("yyyy-MM-dd HH:mm:ss");
                    String[] row = { theSender, theText, date };
                    ListViewItem item = new ListViewItem(row);
                    listView2.Items.Add(item);
                }

            }
            foreach (ColumnHeader column in this.listView2.Columns)
            {
                column.Width = -2;
            }
        }
    





        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
