using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Xml.Linq;

namespace Jobkar.DAL
{
    public static class DAL
    {
        public static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public static string GetCompanyEmail(string companyName)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = $"select email from company where cname = @CompanyName";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CompanyName", companyName);

            conn.Open();

            string cemail = cmd.ExecuteScalar() as string;

            if (!string.IsNullOrEmpty(cemail))
            {
                return cemail;
            }
            else
            {
                return "Position Does not Exists";

            }
        }

        public static bool InsertApplication(string companyName, string position, int userId)
        {

            SqlConnection conn = new SqlConnection(cs);

            string query1 = "insert into applications_TABLE values(@CompanyName, @Position, @userid)";
            SqlCommand cmd1 = new SqlCommand(query1, conn);

            cmd1.Parameters.AddWithValue("@CompanyName", companyName);
            cmd1.Parameters.AddWithValue("@Position", position);
            cmd1.Parameters.AddWithValue("@userid", userId);

            conn.Open();

            int dr1 = cmd1.ExecuteNonQuery();

            return dr1 > 0;
        }

        public static List<string> GetCompanyNames()
        {

            using (SqlConnection conn = new SqlConnection(cs))
            {
                List<string> companyNames = new List<string>();
                string query = "SELECT cname FROM company"; // Modify this query accordingly

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string companyName = reader["cname"].ToString();
                    companyNames.Add(companyName);
                }

                reader.Close();
                conn.Close();
                return companyNames;
            }
        }

        public static bool check_email(string email)
        {

            SqlConnection conn = new SqlConnection(cs);

            string query = $"select count(*) from USERS_TABLE where EMAIL = '{email}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                conn.Close();
                return false;
            }
            else
            {
                conn.Close();
                return true;

            }
        }

        public static bool insert_data_in_DB(string email, string password, string name, string university, string major, string years, byte[] picture)
        {
            SqlConnection conn = new SqlConnection(cs);
            var imageData = picture;
            string query3 = "insert into USERS_TABLE values(@EMAIL, @PASSWORD, @namee, @university, @major, @YEARS, @PICTURE)";
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            conn.Open();

            //main database
            cmd3.Parameters.AddWithValue("@EMAIL", email); ;
            cmd3.Parameters.AddWithValue("@PASSWORD", password);
            cmd3.Parameters.AddWithValue("@namee", name); ;
            cmd3.Parameters.AddWithValue("@university", university);
            cmd3.Parameters.AddWithValue("@major", major);
            cmd3.Parameters.AddWithValue("@YEARS", years);
            cmd3.Parameters.AddWithValue("@PICTURE", imageData);

            int dr3 = cmd3.ExecuteNonQuery();
            if (dr3 > 0)
            {
                conn.Close();
                return true;

            }
            else
            {
                conn.Close();
                return false;

            }
        }

        public static bool ValidateUser(string email, string password)
        {
            SqlConnection conn = new SqlConnection(cs);

            string query = "select * from USERS_TABLE where EMAIL = @email and PASSWORD = @password";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    int column1Value = (int)dr.GetValue(dr.GetOrdinal("ID"));
                    string column2Value = dr.GetString(dr.GetOrdinal("EMAIL"));
                    string column3Value = dr.GetString(dr.GetOrdinal("PASSWORD"));
                    CurrentUser.userid = column1Value;
                    CurrentUser.email = column2Value;
                    CurrentUser.password = column3Value;
                }
                conn.Close();
                return true;

            }
            else
            {
                conn.Close();
                return false;
            }

        }

        public static bool deletecover(string covername)
        {

            string name = covername;
            SqlConnection con = new SqlConnection(cs);
            string q = $"delete from cover_letter where name = '{name}' and user_id = {CurrentUser.userid}";
            SqlCommand cmd = new SqlCommand(q, con);


            con.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                con.Close();
                return true;

            }
            else
            {
                con.Close();
                return false;

            }

        }

        public static bool deleteapp(string appname)
        {

            string userInput = appname;

            SqlConnection con = new SqlConnection(cs);
            string q = $"delete from applications_TABLE where CompanyName = '{userInput}' and user_id = {CurrentUser.userid}";
            SqlCommand cmd = new SqlCommand(q, con);


            con.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                con.Close();
                return true;

            }
            else
            {
                con.Close();
                return false;

            }

        }

        public static string viewletter(string Letter_Name)
        {

            SqlConnection conn = new SqlConnection(cs);

            string query1 = $"select letter from cover_letter where user_id = {CurrentUser.userid} and name = '{Letter_Name}'";
            SqlCommand cmd = new SqlCommand(query1, conn);

            conn.Open();

            string letter = Convert.ToString(cmd.ExecuteScalar());

            if (!string.IsNullOrEmpty(letter))
            {
                return letter;
            }
            else
            {
                return "Cover Letter Does not Exist!";

            }

        }

        public static bool send_email(string from, string to, string subject, string smtp, string email, string password, string body, string attach)
        {
            try
            {
                MailMessage message = new MailMessage(from, to, subject, body);
                if (File.Exists(attach))
                {
                    message.Attachments.Add(new Attachment(attach));
                }

                SmtpClient smtpClient = new SmtpClient(smtp);
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(email, password);
                smtpClient.EnableSsl = true;
                smtpClient.Send(message);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool insertcover_in_DB(string name, string letter)
        {
            SqlConnection conn = new SqlConnection(cs);

            string query1 = "insert into cover_letter values(@name, @letter, @userid)";
            SqlCommand cmd1 = new SqlCommand(query1, conn);

            cmd1.Parameters.AddWithValue("@name", name);
            cmd1.Parameters.AddWithValue("@letter", letter);
            cmd1.Parameters.AddWithValue("@userid", CurrentUser.userid);

            conn.Open();

            int dr1 = cmd1.ExecuteNonQuery();

            if (dr1 > 0)
            {

                conn.Close();
                return true;

            }
            else
            {
                conn.Close();
                return false;
            }
                
        }
    }

}


