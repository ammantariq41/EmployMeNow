using Jobkar.DAL;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Welcome_Page
{
    public partial class SignUp : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public SignUp()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            {

                if (!DAL.check_email(email.Text))

                {
                    errorProvider2.SetError(this.email, "Email Alredy exists");
                    

                }
                else
                {
                    if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(university.Text) || string.IsNullOrEmpty(years.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text))
                    {
                        MessageBox.Show("Please fill all the boxes");
                    }
                    else if (textBox7.Text != textBox6.Text || textBox6.Text != textBox7.Text)
                    {
                        errorProvider1.SetError(this.textBox7, "Password Not matched");

                    }
                    else
                    {

                        if (DAL.insert_data_in_DB(email.Text, textBox6.Text, name.Text, university.Text, major.Text, years.Text, SavePhoto()))
                        {
                            MessageBox.Show("REGISTERED SUCCESSFULLY");
                            this.Close();
                            login login = new login();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("REGISTERATION FAILED");
                            string check = string.Empty;
                            int a  = 0;
                       

                        }

                    }
                }
        
                }
            }
        
        public byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox2.Image.RawFormat);
            return ms.ToArray();
        }

        public void years_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }

        private void pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif) | *.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openFileDialog.FileName);
            }
        }

       
    }
}
