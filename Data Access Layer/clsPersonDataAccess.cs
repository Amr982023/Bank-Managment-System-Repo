using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Data_Access_Layer
{
    public class clsPersonDataAccess
    {

        private static string connectionString =
            ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        public static bool IsExist(string NationalID)
        {
            bool exists;

            using (SqlConnection Conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_CheckNationalIDExists", Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NationalID", NationalID);
                Conn.Open();
                exists = Convert.ToInt32(cmd.ExecuteScalar()) == 1;
            }

            return exists;
        }

    }
}
