using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Jobkar.DAL;

namespace Testing_form
{
    public partial class UcDeleteApplication : Form
    {
        public UcDeleteApplication()
        {
            InitializeComponent();
        }

        public string UserInput { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            UserInput = textBox1.Text;
            if (DAL.deleteapp(UserInput))
            {
                MessageBox.Show("Application Deleted!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Application Does not Exist!");

        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        
    }
}
