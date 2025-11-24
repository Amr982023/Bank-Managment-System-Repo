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
   public  class clsCountryDataAccess
    {
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            try
            {

                string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetAllCountries", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }
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

        public static CountryDTO GetCountry(int id)
        {
            CountryDTO CountryDTO = new CountryDTO();

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
                using (SqlConnection Connection = new SqlConnection (ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetCountryByID", Connection))
                {
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CountryID", id);
                    Connection.Open();
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                       
                        if (Reader.Read())
                        {
                            CountryDTO.CountryID = Reader.GetInt32(Reader.GetOrdinal("ID"));
                            CountryDTO.Name = Reader.GetString(Reader.GetOrdinal("Name"));
                            CountryDTO.Code = Reader.GetString(Reader.GetOrdinal("Code"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }

            return CountryDTO;

        }

    }
}
