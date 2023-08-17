using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        
    }
}
