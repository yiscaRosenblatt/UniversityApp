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
    public partial class fsettings : Form
    {

        System.Drawing.Color text;
        System.Drawing.Color back;
        System.Drawing.Color button = System.Drawing.Color.LightGray;


        public fsettings()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.DarkMode = !Settings.DarkMode;
            if(button1.Text == "Light")
            {
                button1.Text = "Dark";
            }
            else
            {
                button1.Text = "Light";
            }

            fsettings fs = new fsettings();
            fs.Show();
            this.Hide();
        }
    }
}
