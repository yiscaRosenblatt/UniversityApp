
namespace University
{
    public partial class PersonalInformation : Form
    {
        public PersonalInformation()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].isStident)
            {
                label4.Text = "name: " + Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].FirstName + " " + Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].LastName;
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].isStident)
            {
                label4.Text = "Email: " + Sign_up_student.userStudemt[Sign_up_student.corentUserStudent].Email;
            }
        }
    }
}
