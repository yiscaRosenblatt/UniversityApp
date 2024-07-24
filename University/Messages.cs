using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Messages_Load(object sender, EventArgs e)
        {
            // הוספת הודעה עם תאריך ושעה נוכחיים
            AddItemWithDate("הודעה לדוגמה");
        }

        private void AddItemWithDate(string message)
        {
            string dateTimeMessage = $"{message} - {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
            theMessages.Items.Add(dateTimeMessage);
        }
        private void theMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (theMessages.SelectedItem != null)
            {
                string selectedItem = theMessages.SelectedItem.ToString();
                string datePart = selectedItem.Substring(selectedItem.LastIndexOf('-') + 2);
                if (DateTime.TryParseExact(datePart, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
                {
                    monthCalendar.SetDate(dateTime);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
