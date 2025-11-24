using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Data_Access_Layer
{
    public class clsCurrencyDataAccess
    {
        static string connectionstring = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        public static DataTable GetAllCurrencies()
        {
            DataTable dt = new DataTable();
            
            try
            {
                using (SqlConnection Conn = new SqlConnection(connectionstring))

                using (SqlCommand cmd = new SqlCommand("sp_GetAllCurrencies", Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    Conn.Open();
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        dt.Load(Reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }

            return dt;
        }

        public static (string Code, string Name, int CountryId) GetCurrency(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("sp_GetCurrency", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);

                 connection.Open();

                using (SqlDataReader reader =  command.ExecuteReader())
                {
                    if ( reader.Read())
                    {
                        string code = reader.GetString(reader.GetOrdinal("Code"));
                        string name = reader.GetString(reader.GetOrdinal("Name"));
                        int countryId = reader.GetInt32(reader.GetOrdinal("CountryId"));

                        return (code, name, countryId);
                    }
                }
            }

            return (null,null,-1);
        }


        public static DateTime? LastUpdate()
        {
           
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                using (SqlCommand cmd = new SqlCommand("sp_GetLastUpdateDate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                           
                            return reader.GetDateTime(0);
                        }
                    }
                }
            }catch(Exception ex)
            {

                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }

            return null; 

        }

        public static void SaveCurrencyRates(Dictionary<string, double> quotes, DateTime Today)
        {
           
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    foreach (var item in quotes)
                    {
                        string currencyCode = item.Key.Substring(3); // Remove "USD" prefix
                        double rate = item.Value;

                        using (SqlCommand cmd = new SqlCommand("sp_UpdateCurrencyRate", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@CurrencyCode", currencyCode);
                            cmd.Parameters.AddWithValue("@Rate", rate);
                            cmd.Parameters.AddWithValue("@UpdateDate", Today);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }catch(Exception ex)
            {

                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }
        }

        public static double GetLatestCurrencyRateByCode(string currencyCode)
        {        

            if (currencyCode.ToUpper() == "USD")
                return 1.0;

            if (!string.IsNullOrEmpty(currencyCode) && currencyCode.Length > 3)
                currencyCode = currencyCode.Substring(3); // Remove "USD" prefix

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand("sp_GetLatestCurrencyRateByCode", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CurrencyCode", currencyCode);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        if (reader.Read())
                        {
                            if (reader["Rate"] != DBNull.Value)
                            {
                                return Convert.ToDouble(reader["Rate"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }

            return 0;
        }


        

    }
}
