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
        String Search = "";
        private System.Windows.Forms.Label textBoxShrech;
        private Button buttonMesges;
        private TextBox writingMessage;
        private Button send;




        public peopleSearch()
        {
            InitializeComponent();

            textBoxShrech = new System.Windows.Forms.Label
            {
                Location = new Point(35, 124),
                Width = 500,
                Visible = false

            };
            this.Controls.Add(textBoxShrech);

            buttonMesges = new Button
            {
                Location = new Point(textBoxShrech.Right + 20, 124),
                Visible = false,
                Text = "mesages"
            };
            buttonMesges.Click += new EventHandler(this.buttonMesges_Click);

            this.Controls.Add(buttonMesges);

            writingMessage = new TextBox
            {
                Location = new Point(textBoxShrech.Left, textBoxShrech.Top + 50),
                Visible = false,
                Width = 500,
                Height = 500
            };

            this.Controls.Add(writingMessage);

            send = new Button
            {
                Location = new Point(writingMessage.Left, writingMessage.Top + 50),
                Visible = false,

            };
            send.Click += new EventHandler(this.send_Click);
            this.Controls.Add(send);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search = textBox1.Text;
           
        }
        int sendPeople = 0;
        String firstName = "";
        String lastName = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].isStident)
            {
               
                if (!string.IsNullOrWhiteSpace(Search))
                {
                   
                    int spaceIndex = Search.IndexOf(' ');
                    if (spaceIndex > 0) 
                    {
                        firstName = Search.Substring(0, spaceIndex);
                        lastName = Search.Substring(spaceIndex + 1);
                    }
                    else
                    {
                        MessageBox.Show("Please enter both first and last names separated by a space.");
                        return;
                    }

                  
                    if (char.IsLetter(Search[0]))
                    {
                        for (int i = 0; i < Sign_up_student.userStudemt.Count; i++)
                        {
                            var student = Sign_up_student.userStudemt[i];
                            if (student.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                                student.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                            {
                                textBoxShrech.Visible = true;
                                buttonMesges.Visible = true;
                                textBoxShrech.Text = "Name: " + student.FirstName + " " + student.LastName + " Email: " + student.Email;
                                sendPeople = i;
                                return; 
                            }
                        }
                        MessageBox.Show("Student not found. Please check the entered name.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a search query.");
                }
            }
        }

        private void buttonMesges_Click(object sender, EventArgs e)
        {
            writingMessage.Visible = true;
            send.Visible = true;
        }

        
        private void writingMessage_Click(object sender, EventArgs e)
        {
           
        }

        private void send_Click(object sender, EventArgs e)
        {
            string message = writingMessage.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                Sign_up_student.userStudemt[sendPeople].mesges.Add(message);
                MessageBox.Show("Message sent successfully!");
                writingMessage.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a message before sending.");
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
    }
}
