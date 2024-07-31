using System.Windows.Forms;
using University.Datamodels;

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

        /*        private void Messages_Load(object sender, EventArgs e)
                {
                    // הוספת הודעה עם תאריך ושעה נוכחיים
                    AddItemWithDate("הודעה לדוגמה");
                }*/

        /*     private void AddItemWithDate(string message)
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
             }*/

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void clicked_buttonFavorite_Item(object sender, EventArgs e) // ללחוץ פעמיים על כפתור מסויים
        {
           /* if (listViewMessgest.SelectedItems.Count > 0)
            {*/
            ListViewItem selectedItem = listViewMessgest.SelectedItems[0];
            string messageText = selectedItem.SubItems[1].Text;
            Messages_setting M = Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges.FirstOrDefault(x => x.text.Equals(messageText));
            M.isFivorit = true;
            MessageBox.Show("Add to the Favorite");
            /*}*/
        }

        private void inputSendMassege_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleMessages_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, EventArgs e)
        {

        }

        private void Messages_Load(object sender, EventArgs e)
        {
            listViewMessgest.View = View.Details;
            listViewMessgest.Columns.Add("The sender", -2, HorizontalAlignment.Left);
            listViewMessgest.Columns.Add("Text", -2);
            listViewMessgest.Columns.Add("Date", -2);
            displayAllMessages();
        }

        /*private void buttonTheSender_Click(object sender, EventArgs e)
        {
            Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges.Sort();
            listViewMessgest.Items.Clear();

            for (int i = 0; i < Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges.Count; i++)
            {
                listViewMessgest.Items.Add(Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges[i]);
            }
        }*/
        private void displayAllMessages()
        {
            listViewMessgest.Items.Clear();

            foreach (Messages_setting messagest in Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges)
            {
                String theSender = messagest.SendedName;
                String theText = messagest.text;
                String date = messagest.Date.ToString("yyyy-MM-dd HH:mm:ss");

                String[] row = {theSender, theText, date };
                ListViewItem item = new ListViewItem(row);
                listViewMessgest.Items.Add(item);
            }

            foreach (ColumnHeader column in this.listViewMessgest.Columns)
            {
                column.Width = -2;
            }
        }

        private void buttonTheSender_Click(object sender, EventArgs e)
        {
            Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges.Sort((x, y) => string.Compare(x.text, y.text));

            // ניקוי ה-ListView
            listViewMessgest.Items.Clear();

            // הוספת ההודעות הממויינות ל-ListView
            foreach (Messages_setting messagest in Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges)
            {
                String theSender = messagest.SendedName;
                String theText = messagest.text;
                String date = messagest.Date.ToString("yyyy-MM-dd HH:mm:ss");

                String[] row = { theSender, theText, date };
                ListViewItem item = new ListViewItem(row);
                listViewMessgest.Items.Add(item);
            }
        }
        private void buttonFavorite_Click(object sender, EventArgs e)
        {
            listViewMessgest.Items.Clear();

         

            foreach (Messages_setting messagest in Sign_up_lecturer.users[Sign_up_lecturer.corentUser].mesges)
            {
                if (messagest.isFivorit == true)
                {
                    String theSender = messagest.SendedName;
                    String theText = messagest.text;
                    String date = messagest.Date.ToString("yyyy-MM-dd HH:mm:ss");
                    String[] row = { theSender, theText, date };
                    ListViewItem item = new ListViewItem(row);
                    listViewMessgest.Items.Add(item);
                }
                   
            }
        }

       /* private void listViewMessgest_DoubleClick(object sender, EventArgs e)
        {

        }*/
    }
}