using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Testing_form
{
    public partial class UCdeletecover : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private string cover;
        public UCdeletecover(string name)
        {
            cover = name;
            InitializeComponent();
        }
        public string UserInput { get; set; }
        private void okbtn_Click(object sender, EventArgs e)
        {
       
            
            deletecover(cover);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void deletecover(string covername)
        {
            
            string name = covername;
            SqlConnection con = new SqlConnection(cs);
            string q = $"delete from cover_letter where name = '{name}' and user_id = {context.userid}";
            SqlCommand cmd = new SqlCommand(q, con);


            con.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {

                MessageBox.Show("Cover Letter Deleted!");
                this.Close();
                

            }
            else
            {
                MessageBox.Show("Cover Letter Does not Exist!");

            }
            con.Close();
        }

    }
}
