using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Jobkar.DAL;

namespace Testing_form
{
    public partial class emailForm : Form
    {
        public emailForm()
        {
            InitializeComponent();
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.Filter = "File (*.png;*.jpg;*.bmp;*.gif) | *.png;*.jpg;*.bmp;*.gif |All files (*.*)|*.*";
            openFileDialog.ShowDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName.ToString();
                attach.Text = path;
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {

            // MailMessage message = new MailMessage(from.Text, to.Text, subject.Text, body.Text);         
            // SmtpClient smtpClient = new SmtpClient(stmp.SelectedItem.ToString());
            // smtpClient.Port = 25;
            string smtp = "smtp.gmail.com";
            string cv_attach = attach.ToString();
            // smtpClient.Credentials = new NetworkCredential(email.Text, password.Text);
            // smtpClient.EnableSsl = true;
            // smtpClient.Send(message);


            if (DAL.send_email(from.Text, to.Text, subject.Text, smtp, body.Text, email.Text, password.Text, cv_attach))
            {
                MessageBox.Show("Email Sent Successfully");
                body.Clear();
                to.Clear();
                from.Clear();
                subject.Clear();
                email.Clear();
                password.Clear();
                attach.Clear();

            }

            else

            {
                MessageBox.Show("Email Failed");
            }
        }
    }
}
