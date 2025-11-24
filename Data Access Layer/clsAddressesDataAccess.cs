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
using Common.DTOS;

namespace Data_Access_Layer
{
    public class clsAddressesDataAccess
    {
        public static AddressDTO Find(int ID)
        {
            AddressDTO Address = new AddressDTO();
            Address.Country = new CountryDTO();
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_FindAddress", Conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.Add("@City", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Street", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@CountryID", SqlDbType.Int).Direction = ParameterDirection.Output;

                    SqlParameter ReturnValue = new SqlParameter("@RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    cmd.Parameters.Add(ReturnValue);
                    Conn.Open();
                    cmd.ExecuteNonQuery();

                    if((int)ReturnValue.Value==1)
                    {
                        Address.ID = ID;
                        Address.Street= cmd.Parameters["@Street"].Value == DBNull.Value ? "" : cmd.Parameters["@Street"].Value.ToString();
                        Address.City= cmd.Parameters["@City"].Value == DBNull.Value ? "" : cmd.Parameters["@City"].Value.ToString();
                        Address.Country.CountryID = cmd.Parameters["@CountryID"].Value == DBNull.Value ? -1 : Convert.ToInt32(cmd.Parameters["@CountryID"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return null;
            }
            return Address;
        }

        public static int AddNew(AddressDTO Address)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_AddNewAddress", Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Street", Address.Street);
                    cmd.Parameters.AddWithValue("@City", Address.City);
                    cmd.Parameters.AddWithValue("@CountryID", Address.Country.CountryID);
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;

                    Conn.Open();
                    cmd.ExecuteNonQuery();

                    if (cmd.Parameters["@ID"].Value!=DBNull.Value)
                    {
                        Address.ID = (int)cmd.Parameters["@ID"].Value;
                    }

                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return -1;
            }
            return Address.ID;
        }

        public static bool Update(AddressDTO addressDTO)
        {
            AddressDTO Address = new AddressDTO();
            bool Flag = false;
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_UpdateAddress", Conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", addressDTO.ID);
                    cmd.Parameters.AddWithValue("@City", addressDTO.City);
                    cmd.Parameters.AddWithValue("@Street", addressDTO.Street);
                    cmd.Parameters.AddWithValue("@CountryID", addressDTO.Country.CountryID);


                    SqlParameter ReturnValue = new SqlParameter("@RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    cmd.Parameters.Add(ReturnValue);
                    Conn.Open();
                    cmd.ExecuteNonQuery();

                    if ((int)ReturnValue.Value == 1)
                    {
                        Flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return false;
            }
            return Flag;
        }

        public static bool Delete(int ID)
        {
            bool Flag = false;
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_DeleteAddress", Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);

                    SqlParameter ReturnValue = new SqlParameter("@RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    cmd.Parameters.Add(ReturnValue);
                    Conn.Open();
                    cmd.ExecuteNonQuery();


                    if ((int)ReturnValue.Value == 1)
                    {
                        Flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return false;
            }
            return Flag;
        }

        public static bool IsExist(int ID)
        {
            bool Flag = false;
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_IsAddressExist", Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                   
                    cmd.Parameters.AddWithValue("@ID", ID);

                    SqlParameter ReturnValue = new SqlParameter("@RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    cmd.Parameters.Add(ReturnValue);
                    Conn.Open();
                    cmd.ExecuteNonQuery();


                    if ((int)ReturnValue.Value == 1)
                    {
                        Flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return false;
            }
            return Flag;
        }


    }
}
