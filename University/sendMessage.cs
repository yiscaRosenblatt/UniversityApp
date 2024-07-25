using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University
{
    public partial class sendMessage : Form
    {
        public User U { get; }

        public sendMessage(string userName, User U)
        {
            InitializeComponent();
            label1.Text = "To " + userName;
            this.U = U;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = richTextBox1.Text;
            U.mesges.Add(message);
            MessageBox.Show("the message send");
            this.Close();
        }
    }
}



/*private void send_Click(object sender, EventArgs e)
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
}*/
