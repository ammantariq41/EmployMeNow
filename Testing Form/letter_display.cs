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

            string letter = view_letter();
            textBox1.Text = letter;
            

        }
 

        public string view_letter()
        {
           
            SqlConnection conn = new SqlConnection(cs);

            string query1 = $"select letter from cover_letter where user_id = {context.userid} and name = '{Letter_Name}'";
            SqlCommand cmd = new SqlCommand(query1, conn);

            conn.Open();

            string letter = Convert.ToString(cmd.ExecuteScalar());

            if (!string.IsNullOrEmpty(letter))
            {
                return letter;
            }
            else
            {
                return "Cover Letter Does not Exist!";

            }
           
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
