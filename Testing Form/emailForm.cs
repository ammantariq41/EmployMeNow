using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

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
            try
            {
                MailMessage message = new MailMessage(from.Text, to.Text, subject.Text, body.Text);
                message.Attachments.Add(new Attachment(attach.Text.ToString()));
                SmtpClient smtpClient = new SmtpClient(stmp.SelectedItem.ToString());
                smtpClient.Port = 25;
                smtpClient.Credentials = new NetworkCredential(email.Text, password.Text);
                smtpClient.EnableSsl = true;
                smtpClient.Send(message);
                MessageBox.Show("Email Sent Successfully");
               
                
                body.Clear();
                to.Clear();
                from.Clear();
                subject.Clear();
                email.Clear();
                password.Clear();
                attach.Clear();       

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
