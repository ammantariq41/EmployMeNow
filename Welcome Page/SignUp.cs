using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
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

        private void button1_Click(object sender, EventArgs e)
        {

            string entered_email = email.Text;
            SqlConnection conn = new SqlConnection(cs);

            string query = $"select count(*) from USERS_TABLE where EMAIL = '{entered_email}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();


            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                errorProvider2.SetError(this.email, "Email Already Exists");
            }
            else if (count == 0)
            {
                errorProvider2.Clear();
                if (textBox7.Text != textBox6.Text || textBox6.Text != textBox7.Text)
                {
                    errorProvider1.SetError(this.textBox7, "Password Not matched");
                }
                else if (string.IsNullOrEmpty(name.Text))
                {
                    MessageBox.Show("Write name");
                }

                else
                {
                    //SqlConnection conn = new SqlConnection(cs);
                    var imageData = SavePhoto();
                    string query3 = "insert into USERS_TABLE values(@EMAIL, @PASSWORD, @namee, @university, @major, @YEARS, @PICTURE)";
                    SqlCommand cmd3 = new SqlCommand(query3, conn);


                    //main database
                    cmd3.Parameters.AddWithValue("@EMAIL", email.Text); ;
                    cmd3.Parameters.AddWithValue("@PASSWORD", textBox6.Text);
                    cmd3.Parameters.AddWithValue("@namee", name.Text); ;
                    cmd3.Parameters.AddWithValue("@university", university.Text);
                    cmd3.Parameters.AddWithValue("@major", major.Text); ;
                    cmd3.Parameters.AddWithValue("@YEARS", years.Text);
                    cmd3.Parameters.AddWithValue("@PICTURE", imageData);


                    

                    int dr3 = cmd3.ExecuteNonQuery();
                    if (dr3 > 0)
                    {
                        MessageBox.Show("REGISTERED SUCCESSFULLY");

                        this.Close();
                        login login = new login();
                        login.Show();

                    }
                    else
                    {
                        MessageBox.Show("REGISTERATION FAILED");
                    }                   

                }

            }
            conn.Close();

        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox2.Image.RawFormat);
            return ms.ToArray();
        }

        private void years_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(char.IsDigit(ch)) {
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
