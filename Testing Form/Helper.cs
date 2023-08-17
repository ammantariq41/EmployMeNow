using System;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Testing_form
{
    public static class Helper
    {
        public static void send_email(string from, string to, string subject, string smtp, string email, string password, string body, string attach)
        {
            try
            {
                MailMessage message = new MailMessage(from, to, subject, body);

               
                if (File.Exists(attach))
                {
                    message.Attachments.Add(new Attachment(attach));
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Attachment file not found.");
                    return;
                }

                SmtpClient smtpClient = new SmtpClient(smtp);
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(email, password);
                smtpClient.EnableSsl = true;
                smtpClient.Send(message);

               
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public static string ReadTextFile(string filePath)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);
                return fileContent;
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
        }
    }
}
