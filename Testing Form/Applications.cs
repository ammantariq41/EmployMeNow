using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Jobkar.DAL;

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
            string q = $"select CompanyName, Position from applications_TABLE where user_id = {CurrentUser.userid}";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(q, con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            data_view.DataSource = dataTable;
        }


        private void delete_Click(object sender, EventArgs e)
        {

            UcDeleteApplication inputDialog = new UcDeleteApplication();
            inputDialog.ShowDialog();


        }


    }
}
