using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Location = new Point(label8.Right + 10, label8.Top),
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
                Location = new Point(label7.Right + 10, label7.Top),
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
            if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].isStident)
            {
                if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].age == 0)
                {

                    textBoxAge.Visible = true;
                    buttonUpdateAge.Visible = true;
                }
                else
                {
                    label7.Text = "Age: " + Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].age;
                }
            }
        }

        private void ButtonUpdateAge_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBoxAge.Text, out int newAge) && newAge > 0)
            {

                Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].age = newAge;
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
            if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].isStident)
            {
                if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].phon == 0)
                {

                    textBoxPhone.Visible = true;
                    buttonUpdatePhone.Visible = true;
                }
                else
                {
                    label8.Text = "Phone: " + Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].phon;
                }
            }
        }
        private void ButtonUpdatePhone_Click(object sender, EventArgs e)
        {

            if (float.TryParse(textBoxPhone.Text, out float newPhone) && newPhone > 0)
            {
                Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].phon = newPhone;
                textBoxPhone.Visible = false;
                buttonUpdatePhone.Visible = false;
                label8.Text = "Phone: " + newPhone;
            }
            else
            {
                MessageBox.Show("Please enter a valid Phone.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].isStident)
            {
                if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].image == null)
                {

                }
            }
        }

        Image newImage = Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].image;
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
                    Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].image = newImage;
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

        private void PersonalInformation_Load(object sender, EventArgs e)
        {
            if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].isStident)
            {
                if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].mesges.Count > 0)
                {
                    listBox1.Items.Add(Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].mesges[Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].mesges.Count - 1]);
                }
                else
                {
                    listBox1.Items.Add("No messages available.");
                }
            }
        }
    }
}
