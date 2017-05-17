using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AppHelper;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Net.Mail;



namespace happyBapp1
{
    public partial class FriendBirthdayForm : Form
    {        
        List<Friends> friendList = new List<Friends>();

        const string XML_FILE = "friends.xml";

        private XMLSerializer xml = null;

        private bool editFlag = false;

        private int rowIndex = -1;

        private void SaveData()
        {
            xml.SaveData(friendList);
        }
        public IEnumerable<Friends> LoadFriends()
        {
            string xml = File.ReadAllText("C:\\Users\\RP\\Documents\\Visual Studio 2015\\Projects\\happybappV3\\happyBapp1\\bin\\Debug\\xml\\friends.xml");

            var friends = xmlread1.GenericSerializer<Friends[]>.Deserialize(xml);

            return friends;
        }

        private static void SaveFriends(IEnumerable<Friends> friends)
        {
            string xml = xmlread1.GenericSerializer<Friends[]>.Serialize(friends.ToArray());

            File.WriteAllText("C:\\Users\\RP\\Documents\\Visual Studio 2015\\Projects\\happybappV3\\happyBapp1\\bin\\Debug\\xml\\friends.xml", xml);
        }
        private void LoadData()
        {
            xml = new XMLSerializer(XML_FILE);

            if (!File.Exists(xml.XMLPath))
                xml.SaveData(friendList);

            friendList.Clear();
            friendList = xml.LoadData<List<Friends>>();

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = friendList;

            IEnumerable<Friends> friends = LoadFriends();

            foreach (var friend in friends)
            {
                string firstName = friend.Fname;
                string lastName = friend.Lname;
                DateTime birthdate = friend.Birthdate;
                string email = friend.Email;
                DateTime today = DateTime.Today;
                var age = today.Year - birthdate.Year;

                //string TZ = friend.ti;
                //string 

                if (birthdate.Day == DateTime.Now.Day) 
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("devtest20000@gmail.com");//enter sender email here
                    mail.To.Add(email);
                    mail.Subject = "Happy Birthday!";
                    mail.Body = "I wanted to be the first person to wish you a Happy Birthday! Enjoy being " + age + " today! Happy Birthday, " + firstName + "! From, Robert!";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("devtest20000@gmail.com", "**************");//enter credentials for sender
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }

            }


        }

        public FriendBirthdayForm()
        {
            InitializeComponent();
        }
       
        private void FriendBirthdayForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
              
        public void Savebutton_Click(object sender, EventArgs e)
        {
            if (editFlag)
            {
                //editing action
                //move data back into grid!
                friendList[rowIndex].Fname = this.FnametxtBox.Text;
                friendList[rowIndex].Lname = this.LnametxtBox.Text;
                friendList[rowIndex].Birthdate = this.dateTimePicker1.Value;
                friendList[rowIndex].Email = this.EmailtextBox1.Text;
                friendList[rowIndex].State = this.TimeZoneBox1.Text;
            }
            else
            {
                //building into a list from all the input from the app fields
                var friend = new Friends(this.FnametxtBox.Text, this.LnametxtBox.Text, this.dateTimePicker1.Value, this.EmailtextBox1.Text, this.TimeZoneBox1.Text);

                friendList.Add(friend);
            }

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = friendList;

            this.FnametxtBox.Text = "";
            this.LnametxtBox.Text = "";
            this.dateTimePicker1.Text = "";
            this.EmailtextBox1.Text = "";
            this.TimeZoneBox1.Text = "";

            this.FnametxtBox.Focus();

            SaveData();

        }
        private void FriendBirthdayForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {           
            SaveData();
        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.dataGridView1.Rows[e.RowIndex];

            this.FnametxtBox.Text = row.Cells[0].Value.ToString();
            this.LnametxtBox.Text = row.Cells[1].Value.ToString();
            this.dateTimePicker1.Text = row.Cells[2].Value.ToString();
            this.EmailtextBox1.Text = row.Cells[3].Value.ToString();
            this.TimeZoneBox1.Text = row.Cells[4].Value.ToString();
            
            
            editFlag = true;
            rowIndex = e.RowIndex;
        }

        
        //public void  MailTo()
        //{
        //    MailMessage mail = new MailMessage();
        //    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

        //    mail.From = new MailAddress("devtest20000@gmail.com");
        //    mail.To.Add("devtest20000@gmail.com");
        //        mail.Subject = "Happy Birthday!";
        //        mail.Body = "Today is the best day, because it's your birthday! So happy Birthday, " + FnametxtBox.Text + "!";

        //        SmtpServer.Port = 587;
        //        SmtpServer.Credentials = new System.Net.NetworkCredential("devtest20000@gmail.com", "thisisasafepassword");
        //        SmtpServer.EnableSsl = true;

        //        SmtpServer.Send(mail);
        //}
        

    }
}
