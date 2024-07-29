using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;


namespace University
{
    public partial class Join_in_lecturer : Form
    {
        private String UsurName;
        private String PasswordP;

        public Join_in_lecturer()
        {
            InitializeComponent();
        }
        private void inputUserName_TextChanged(object sender, EventArgs e)
        {
            UsurName = inputUserName.Text;
        }

        private void inputPassword_TextChanged(object sender, EventArgs e)
        {
            PasswordP = inputPassword.Text;
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            Sign_up_lecturer Sign_up = new Sign_up_lecturer();
            Sign_up.Show();
            this.Hide();
        }

        private void buttonJoinIn_Click(object sender, EventArgs e)
        {
            bool isExists = false;
            for (int i = 0; i < Sign_up_lecturer.users.Count; i++)
            {
                if (Sign_up_lecturer.users[i].GetUserName().Equals(UsurName) && Sign_up_lecturer.users[i].GetPassword().Equals(PasswordP))
                {
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                    isExists = true;
                    Sign_up_lecturer.corentUser = i;
                }
            }
            if (!isExists)
            {
                MessageBox.Show("UserName or Password isn't corect");
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FrontPage frontPage = new FrontPage();
            frontPage.Show();
            this.Hide();
        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void titleLecturer_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            FrontPage frontPage = new FrontPage();
            frontPage.Show(this);
            this.Hide();
        }
    }
}
