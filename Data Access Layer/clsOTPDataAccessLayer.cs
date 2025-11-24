using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Linq.Expressions;
using Common;
using System.Diagnostics;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Data_Access_Layer
{
    public class clsOTPDataAccessLayer
    {
       static string connectionstring = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static async Task<bool> GenerateUserOtpAsync(int userId, string otp, int expiryMinutes = 5)
        {
            int OTPID = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                using (SqlCommand cmd = new SqlCommand("sp_GenerateUserOTP", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@OTP", otp);
                    cmd.Parameters.AddWithValue("@ExpiryMinutes", expiryMinutes);

                     conn.Open();

                    var Result = await cmd.ExecuteScalarAsync();
                    
                        if (Result != null && Result != DBNull.Value)
                        {
                           OTPID = Convert.ToInt32(Result);
                        }
                    
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return false; // fallback (shouldn’t happen if SP works correctly)
            }

                return  OTPID != -1;
        }

        /// <summary>
        /// Validate OTP for a user. Returns true if valid, false otherwise.
        /// </summary>
        public static async Task<bool> ValidateUserOtpAsync(int userId, string otp)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                using (SqlCommand cmd = new SqlCommand("sp_ValidateUserOTP", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@OTP", otp);

                    await conn.OpenAsync();

                    object result = await cmd.ExecuteScalarAsync();
                    return (result != null && Convert.ToInt32(result) == 1);
                }
            }catch(Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return false; // fallback (shouldn’t happen if SP works correctly)
            }
        }

    }
}
