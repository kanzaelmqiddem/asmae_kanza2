using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PET_CLINIC
{
    class methodes
    {
        public static SqlConnection connection(string data)
        {
          
            SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=" + data + ";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            return con;
        }
        public static void deconnection(string data)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=" + data + ";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Close();
        }
        public static SqlDataReader selection(string data,string query)
        {
            SqlConnection con = connection(data);
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }
        public static int miseajour(string data, string query)
        {
            SqlConnection con = connection(data);
            SqlCommand cmd = new SqlCommand(query);
            int res = cmd.ExecuteNonQuery();
            return res;
        }
    }
}
