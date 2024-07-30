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

namespace University
{
    public partial class HomePage : Form
    {

        System.Drawing.Color text;
        System.Drawing.Color back;
        System.Drawing.Color button = System.Drawing.Color.LightGray;

        public HomePage()
        {
            if (Settings.DarkMode)
            {
                text = System.Drawing.Color.White;
                back = System.Drawing.Color.Black;
            }
            else
            {
                back = System.Drawing.Color.White;
                text = System.Drawing.Color.Black;
            }
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonalInformation PersonalInformation = new PersonalInformation();
            PersonalInformation.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            messages.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            peopleSearch peopleSearch = new peopleSearch();
            peopleSearch.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void logOutButtun_Click(object sender, EventArgs e)
        {
            FrontPage frontpage = new FrontPage();
            frontpage.Show();
            this.Hide();
        }
    }
}
