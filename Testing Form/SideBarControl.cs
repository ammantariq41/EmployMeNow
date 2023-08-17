using System;
using System.Windows.Forms;

namespace Testing_form
{
    public partial class UcMyUserControl : UserControl
    {
        public UcMyUserControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AddApplication mainPage = new AddApplication();
            mainPage.TopLevel = false;
            mainPage.BringToFront();
            mainPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
