using System;
using System.Windows.Forms;
using Testing_form;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;
using Jobkar.DAL;

namespace Welcome_Page
{
    public partial class login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public login()
        {
            InitializeComponent();
        }



        private void textBox1_Leave(object sender, EventArgs e)
        {

            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if (reg.IsMatch(textBoxEmail.Text) == false)
            {

                errorProvider1.SetError(this.textBoxEmail, "Invalid Format");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();

        }

        private void siginbtn_Click(object sender, EventArgs e)
        {

            if (DAL.ValidateUser(textBoxEmail.Text, textBoxPassword.Text))
            {
                Applications_Portal app = new Applications_Portal();
                app.Show();
                this.Close();

            }
                 
            else
            {
                MessageBox.Show("INVALID CREDENTIALS");
            }

   
        }
    }
}
