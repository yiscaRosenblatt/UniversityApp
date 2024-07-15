using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace University
{
    public partial class Sign_up_lecturer : Form
    {
        public Sign_up_lecturer()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String name = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String lastName = textBox1.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            String ID = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            String email = textBox7.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            String userName = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            String password = textBox4.Text;
        }

        
    }
}
