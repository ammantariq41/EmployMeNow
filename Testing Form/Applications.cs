using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Testing_form
{
    public partial class Applications : Form
    {
        public event VoidKindofDelegate voidDelegate;

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Applications()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            voidDelegate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindView();     
        }

        void BindView()
        {
            SqlConnection con = new SqlConnection(cs);
            string q = $"select CompanyName, Position from applications_TABLE where user_id = {context.userid}";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(q,con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            data_view.DataSource = dataTable;
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
         
            using (UcDeleteApplication inputDialog = new UcDeleteApplication())
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    string userInput = inputDialog.UserInput;
                    
                    SqlConnection con = new SqlConnection(cs);
                    string q = $"delete from applications_TABLE where CompanyName = '{userInput}' and user_id = {context.userid}";
                    SqlCommand cmd = new SqlCommand(q, con);
                   
                    
                    con.Open();

                    int a = cmd.ExecuteNonQuery();

                    if (a>0) {

                        MessageBox.Show("Application Deleted!");
                    
                    }
                    else
                    {
                        MessageBox.Show("Application Does not Exist!");

                    }
                    con.Close();
                    
                }
            }


        }

       
    }
}
