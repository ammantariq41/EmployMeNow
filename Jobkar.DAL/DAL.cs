using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
                return false;
            }
            else
            {
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


    }
             
}

