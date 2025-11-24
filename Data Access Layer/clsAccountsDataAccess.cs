using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Common.DTOS;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Common;
using System.Diagnostics;

namespace Data_Access_Layer
{
    public class clsAccountsDataAccess
    {
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static int AddNewAccount(AccountDTO account)
        {
            int newID = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_AddNewAccount", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@OpenDate", account.OpenDate);
                    cmd.Parameters.AddWithValue("@CloseDate", (object)account.CloseDate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@StatusID", account.StatusID);
                    cmd.Parameters.AddWithValue("@CurrencyID", account.CurrencyID);
                    cmd.Parameters.AddWithValue("@Balance", account.Balance);
                    cmd.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
                    cmd.Parameters.AddWithValue("@AccountTypeID", account.AccountTypeID);
                    cmd.Parameters.AddWithValue("@ClientID", account.ClientID);

                    SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    newID = (int)outputIdParam.Value;
                }
            }catch(Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return -1;
            }

            return newID;
        }

        public static async Task<(DataTable,int)> SearchWithAccountNumber(string AccountNumber, int PageNumber, int PageSize)
        {
            DataTable dt = new DataTable();
            int TotalRows = 0;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_Search_Account_By_AccountNumber", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    cmd.Parameters.AddWithValue("@PageNumber", PageNumber);
                    cmd.Parameters.AddWithValue("@PageSize", PageSize);
                    cmd.Parameters.Add("@TotalRows", SqlDbType.Int).Direction = ParameterDirection.Output;

                   await Connection.OpenAsync();
                    using (SqlDataReader Reader = await cmd.ExecuteReaderAsync())
                    {
                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);

                        }
                    }


                    TotalRows = cmd.Parameters["@TotalRows"].Value == DBNull.Value ? 0 : Convert.ToInt32(cmd.Parameters["@TotalRows"].Value);
                }

            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }

            return (dt,TotalRows);
        }

        public static async Task<(DataTable, int)> SearchWithName(string Name, int PageNumber, int PageSize)
        {
            DataTable dt = new DataTable();
            int TotalRows = 0;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_Search_Account_By_Name", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@PageNumber", PageNumber);
                    cmd.Parameters.AddWithValue("@PageSize", PageSize);
                    cmd.Parameters.Add("@TotalRows", SqlDbType.Int).Direction = ParameterDirection.Output;

                   await Connection.OpenAsync();
                    using (SqlDataReader Reader = await cmd.ExecuteReaderAsync())
                    {
                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);

                        }
                    }


                    TotalRows = cmd.Parameters["@TotalRows"].Value == DBNull.Value ? 0 : Convert.ToInt32(cmd.Parameters["@TotalRows"].Value);
                }

            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }

            return (dt, TotalRows);
        }

        public static AccountDTO GetAccountByID(int AccountID)
        {
            AccountDTO Account = null;
            try
            {


                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetAccountByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", AccountID);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Account = new AccountDTO
                            {
                                ID = AccountID,
                                OpenDate = reader.GetDateTime(reader.GetOrdinal("OpenDate")),
                                CloseDate = reader.IsDBNull(reader.GetOrdinal("CloseDate"))
                                            ? (DateTime?)null
                                            : reader.GetDateTime(reader.GetOrdinal("CloseDate")),
                                Balance = reader.GetDecimal(reader.GetOrdinal("Balance")),
                                AccountNumber = reader.GetString(reader.GetOrdinal("AccountNumber")),
                                StatusID = reader.GetInt32(reader.GetOrdinal("StatusID")),
                                CurrencyID = reader.GetInt32(reader.GetOrdinal("CurrencyID")),
                                AccountTypeID = reader.GetInt32(reader.GetOrdinal("AccountTypeID")),
                                ClientID = reader.GetInt32(reader.GetOrdinal("ClientID")),
                                LastFeeProcessedDate = reader.IsDBNull(reader.GetOrdinal("LastFeeProcessedDate"))
                                            ? (DateTime?)null
                                            : reader.GetDateTime(reader.GetOrdinal("LastFeeProcessedDate")),
                                            LastTransactionDate = reader.IsDBNull(reader.GetOrdinal("@LastTransactionDate"))
                                            ? (DateTime?)null
                                            : reader.GetDateTime(reader.GetOrdinal("@LastTransactionDate"))

                            };
                        }
                    }
                }
            }catch (Exception ex) 
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return null;
            }

            return Account;
        }

        public static AccountDTO GetAccountByAccountNumber(string AccountNumber)
        {
            AccountDTO Account = null;
            try
            {


                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetAccountByAccountNumber", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Account = new AccountDTO
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                OpenDate = reader.GetDateTime(reader.GetOrdinal("OpenDate")),
                                CloseDate = reader.IsDBNull(reader.GetOrdinal("CloseDate"))
                                            ? (DateTime?)null
                                            : reader.GetDateTime(reader.GetOrdinal("CloseDate")),
                                Balance = reader.GetDecimal(reader.GetOrdinal("Balance")),
                                AccountNumber = AccountNumber,
                                StatusID = reader.GetInt32(reader.GetOrdinal("StatusID")),
                                CurrencyID = reader.GetInt32(reader.GetOrdinal("CurrencyID")),
                                AccountTypeID = reader.GetInt32(reader.GetOrdinal("AccountTypeID")),
                                ClientID = reader.GetInt32(reader.GetOrdinal("ClientID")),
                                LastFeeProcessedDate = reader.IsDBNull(reader.GetOrdinal("LastFeeProcessedDate"))
                                            ? (DateTime?)null
                                            : reader.GetDateTime(reader.GetOrdinal("LastFeeProcessedDate")),
                                LastTransactionDate = reader.IsDBNull(reader.GetOrdinal("LastTransactionDate"))
                                            ? (DateTime?)null
                                            : reader.GetDateTime(reader.GetOrdinal("LastTransactionDate"))
                            };
                        }
                    }
                }
            }catch (Exception ex) 
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return null;
            }

            return Account;
        }

        public static AccountDTO GetAccountByClientID(int ClientID)
        {
            AccountDTO Account = null;
            try
            {


                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetAccountByClientID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClientID", ClientID);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Account = new AccountDTO
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                OpenDate = reader.GetDateTime(reader.GetOrdinal("OpenDate")),
                                CloseDate = reader.IsDBNull(reader.GetOrdinal("CloseDate"))
                                            ? (DateTime?)null
                                            : reader.GetDateTime(reader.GetOrdinal("CloseDate")),
                                Balance = reader.GetDecimal(reader.GetOrdinal("Balance")),
                                AccountNumber = reader.GetString(reader.GetOrdinal("AccountNumber")),
                                StatusID = reader.GetInt32(reader.GetOrdinal("StatusID")),
                                CurrencyID = reader.GetInt32(reader.GetOrdinal("CurrencyID")),
                                AccountTypeID = reader.GetInt32(reader.GetOrdinal("AccountTypeID")),
                                ClientID = ClientID,
                                LastFeeProcessedDate = reader.IsDBNull(reader.GetOrdinal("LastFeeProcessedDate"))
                                            ? (DateTime?)null
                                            : reader.GetDateTime(reader.GetOrdinal("LastFeeProcessedDate")),
                                LastTransactionDate = reader.IsDBNull(reader.GetOrdinal("@LastTransactionDate"))
                                            ? (DateTime?)null
                                            : reader.GetDateTime(reader.GetOrdinal("@LastTransactionDate"))
                            };
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

            return Account;
        }

        public static decimal GetTotalBalance()
        {
            decimal totalBalance = 0;
            try
            {


                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetTotalBalance", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        totalBalance = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return 0;
            }

            return totalBalance;
        }

        public static bool UpdateAccount(AccountDTO account)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_UpdateAccount", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", account.ID);
                    cmd.Parameters.AddWithValue("@OpenDate", account.OpenDate);
                    cmd.Parameters.AddWithValue("@CloseDate", (object)account.CloseDate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@StatusID", account.StatusID);
                    cmd.Parameters.AddWithValue("@CurrencyID", account.CurrencyID);
                    cmd.Parameters.AddWithValue("@Balance", account.Balance);
                    cmd.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
                    cmd.Parameters.AddWithValue("@AccountTypeID", account.AccountTypeID);
                    cmd.Parameters.AddWithValue("@ClientID", account.ClientID);

                    // Output parameter
                    SqlParameter outputParam = new SqlParameter("@RowsAffected", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    rowsAffected = (int)(outputParam.Value ?? 0);
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return false;
            }
            return rowsAffected > 0;
        }

        public static async Task <(DataTable,int)> GetAccountsWithPagingAsync(short pageNumber, short pageSize)
        {
            DataTable dt = new DataTable();
           int totalRows = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetAllAccountsWithPaging", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
                    cmd.Parameters.AddWithValue("@PageSize", pageSize);

                    SqlParameter outputParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);
                    await conn.OpenAsync();
                    using (SqlDataReader Reader = await cmd.ExecuteReaderAsync())
                    {
                        dt.Load(Reader);
                    }                  

                    totalRows = (int)cmd.Parameters["@TotalRows"].Value;
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return (null, 0);
            }

            return (dt,totalRows);
        }

        public static int RecordAccountBlock(int accountId, short reasonId, string notes, int createdBy)
        {
            int newBlockId = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("sp_AddAccountBlock", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountID", accountId);
                    command.Parameters.AddWithValue("@ReasonID", reasonId);

                    if (!string.IsNullOrEmpty(notes))
                        command.Parameters.AddWithValue("@Notes", notes);
                    else
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);

                    command.Parameters.AddWithValue("@CreatedBy", createdBy);

                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        newBlockId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return - 1;
            }


            return newBlockId;
        }

        public static int GetAccountStatusID(int accountId)
        {
            int statusID = -1;
            

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_GetStatus", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccountID", accountId);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar(); 
                    if (result != null && result != DBNull.Value)
                    {
                        statusID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {                   
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                    return -1;
                }
            }

            return statusID;
        }

        public static (DataTable,int) GetBlockingList(int PageSize,int PageNumber)
        {
            DataTable dt = new DataTable();
            int totalCount = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetAccountBlocksPaged", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PageNumber", PageNumber);
                    cmd.Parameters.AddWithValue("@PageSize", PageSize);

                    SqlParameter totalCountParam = new SqlParameter("@TotalCount", SqlDbType.Int);
                    totalCountParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(totalCountParam);
                    connection.Open();
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            dt.Load(Reader);
                        }

                         totalCount = (int)cmd.Parameters["@TotalCount"].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return (null, 0);
            }
            return (dt, totalCount);
        }

        public static bool CheckForSameAccountType(int ClientID , int AccountTypeID)
        {
            bool exists = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_CheckForSameTypeAccount", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClientID", ClientID);
                    cmd.Parameters.AddWithValue("@Account_Type_ID", AccountTypeID);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    exists = (Convert.ToInt32(result) == 1);
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return false;
            }
            return exists;
        }

        public static bool IsAccountExist(string accountNumber)
        {
            bool Exist = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("IsAccountExist", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);

                    con.Open();
                    var result = cmd.ExecuteScalar(); // Return 1 or 0
                    Exist= Convert.ToInt32(result) == 1;
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return false;
            }
         return Exist;
        }

        public static bool ChangeAccountStatus(int accountId, short statusId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("sp_Change_Account_Status", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountID", accountId);
                    command.Parameters.AddWithValue("@StatusID", statusId);

                    
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(returnValue);

                    connection.Open();
                    command.ExecuteNonQuery();

                    int result = (int)returnValue.Value;
                    return result == 1; 
                }
            }      
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);  
                return false;
            }
        }

        public static void AddToAccountFreezeHistory(int accountId, short reasonId, int createdBy, string notes = null)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_AddAccountFreeze", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountID", accountId);
                cmd.Parameters.AddWithValue("@ReasonID", reasonId);
                cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                if (string.IsNullOrEmpty(notes))
                    cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@Notes", notes);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                
                }
                catch (Exception ex)
                {               
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                }
            }    
        }

        public static void AddToAccountActivateHistory(int accountId, int createdBy, string notes = null)
        {
          
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_AddToAccountActivate", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountID", accountId);
                cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                if (string.IsNullOrEmpty(notes))
                    cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@Notes", notes);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                 
                }
                catch (Exception ex)
                {                
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                }
            }

           
        }

        public static decimal GetMonthlyInterest(string accountNumber, decimal rate)
        {
            decimal interest = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                   

                    
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.fn_MonthlyInterest(@Acc, @Rate)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Acc", accountNumber);
                        cmd.Parameters.AddWithValue("@Rate", rate);
                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            interest = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return 0;
            }
            return interest;
        }

        public static bool DeleteAccount(int accountId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_DeleteAccount", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AccountID", accountId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return false;
            }
        }

    }
}
