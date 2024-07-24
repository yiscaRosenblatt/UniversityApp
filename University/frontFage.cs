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
using System;
using System.Drawing;
using System.Windows.Forms;

namespace University
{
    public partial class FrontPage : Form
    {
        private Color text;
        private Color back;
        private Color buttonColor = Color.LightGray;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Join_in_student joinInStudent = new Join_in_student();
            joinInStudent.Show();
            this.Hide();
        }



        private void FrontPage_Load(object sender, EventArgs e)
        {
            if (Settings.DarkMode)
            {
                text = Color.White;
                back = Color.Black;
            }
            else
            {
                back = Color.White;
                text = Color.Black;
            }
        }

        private void LecturerButton_Click(object sender, EventArgs e)
        {
            Join_in_lecturer joinInLecturer = new Join_in_lecturer();
            joinInLecturer.Show();
            this.Hide();
        }

     
    }
}

