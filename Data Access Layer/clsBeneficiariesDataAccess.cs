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
using Common.DTOS;

namespace Data_Access_Layer
{
    public class clsBeneficiariesDataAccess
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static bool IsExist(BeneficiaryDTO DTO)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_IsBeneficiaryExist", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BankID",DTO.BankID);
                    cmd.Parameters.AddWithValue("@ClientID",DTO.ClientID);
                    cmd.Parameters.AddWithValue("@AccountNumber",DTO.AccountNumber);

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

        public static int AddNewBeneficiary(BeneficiaryDTO DTO)
        {

            int beneficiaryId = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("sp_AddNewBeneficiary", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Input parameters
                    command.Parameters.AddWithValue("@ClientID", DTO.ClientID);
                    command.Parameters.AddWithValue("@BankID", DTO.BankID);
                    command.Parameters.AddWithValue("@AccountNumber", DTO.AccountNumber);

                    command.Parameters.AddWithValue("@IBAN", (object)DTO.IBAN ?? DBNull.Value);
                    command.Parameters.AddWithValue("@NationalID", (object)DTO.NationalID ?? DBNull.Value);
                    command.Parameters.AddWithValue("@FirstName", (object)DTO.FirstName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@LastName", (object)DTO.LastName ?? DBNull.Value);

                    // Output parameter
                    SqlParameter outputParam = new SqlParameter("@BeneficiaryID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    // Execute
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Get output value
                    if (outputParam.Value != DBNull.Value)
                        beneficiaryId = (int)outputParam.Value;
                }
            }catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return -1;
            }
            return beneficiaryId;
        }
    
    }
}
