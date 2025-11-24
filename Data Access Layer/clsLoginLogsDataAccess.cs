using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Data_Access_Layer
{
    public class clsLoginLogsDataAccess
    {
        public static int SaveLoginLog(int UserID)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            int LoginID = 0;
            try
            {


                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_SaveLoginLog", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@UserID", UserID);
                    Command.Parameters.Add("@LoginID", SqlDbType.Int).Direction = ParameterDirection.Output;

                    Connection.Open();
                    Command.ExecuteNonQuery();
                    LoginID = (int)Command.Parameters["@LoginID"].Value;
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return 0;
            }
            return LoginID;
        }

        public static void Logout (int LoginID)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            using (SqlConnection Conn = new SqlConnection(ConnectionString))
            using (SqlCommand Command = new SqlCommand("sp_Logout", Conn))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@LoginID", LoginID);

                try
                {
                    Conn.Open();
                    Command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                }

            }
        }

        public async static Task<(DataTable, int)> GetLoginLogs(short PageNumber, short PageSize)
        {
            DataTable dt = new DataTable();
            int TotalRows = 0;
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_GetLoginLogsWithPaging", Connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PageNumber", PageNumber);
                command.Parameters.AddWithValue("@PageSize", PageSize);

                SqlParameter TotalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(TotalRowsParam);

                try
                {
                    await Connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }

                    TotalRows = (int)(command.Parameters["@TotalRows"].Value ?? 0);
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                }
            }

            return (dt, TotalRows);
        }

    }

}
