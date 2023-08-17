using System;
using System.Windows.Forms;


namespace Welcome_Page
{
    public partial class Welcome : Form
    {
     
        public Welcome()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.ShowDialog();
        }

    }       
}
