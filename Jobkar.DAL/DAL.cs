﻿using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

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
    }
}