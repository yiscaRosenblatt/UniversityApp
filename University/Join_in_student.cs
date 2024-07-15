using Microsoft.VisualBasic.ApplicationServices;

namespace University
{
    public partial class Join_in_student : Form
    {
        private String UsurName;
        private String Password;
        public Join_in_student()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UsurName = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Password = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_up_student Sign_up = new Sign_up_student();
            Sign_up.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isExists = false;
            for (int i = 0; i < Sign_up_student.users.Count; i++)
            {
                if (Sign_up_student.users[i].GetUserName().Equals(UsurName) && Sign_up_student.users[i].GetPassword().Equals(Password)){
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                    isExists = true;
                }
            }
            if (!isExists) 
            {
                MessageBox.Show("UserName or Password isn't corect");
            }

            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frontFage frontFage = new frontFage();
            frontFage.Show();
            this.Hide();
        }
    }
}
