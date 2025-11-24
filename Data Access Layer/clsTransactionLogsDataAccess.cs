using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Common;
using System.Diagnostics;
using Common.DTOS;

namespace Data_Access_Layer
{
    public static class clsTransactionLogsDataAccess
    {
        public static void SaveTransactionLog(int UserID, int TransactionTypeID, string Description, string AccountNumber, decimal Amount)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_SaveTransactionLog", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    cmd.Parameters.AddWithValue("@Amount", Amount);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }

        }

        public static DataTable GetLastTransactions(string accountNumber)
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                {
                    string query = "SELECT * FROM dbo.fn_GetLastTransactions(@AccountNumber)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return null;
            }

            return dt;
        }

        public async static Task<(DataTable, int)> GetTransactionLogs(short PageNumber, short PageSize)
        {
            DataTable dt = new DataTable();
            int TotalRows = 0;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_GetTransactionLogsWithPaging", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PageNumber", PageNumber);
                cmd.Parameters.AddWithValue("@PageSize", PageSize);

                SqlParameter totalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(totalRowsParam);

                try
                {
                   await conn.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }

                    TotalRows = (int)(cmd.Parameters["@TotalRows"].Value ?? 0);
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                }
            }

            return (dt, TotalRows);
        }

        public static async Task<(DataTable, int)> GetDepositTransactionsWithPagination(short pageNumber, short pageSize)
        {
            DataTable dt = new DataTable();
            int totalRows = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetDepositTransactionLogsWithPaging", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
                    cmd.Parameters.AddWithValue("@PageSize", pageSize);

                    SqlParameter totalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(totalRowsParam);

                    await conn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
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

        public static async Task<(DataTable, int)> GetWithdrawTransactionsWithPagination(short pageNumber, short pageSize)
        {
            DataTable dt = new DataTable();
            int totalRows = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetWithdrawTransactionLogsWithPaging", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
                    cmd.Parameters.AddWithValue("@PageSize", pageSize);

                    SqlParameter totalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(totalRowsParam);

                    await conn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
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
