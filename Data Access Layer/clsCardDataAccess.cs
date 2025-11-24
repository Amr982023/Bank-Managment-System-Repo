using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;
using Common;

namespace Data_Access_Layer
{
    public class clsCardDataAccess
    {
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static int AddNewCard(CardDTO Card)
        {
            int newID = -1;
            try
            {


                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_AddNewCard", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Expiration_Date", Card.Expiration_Date);
                    cmd.Parameters.AddWithValue("@Password", Card.Password);
                    cmd.Parameters.AddWithValue("@Card_Status_ID", Card.Card_Status_ID);
                    cmd.Parameters.AddWithValue("@Card_Network_ID", Card.Card_Network_ID);
                    cmd.Parameters.AddWithValue("@Account_ID", Card.Account_ID);
                    cmd.Parameters.AddWithValue("@CardNumber", Card.Card_Number);
                    cmd.Parameters.AddWithValue("@Card_Type_ID", Card.Card_Type_ID);
                    

                    SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    newID = (int)outputIdParam.Value;
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return -1;
            }

            return newID;
        }

        public static CardDTO GetCardByID(int ID)
        {
            CardDTO dTO = new CardDTO();
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetCardByID", Conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.Add("@Card_Status_ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Account_ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Card_Number", SqlDbType.NVarChar,16).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Expiration_Date", SqlDbType.Date).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Card_Type_ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Card_Network_ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar,64).Direction = ParameterDirection.Output;
                  
                    Conn.Open();
                    cmd.ExecuteNonQuery();

                    dTO.ID = ID;
                    dTO.Card_Status_ID = cmd.Parameters["@Card_Status_ID"].Value == DBNull.Value ? -1 : (int)cmd.Parameters["@Card_Status_ID"].Value;
                    dTO.Account_ID = cmd.Parameters["@Account_ID"].Value == DBNull.Value ? -1 : (int)cmd.Parameters["@Account_ID"].Value;
                    dTO.Card_Number = cmd.Parameters["@Card_Number"].Value == DBNull.Value ? "" : cmd.Parameters["@Card_Number"].Value.ToString();
                    dTO.Expiration_Date = cmd.Parameters["@Expiration_Date"].Value == DBNull.Value? (DateTime?)null : Convert.ToDateTime(cmd.Parameters["@Expiration_Date"].Value);
                    dTO.Card_Type_ID = cmd.Parameters["@Card_Type_ID"].Value == DBNull.Value ? -1 : (int)cmd.Parameters["@Card_Type_ID"].Value;
                    dTO.Card_Network_ID = cmd.Parameters["@Card_Network_ID"].Value == DBNull.Value ? -1 : (int)cmd.Parameters["@Card_Network_ID"].Value;
                    dTO.Password = cmd.Parameters["@Password"].Value == DBNull.Value ? "": cmd.Parameters["@Password"].Value.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return null;
            }
            return dTO;
        }

        public static CardDTO GetCardByAccountID(int AccountID)
        {
            CardDTO dTO = new CardDTO();
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetCardByAccountID", Conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Account_ID", AccountID);
                    cmd.Parameters.Add("@Card_Status_ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Card_Number", SqlDbType.NVarChar, 16).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Expiration_Date", SqlDbType.Date).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Card_Type_ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Card_Network_ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 64).Direction = ParameterDirection.Output;

                    Conn.Open();
                    cmd.ExecuteNonQuery();

                    dTO.Account_ID = AccountID;
                    dTO.Card_Status_ID = cmd.Parameters["@Card_Status_ID"].Value == DBNull.Value ? -1 : (int)cmd.Parameters["@Card_Status_ID"].Value;
                    dTO.ID = cmd.Parameters["@ID"].Value == DBNull.Value ? -1 : (int)cmd.Parameters["@ID"].Value;
                    dTO.Card_Number = cmd.Parameters["@Card_Number"].Value == DBNull.Value ? "" : cmd.Parameters["@Card_Number"].Value.ToString();
                    dTO.Expiration_Date = cmd.Parameters["@Expiration_Date"].Value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(cmd.Parameters["@Expiration_Date"].Value);
                    dTO.Card_Type_ID = cmd.Parameters["@Card_Type_ID"].Value == DBNull.Value ? -1 : (int)cmd.Parameters["@Card_Type_ID"].Value;
                    dTO.Card_Network_ID = cmd.Parameters["@Card_Network_ID"].Value == DBNull.Value ? -1 : (int)cmd.Parameters["@Card_Network_ID"].Value;
                    dTO.Password = cmd.Parameters["@Password"].Value == DBNull.Value ? "" : cmd.Parameters["@Password"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return null;
            }
            return dTO;
        }

        public static bool UpdateCard(CardDTO DTO)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_UpdateCard", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", DTO.ID);
                    cmd.Parameters.AddWithValue("@Card_Status_ID", DTO.Card_Status_ID);
                    cmd.Parameters.AddWithValue("@Account_ID", DTO.Account_ID);
                    cmd.Parameters.AddWithValue("@Card_Number", DTO.Card_Number);
                    cmd.Parameters.AddWithValue("@Expiration_Date", DTO.Expiration_Date);
                    cmd.Parameters.AddWithValue("@Card_Type_ID", DTO.Card_Type_ID);
                    cmd.Parameters.AddWithValue("@Card_Network_ID", DTO.Card_Network_ID);
                    cmd.Parameters.AddWithValue("@Password", DTO.Password);

                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
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

        public static bool Change_Card_Status(int CardID,int StatusID)
        {
            if (StatusID >7 ||StatusID <=0)
            {
                throw new Exception("the Status ID Should be between 1 and 7 ");           
            }
            int rowsAffected = 0;
            try
            {


                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_Change_Card_Status", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", CardID);
                    cmd.Parameters.AddWithValue("@Card_Status_ID", StatusID);

                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
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

     

    }
}
