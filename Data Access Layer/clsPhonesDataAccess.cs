using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using Common;
using Common.DTOS;

namespace Data_Access_Layer
{
    public static class clsPhoneDataAccess
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        public static int AddNewPhone(PhoneDTO phone)
        {
            int newID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("sp_AddPhone", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Number", phone.Number);
                    command.Parameters.AddWithValue("@PersonID", phone.PersonID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                        newID = Convert.ToInt32(result);
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

        public static bool UpdatePhone(PhoneDTO phone)
        {
            bool isUpdated = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("sp_UpdatePhone", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID", phone.ID);
                    command.Parameters.AddWithValue("@Number", phone.Number);
                    command.Parameters.AddWithValue("@PersonID", phone.PersonID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    isUpdated = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return false;
            }

            return isUpdated;
        }

        public static bool DeletePhone(int id)
        {
            bool isDeleted = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("sp_DeletePhone", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    isDeleted = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
                return false;
            }

            return isDeleted;
        }

        public static PhoneDTO FindPhone(int id)
        {
            PhoneDTO phone = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("sp_FindPhone", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            phone = new PhoneDTO
                            {
                                ID = (int)reader["ID"],
                                Number = reader["Number"].ToString(),
                                PersonID = (int)reader["PersonID"]
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

            return phone;
        }

        public static PhoneDTO FindPhoneByNumber(string number)
        {
            PhoneDTO phone = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_FindPhoneByNumber", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Number", number);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        phone = new PhoneDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Number = reader["Number"].ToString(),
                            PersonID = Convert.ToInt32(reader["PersonID"])
                        };
                    }
                }
            }

            return phone;
        }

        public static List<PhoneDTO> GetPhonesByPersonID(int PersonID)
        {
            PhoneDTO phone = null;

            List<PhoneDTO> List = new List<PhoneDTO>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_GetPhonesByPersonID", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", PersonID);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        phone = new PhoneDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Number = reader["Number"].ToString(),
                            PersonID = PersonID
                        };
                        List.Add(phone);
                    }
                }
            }

            return List;
        }

        public async static Task<DataTable> GetAllPhones()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("sp_GetAllPhones", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
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

        public static bool IsExist(int id)
        {
            bool exists = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("sp_IsPhoneExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    exists = (result != null && Convert.ToInt32(result) == 1);
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

    }
}
