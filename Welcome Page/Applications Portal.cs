using System;
using System.Windows.Forms;
using Welcome_Page;

namespace Testing_form
{

    public partial class Applications_Portal : Form
    {
        private AddApplication mainPage;
        public Applications_Portal()
        {
            InitializeComponent();
            mainPage = new AddApplication();
        }

        private void New_Click(object sender, EventArgs e)
        {
            mainPage.FormBorderStyle = FormBorderStyle.None;
            mainPage.AutoScroll = true;
            mainPage.TopLevel = false;
            contentpanel.Controls.Add(mainPage);
            mainPage.BringToFront();
            mainPage.Show();

        }
        

     
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Applications applicationsForm = new Applications();
            applicationsForm.voidDelegate += OpenNewApplicationForm;
            applicationsForm.FormBorderStyle = FormBorderStyle.None;  
            applicationsForm.AutoScroll = true;
            applicationsForm.TopLevel = false;
            contentpanel.Controls.Add(applicationsForm);
            applicationsForm.BringToFront();
            applicationsForm.Show();
        }

        public void OpenNewApplicationForm()
        {
            New_Click(null, null);
        }

        private void emailbtn_Click(object sender, EventArgs e)
        {
            emailForm email = new emailForm();
            email.FormBorderStyle = FormBorderStyle.None;
            email.AutoScroll = false;
            email.TopLevel = false;
            contentpanel.Controls.Add(email);
            email.BringToFront();
            email.Show();
        }

        private void coverbtn_Click(object sender, EventArgs e)
        {
            cover_letter cover_Letter = new cover_letter();
            cover_Letter.FormBorderStyle = FormBorderStyle.None;
            cover_Letter.AutoScroll = false;
            cover_Letter.TopLevel = false;
            contentpanel.Controls.Add(cover_Letter);
            cover_Letter.BringToFront();
            cover_Letter.Show();
        }
    }
}
