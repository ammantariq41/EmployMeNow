using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Jobkar.DAL;


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

            if (DAL.deletecover(cover))
            {
                MessageBox.Show("Cover Letter Deleted!");
                DialogResult = DialogResult.OK;
                this.Close();

            }
            else
                MessageBox.Show("Cover Letter Does not Exist!");


        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        

    }
}
