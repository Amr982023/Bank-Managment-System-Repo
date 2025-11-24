using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Diagnostics;

namespace Data_Access_Layer
{
    public class clsCashReserveDataAccess
    {
        public static bool RecordCashReserve(int userId)
        {
           string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_RecordCashReserve", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Input parameter
                cmd.Parameters.AddWithValue("@UserID", userId);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                   
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);                   
                    throw new ApplicationException("Error recording cash reserve", ex);
                  
                }
            }
        }

        public static async Task<(DataTable Data, int TotalRows)> GetCashReservesListAsync(short pageSize, short pageNumber)
        {
            DataTable dt = new DataTable();
            int totalRows = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetCashReservesListWithPaging", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    cmd.Parameters.AddWithValue("@PageSize", pageSize);
                    cmd.Parameters.AddWithValue("@PageNumber", pageNumber);

                    SqlParameter totalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(totalRowsParam);

                    await conn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }

                    totalRows = (int)cmd.Parameters["@TotalRows"].Value;
                }
            }
            catch (Exception ex)
            {

                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }

            return (dt, totalRows);
        }
            
       

    }
}
