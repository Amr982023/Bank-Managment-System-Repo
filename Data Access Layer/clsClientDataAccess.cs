using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using Microsoft.Win32.SafeHandles;
using Common;
using Common.DTOS;

namespace Data_Access_Layer
{
    public class clsClientDataAccess
    {
       static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static ClientDTO FindClient(int ID)
        {
            ClientDTO clientDTO =new ClientDTO();
            clientDTO.Address = new AddressDTO();
            clientDTO.ID = ID;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_FindClientWithID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 75).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PhotoPath", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@NationalID", SqlDbType.NVarChar, 14).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@AddressID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@RegisterationDate", SqlDbType.Date).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ClientTypeID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PersonID", SqlDbType.Int).Direction = ParameterDirection.Output;

                    SqlParameter ReturnValue = new SqlParameter("@RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    cmd.Parameters.Add(ReturnValue);
                    conn.Open();
                    cmd.ExecuteNonQuery();



                    if ((int)ReturnValue.Value == 1)
                    {
                        clientDTO.FirstName = cmd.Parameters["@FirstName"].Value == DBNull.Value ? "" : cmd.Parameters["@FirstName"].Value.ToString();
                        clientDTO.SecondName = cmd.Parameters["@SecondName"].Value == DBNull.Value ? "" : cmd.Parameters["@SecondName"].Value.ToString();
                        clientDTO.ThirdName = cmd.Parameters["@ThirdName"].Value == DBNull.Value ? "" : cmd.Parameters["@ThirdName"].Value.ToString();
                        clientDTO.LastName = cmd.Parameters["@LastName"].Value == DBNull.Value ? "" : cmd.Parameters["@LastName"].Value.ToString();
                        clientDTO.NationalID = cmd.Parameters["@NationalID"].Value == DBNull.Value ? "" : cmd.Parameters["@NationalID"].Value.ToString();
                        clientDTO.Email = cmd.Parameters["@Email"].Value == DBNull.Value ? "" : cmd.Parameters["@Email"].Value.ToString();
                        clientDTO.PhotoPath = cmd.Parameters["@PhotoPath"].Value == DBNull.Value ? "" : cmd.Parameters["@PhotoPath"].Value.ToString();
                        clientDTO.DateOfBirth = cmd.Parameters["@DateOfBirth"].Value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime( cmd.Parameters["@DateOfBirth"].Value);
                        clientDTO.Gender = cmd.Parameters["@Gender"].Value == DBNull.Value ? "Unknown" : cmd.Parameters["@Gender"].Value.ToString();
                        clientDTO.Address.ID = cmd.Parameters["@AddressID"].Value == DBNull.Value ? -1 : Convert.ToInt32( cmd.Parameters["@AddressID"].Value);                   
                        clientDTO.RegistrationDate = cmd.Parameters["@RegisterationDate"].Value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(cmd.Parameters["@RegisterationDate"].Value);
                        clientDTO.ClientTypeID = cmd.Parameters["@ClientTypeID"].Value == DBNull.Value ? -1 : (int)cmd.Parameters["@ClientTypeID"].Value;
                        clientDTO.PersonID = cmd.Parameters["@PersonID"].Value == DBNull.Value ? -1 : (int)cmd.Parameters["@PersonID"].Value;

                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return null;
            }

            return clientDTO;
        }

        public static (bool Success, string Message, int PersonId, int ClientId, int AccountId, int CardId)AddNewClient_FullTransaction(NewClientDTO dto)
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.sp_AddNewClient_FullTransaction", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // -------------------------------
                        // Input parameters
                        // -------------------------------
                        cmd.Parameters.AddWithValue("@FirstName", (object)dto.FirstName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@SecondName", (object)dto.SecondName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ThirdName", (object)dto.ThirdName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@LastName", (object)dto.LastName ?? DBNull.Value);

                        cmd.Parameters.AddWithValue("@DateOfBirth",
                            dto.DateOfBirth == DateTime.MinValue ? (object)DBNull.Value : dto.DateOfBirth);

                        cmd.Parameters.AddWithValue("@Email", (object)dto.Email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@PhotoPath",
                            string.IsNullOrWhiteSpace(dto.PhotoPath) ? (object)DBNull.Value : dto.PhotoPath);

                        cmd.Parameters.AddWithValue("@NationalID", (object)dto.NationalID ?? DBNull.Value);

                        // Gender normalized
                        var gender = string.IsNullOrWhiteSpace(dto.Gender)
                            ? (object)DBNull.Value
                            : dto.Gender.Trim().ToLower();

                        cmd.Parameters.AddWithValue("@Gender", gender);

                        // Address
                        cmd.Parameters.AddWithValue("@Street", (object)dto.Street ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@City", (object)dto.City ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@CountryID", dto.CountryID);

                        // Client
                        cmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@ClientTypeID", dto.ClientTypeID);

                        // Account
                        cmd.Parameters.AddWithValue("@OpenDate", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@CloseDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@StatusID", 1);
                        cmd.Parameters.AddWithValue("@CurrencyID", dto.CurrencyID);
                        cmd.Parameters.AddWithValue("@Balance", dto.Balance);
                        cmd.Parameters.AddWithValue("@AccountNumber", (object)dto.AccountNumber ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@AccountTypeID", dto.AccountTypeID);

                        // Card
                        cmd.Parameters.AddWithValue("@Expiration_Date", DateTime.Now.AddYears(3));
                        cmd.Parameters.AddWithValue("@CardPassword", (object)dto.CardPassword ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Card_Status_ID", 1);
                        cmd.Parameters.AddWithValue("@Card_Network_ID", dto.NetworkTypeID);
                        cmd.Parameters.AddWithValue("@CardNumber", (object)dto.CardNumber ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Card_Type_ID", dto.CardTypeID);

                        // -------------------------------
                        // Output parameters
                        // -------------------------------
                        var successParam = new SqlParameter("@Success", SqlDbType.Bit)
                        { Direction = ParameterDirection.Output };

                        var messageParam = new SqlParameter("@Message", SqlDbType.NVarChar, 400)
                        { Direction = ParameterDirection.Output };

                        var personParam = new SqlParameter("@NewPersonId", SqlDbType.Int)
                        { Direction = ParameterDirection.Output };

                        var clientParam = new SqlParameter("@NewClientId", SqlDbType.Int)
                        { Direction = ParameterDirection.Output };

                        var accParam = new SqlParameter("@NewAccountId", SqlDbType.Int)
                        { Direction = ParameterDirection.Output };

                        var cardParam = new SqlParameter("@NewCardId", SqlDbType.Int)
                        { Direction = ParameterDirection.Output };

                        cmd.Parameters.Add(successParam);
                        cmd.Parameters.Add(messageParam);
                        cmd.Parameters.Add(personParam);
                        cmd.Parameters.Add(clientParam);
                        cmd.Parameters.Add(accParam);
                        cmd.Parameters.Add(cardParam);

                        // -------------------------------
                        // Execute
                        // -------------------------------
                        conn.Open();   // <-- inside using (your request)

                        cmd.ExecuteNonQuery();

                        // -------------------------------
                        // Read Output values
                        // -------------------------------
                        bool success = successParam.Value != DBNull.Value && (bool)successParam.Value;
                        string message = messageParam.Value?.ToString() ?? "";
                        int personId = personParam.Value != DBNull.Value ? (int)personParam.Value : 0;
                        int clientId = clientParam.Value != DBNull.Value ? (int)clientParam.Value : 0;
                        int accountId = accParam.Value != DBNull.Value ? (int)accParam.Value : 0;
                        int cardId = cardParam.Value != DBNull.Value ? (int)cardParam.Value : 0;

                        return (success, message, personId, clientId, accountId, cardId);
                    }
                }
            }
            
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return (false, ex.Message, 0, 0, 0, 0);
            }
        }

        public static ClientDTO FindClientByNationalID(string NationalID)
        {
            ClientDTO clientDTO = new ClientDTO();
            clientDTO.Address = new AddressDTO();
            clientDTO.NationalID = NationalID;

            try
            {


                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_FindClientWithNationalID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NationalID", NationalID);
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 75).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PhotoPath", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@AddressID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Registerationdate", SqlDbType.Date).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ClientTypeID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PersonID", SqlDbType.Int).Direction = ParameterDirection.Output;

                    SqlParameter ReturnValue = new SqlParameter("@RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    cmd.Parameters.Add(ReturnValue);
                    conn.Open();
                    cmd.ExecuteNonQuery();



                    if ((int)ReturnValue.Value == 1)
                    {
                        clientDTO.FirstName = cmd.Parameters["@FirstName"].Value == DBNull.Value ? "" : cmd.Parameters["@FirstName"].Value.ToString();
                        clientDTO.SecondName = cmd.Parameters["@SecondName"].Value == DBNull.Value ? "" : cmd.Parameters["@SecondName"].Value.ToString();
                        clientDTO.ThirdName = cmd.Parameters["@ThirdName"].Value == DBNull.Value ? "" : cmd.Parameters["@ThirdName"].Value.ToString();
                        clientDTO.LastName = cmd.Parameters["@LastName"].Value == DBNull.Value ? "" : cmd.Parameters["@LastName"].Value.ToString();
                        clientDTO.ID = cmd.Parameters["@ID"].Value == DBNull.Value ? -1 : Convert.ToInt32(cmd.Parameters["@ID"].Value);
                        clientDTO.Email = cmd.Parameters["@Email"].Value == DBNull.Value ? "" : cmd.Parameters["@Email"].Value.ToString();
                        clientDTO.PhotoPath = cmd.Parameters["@PhotoPath"].Value == DBNull.Value ? "" : cmd.Parameters["@PhotoPath"].Value.ToString();
                        clientDTO.DateOfBirth = cmd.Parameters["@DateOfBirth"].Value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(cmd.Parameters["@DateOfBirth"].Value);
                        clientDTO.Gender = cmd.Parameters["@Gender"].Value == DBNull.Value ? "Unknown" : cmd.Parameters["@Gender"].Value.ToString();
                        clientDTO.Address.ID = cmd.Parameters["@AddressID"].Value == DBNull.Value ? -1 : Convert.ToInt32(cmd.Parameters["@AddressID"].Value);
                        clientDTO.RegistrationDate = cmd.Parameters["@Registerationdate"].Value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(cmd.Parameters["@Registerationdate"].Value);
                        clientDTO.ClientTypeID = cmd.Parameters["@ClientTypeID"].Value == DBNull.Value ? -1 : (int)cmd.Parameters["@ClientTypeID"].Value;
                        clientDTO.PersonID = cmd.Parameters["@PersonID"].Value == DBNull.Value ? -1 : (int)cmd.Parameters["@PersonID"].Value;

                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return null;
            }

            return clientDTO;
        } 

        public static DataTable SearchWithNationalID(string NationalID, int PageNumber, int PageSize, ref int TotalRows)
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_SearchClientWithNationalIDWithPagination", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NationalID", NationalID);
                    cmd.Parameters.AddWithValue("@PageNumber", PageNumber);
                    cmd.Parameters.AddWithValue("@PageSize", PageSize);
                    cmd.Parameters.Add("@TotalRows", SqlDbType.Int).Direction = ParameterDirection.Output;

                    Connection.Open();
                    using (SqlDataReader Reader = cmd.ExecuteReader())
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
                return null;
            }

            return dt;
        } 

        public static DataTable SearchWithFirstName(string FirstName, int PageNumber, int PageSize, ref int TotalRows)
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_SearchClientWithFirstNameWithPagination", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@PageNumber", PageNumber);
                    cmd.Parameters.AddWithValue("@PageSize", PageSize);
                    cmd.Parameters.Add("@TotalRows", SqlDbType.Int).Direction = ParameterDirection.Output;

                    Connection.Open();
                    using (SqlDataReader Reader = cmd.ExecuteReader())
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
                return null;
            }

            return dt;
        }

        public async static Task<(DataTable, int)> GetAllClients(short PageNumber, short PageSize)
        {
            DataTable dt = new DataTable();
            int TotalRows = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetAllClients", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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
                return (null, 0);
            }

            return (dt, TotalRows);
        } 

        public static int AddNewClient(ref ClientDTO clientDTO)
        {
            int ClientID = -1;
            try
            {
                using (SqlConnection Connection = new SqlConnection(ConnectionString))

                using (SqlCommand cmd = new SqlCommand("sp_AddNewClient", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FirstName", clientDTO.FirstName);
                    cmd.Parameters.AddWithValue("@SecondName", clientDTO.SecondName);
                    cmd.Parameters.AddWithValue("@ThirdName", clientDTO.ThirdName);
                    cmd.Parameters.AddWithValue("@LastName", clientDTO.LastName);
                    cmd.Parameters.AddWithValue("@Email", clientDTO.Email);
                    cmd.Parameters.AddWithValue("@DateOfBirth", clientDTO.DateOfBirth);
                    cmd.Parameters.AddWithValue("@NationalID", clientDTO.NationalID);
                    cmd.Parameters.AddWithValue("@Gender", clientDTO.Gender);
                    cmd.Parameters.AddWithValue("@PhotoPath", clientDTO.PhotoPath);
                    cmd.Parameters.AddWithValue("@AddressID", clientDTO.Address.ID);
                    cmd.Parameters.AddWithValue("@RegistrationDate", clientDTO.RegistrationDate);           
                    cmd.Parameters.AddWithValue("@ClientTypeID", clientDTO.ClientTypeID);

                    SqlParameter outputClientID = new SqlParameter("@ClientID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputClientID);
                    SqlParameter outputPersonID = new SqlParameter("@PersonID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputPersonID);

                    Connection.Open();
                    cmd.ExecuteNonQuery();

                    if (outputClientID.Value != DBNull.Value)
                        ClientID = (int)outputClientID.Value;

                    if (outputPersonID.Value != DBNull.Value)
                        clientDTO.PersonID = (int)outputPersonID.Value;

                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return -1;
            }
            return ClientID;
        } 

        public static bool DeleteClient(int ID)
        {
            short Return = -1;

            try
            {             
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_DeleteClientWithID", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ClientID", ID);

                    SqlParameter ReturnValue = new SqlParameter("RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };


                    cmd.Parameters.Add(ReturnValue);

                    Connection.Open();
                    cmd.ExecuteNonQuery();
                    if (ReturnValue.Value != DBNull.Value)
                        Return = (short)ReturnValue.Value;

                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }
            return Return == 1;

        }

        public static bool UpdateClient(ClientDTO clientDTO)
        {
            int Return = -1;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_UpdateClient", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", clientDTO.ID);
                    cmd.Parameters.AddWithValue("@FirstName", clientDTO.FirstName);
                    cmd.Parameters.AddWithValue("@SecondName", clientDTO.SecondName);
                    cmd.Parameters.AddWithValue("@ThirdName", clientDTO.ThirdName);
                    cmd.Parameters.AddWithValue("@LastName", clientDTO.LastName);
                    cmd.Parameters.AddWithValue("@Email", clientDTO.Email);
                    cmd.Parameters.AddWithValue("@DateOfBirth", clientDTO.DateOfBirth);
                    cmd.Parameters.AddWithValue("@NationalID", clientDTO.NationalID);
                    cmd.Parameters.AddWithValue("@PhotoPath", clientDTO.PhotoPath);
                    if (clientDTO.Gender == "Male")
                    {
                        cmd.Parameters.AddWithValue("@Gender", 0);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Gender", 1);
                    }
                    cmd.Parameters.AddWithValue("@AddressID", clientDTO.Address.ID);   
                    cmd.Parameters.AddWithValue("@RegistrationDate", clientDTO.RegistrationDate);
                    cmd.Parameters.AddWithValue("@ClientTypeID", clientDTO.ClientTypeID);

                    SqlParameter ReturnValue = new SqlParameter("RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    cmd.Parameters.Add(ReturnValue);

                    Connection.Open();
                    cmd.ExecuteNonQuery();

                    Return = cmd.Parameters["RETURN_VALUE"].Value == DBNull.Value ? -1 : Convert.ToInt32(cmd.Parameters["RETURN_VALUE"].Value);

                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return false;
            }

            return Return == 1;

        } 

        public static int TotalClientsNumber()
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetTotalClients", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int parsed))
                    {
                        count = parsed;
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return -1;
            }

            return count;
        } 

        public static decimal AverageBalances()
        {
            decimal Average = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetAverageBalance", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null && decimal.TryParse(result.ToString(), out decimal parsed))
                        Average = parsed;
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return -1;
            }
            return Average;
        }

        public static decimal TotalBalances()
        {
            decimal Total = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetTotalBalance", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null && decimal.TryParse(result.ToString(), out decimal parsed))
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

        public static bool IsExist(int ID)
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_IsClientExistWithID", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);

                    SqlParameter ReturnValue = new SqlParameter("RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(ReturnValue);

                    Connection.Open();
                    cmd.ExecuteNonQuery();

                    int result = (int)(cmd.Parameters["RETURN_VALUE"].Value ?? 0);
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

        public static int CloseAccounts(int clientId)
        {
            int closedCount = 0;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_CloseAccounts", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ClientID", clientId);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            closedCount = Convert.ToInt32(result);
                        }
                    }
                }
               
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                }             
            }

            return closedCount;
        }


    }
}
