using Jobkar.DAL;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Testing_form
{

    public partial class letter_display : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public string Letter_Name;
        public letter_display(string name)
        {
            InitializeComponent();
            Letter_Name = name;

            string letter = DAL.viewletter(Letter_Name);
            textBox1.Text = letter;
            

        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            UCdeletecover uCdeletecover = new UCdeletecover(Letter_Name);
            uCdeletecover.BringToFront();
            uCdeletecover.Show();
            this.Close();

        }

        
    
    }
}
