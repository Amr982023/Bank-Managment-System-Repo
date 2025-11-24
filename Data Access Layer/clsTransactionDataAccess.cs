using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.DTOS;

namespace Data_Access_Layer
{
    public class clsTransactionDataAccess
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static bool Deposit(TransactionDTO DTO)
        {         

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand Command = new SqlCommand("sp_DepositToAccount", Connection))
            {
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("@AccountNumber", DTO.AccountNumber);
                Command.Parameters.AddWithValue("@Amount", DTO.Amount);
                Command.Parameters.AddWithValue("@CreatedBy", DTO.CreatedByUserID);
                Command.Parameters.AddWithValue("@Description", DTO.Description);

                try
                {
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                    return false;
                }
            }
        }

        public static bool Withdraw(TransactionDTO DTO)
        {
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand Command = new SqlCommand("sp_WithdrawFromAccount", Connection))
            {
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("@AccountNumber", DTO.AccountNumber);
                Command.Parameters.AddWithValue("@Amount", DTO.Amount);
                Command.Parameters.AddWithValue("@CreatedBy", DTO.CreatedByUserID);
                Command.Parameters.AddWithValue("@Description", DTO.Description);

                try
                {
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Optionally handle specific error numbers like:
                    // 50001 = Account not found
                    // 50002 = Insufficient balance
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                    return false;
                }
            }
        }

        public async static Task<(DataTable,int)> GetTransfersPaged(short pageNumber, short pageSize)
        {
            DataTable dt = new DataTable();
            int TotalRows = 0;

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_GetTransfers_Paged", Connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add input parameters
                command.Parameters.AddWithValue("@PageNumber", pageNumber);
                command.Parameters.AddWithValue("@PageSize", pageSize);

                // Add output parameter
                SqlParameter totalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(totalRowsParam);

                try
                {
                    await Connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
                    }

                    // Get total rows
                    TotalRows = (int)totalRowsParam.Value;
                }
                catch (SqlException ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                }
            }

            return (dt,TotalRows);
        }

        public static bool TransferBetweenAccounts(TransferDTO DTO)
        {

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_TransferBetweenAccounts", Connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@SourceAccountNumber", DTO.SourceAccountNumber);
                command.Parameters.AddWithValue("@DestinationAccountNumber", DTO.DestinationAccountNumber);
                command.Parameters.AddWithValue("@Amount", DTO.Amount);
                command.Parameters.AddWithValue("@CreatedBy", DTO.CreatedByUserId);
                command.Parameters.AddWithValue("@DestinationBankID", DTO.DestinationBankID);
                command.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(DTO.Description) ? DBNull.Value : (object)DTO.Description);

                try
                {
                    Connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                    return false;
                }
            }
        }

        public static int TotalTransactionsPerDay(DateTime Date)
        {
            int Total = 0;     
            try
            {

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetTotalTransactionsPerDay", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Date", Date.Date);

                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int parsed))
                        Total = parsed;
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }
            return Total;
        }

        public static DataTable GetAllBanks()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_GetAllBanks", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                using (SqlDataReader Reader = cmd.ExecuteReader())
                {
                    dt.Load(Reader);
                }
            }
            return dt;
        }

    }
}
