using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;
using Common;
using System.Diagnostics;

namespace Data_Access_Layer
{
    public class clsCurrencyExchangeDataAccess
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static int AddCurrencyExchange(CurrencyExchangeDTO DTO)
        {
            int newExchangeId = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("sp_AddCurrencyExchange", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Amount",DTO.Amount);
                    command.Parameters.AddWithValue("@Rate", DTO.Rate);
                    command.Parameters.AddWithValue("@SourceCurrency", DTO.SourceCurrency);
                    command.Parameters.AddWithValue("@DestinationCurrency", DTO.DestinationCurrency);
                    command.Parameters.AddWithValue("@CreatedBy", DTO.CreatedBy);


                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        newExchangeId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }

            return newExchangeId;
        }

        public async static Task<(DataTable, int)> GetAllCurrencyExchanges(int pageSize, int pageNumber)
        {
            DataTable dt = new DataTable();
            int totalRows = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("sp_GetAllCurrencyExchanges", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PageSize", pageSize);
                    command.Parameters.AddWithValue("@PageNumber", pageNumber);

                    SqlParameter totalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(totalRowsParam);

                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }

                    totalRows = (int)(command.Parameters["@TotalRows"].Value ?? 0);
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
