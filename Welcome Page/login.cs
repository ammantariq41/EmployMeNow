using System;
using System.Windows.Forms;
using Testing_form;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;

namespace Welcome_Page
{
    public partial class login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);

            string query = "select * from USERS_TABLE where EMAIL = @email and PASSWORD = @password";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@email", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    int column1Value = (int)dr.GetValue(dr.GetOrdinal("ID"));
                    string column2Value = dr.GetString(dr.GetOrdinal("EMAIL"));
                    string column3Value = dr.GetString(dr.GetOrdinal("PASSWORD"));
                    context.userid = column1Value;
                    context.email = column2Value;
                    context.password = column3Value;
                }

                Applications_Portal app = new Applications_Portal();
                app.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("INVALID CREDENTIALS");
            }

            conn.Close();

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            Regex reg = new Regex (@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            
            if(reg.IsMatch(textBox1.Text) == false)
            {
                
                errorProvider1.SetError(this.textBox1, "Invalid Format");

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
    }
}
