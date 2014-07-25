using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace PainMonitorTeamB
{
    /*
     * 
     * Select an organization.
 
Write the business requirements for a computer program.
 
Analyze the best choice of language to meet those requirements. The final deliverable is a paper comparing and contrasting C# with another language.
 
The team will first select an organization. This may be an organization known by one of the members or a fictitious organization such as a small business, public library, school, and so forth. The Virtual Organizations on the student website are possible candidates.
 
The team will write the requirements for a program needed by the organization. The program must be object-oriented and include database connectivity.
 
The team will analyze the requirements and determine how each language, C# and Visual Basic® (VB), fits the requirements and describe any roadblocks.
 
The team will discuss and choose the language for the project. The team will write a paper, including the pros and cons of each choice, and make an argument using references for the decision.
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * Select the organization for which you will design a programming solution.
 
Write the business requirements for the solution.
 
Submit the requirements document to the instructor for approval and feedback.
     * 
     * 
     * 
     * Team B Joshua Voss, Brendon Morgan, Danny Roberts, Dustin Pauly,
     * 
     * we have selected to make a medical application for patients that will track thier chronic pain for
     * people with RA MS and other pain causing illnesses that may be hard to track.
     * this will give patients the ability to email their doctors a list of times and pains triggers as well as to keep track for them selves
     * 
     * it could be writen in VB or C# C# was chosen for the ability to run as a very fine object oriented program 
     * 
     * 
     * the program should be able to email a doctor a text file of all the data in the datagrid view as well as store localy as a database it should make the text file on demand when about to be emailed and destory it imidiatly after execution for security reasons 
     * it will hold the data in a local data base for better security than a text file.
     * 
     * the program should also be able to get the current date for new data and add it to the DB and basesd on date selection pull older data for the user to view 
     * */


    public partial class Form1 : Form
    {
        string items;

        public SmtpClient client = new SmtpClient();
        public MailMessage msg = new MailMessage();
        public System.Net.NetworkCredential smptauth = new System.Net.NetworkCredential("username","pass");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasepainDataSet1.monitor' table. You can move, or remove it, as needed.
            this.monitorTableAdapter1.Fill(this.databasepainDataSet1.monitor);
           
      

        }

        private void sndmail()
        {
            try
            {
                client.Host = "smtp.cox.net";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.Credentials = smptauth;
                client.EnableSsl = true;

                MailAddress To = new MailAddress("joshuavoss@gmail.com");
                MailAddress From = new MailAddress("jvoss12@cox.net");
                msg.Subject = "test email";
                msg.Body = "fuck yeah";
                msg.From = From;
                msg.To.Add(To);

                client.Send(msg);
                MessageBox.Show("email sent");
            }
            catch
            {
                MessageBox.Show("something went wrong");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            items = "";  // resets itwem variable so it wont retain last values 
            foreach (string s in checkedListBoxMedicine.CheckedItems)
            {
                items = items + " " + s; 
            }
            items = items + " " + textBoxMedication.Text;
            string date = dateTimePicker1.Text.ToString();
           this.databasepainDataSet1.monitor.Rows.Add(date,items, comboBoxPain.Text, textBoxLocation.Text, textBoxSymphtoms.Text);//adds infor to the database 
           this.monitorTableAdapter1.Update(this.databasepainDataSet1.monitor);//saves info 
           this.monitorTableAdapter1.Fill(this.databasepainDataSet1.monitor);//reloads into table 
           
        }

        private void checkedListBoxMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {


           
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            sndmail();
        }

    }
}
