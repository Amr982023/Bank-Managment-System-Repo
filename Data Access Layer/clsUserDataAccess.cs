using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.DTOS;

namespace Data_Access_Layer
{
    public class clsUserDataAccess
    {
       public static event Action<string> Msg;
        static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        public static UserDTO FindUser(int ID)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Address= new AddressDTO();
            userDTO.ID = ID;

            try
            {            
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_FindUserWithID", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 25).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@NationalID", SqlDbType.NVarChar, 14).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@AddressID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PhotoPath", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Permission", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PersonID", SqlDbType.Int).Direction = ParameterDirection.Output;

                    SqlParameter returnValue = new SqlParameter("RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(returnValue);

                    Connection.Open();
                    cmd.ExecuteNonQuery();

                    if ((int)returnValue.Value == 1)
                    {
                        userDTO.FirstName = cmd.Parameters["@FirstName"].Value?.ToString() ?? "";
                        userDTO.SecondName = cmd.Parameters["@SecondName"].Value?.ToString() ?? "";
                        userDTO.ThirdName = cmd.Parameters["@ThirdName"].Value?.ToString() ?? "";
                        userDTO.LastName = cmd.Parameters["@LastName"].Value?.ToString() ?? "";
                        userDTO.Email = cmd.Parameters["@Email"].Value?.ToString() ?? "";
                        userDTO.DateOfBirth = cmd.Parameters["@DateOfBirth"].Value==DBNull.Value?(DateTime?)null: Convert.ToDateTime(cmd.Parameters["@DateOfBirth"].Value);
                        userDTO.NationalID = cmd.Parameters["@NationalID"].Value?.ToString() ?? "";
                        userDTO.Gender = cmd.Parameters["@Gender"].Value?.ToString() ?? "";
                        userDTO.Address.ID = cmd.Parameters["@AddressID"].Value==DBNull.Value? -1 : Convert.ToInt32(cmd.Parameters["@AddressID"].Value);
                        userDTO.UserName = cmd.Parameters["@UserName"].Value?.ToString() ?? "";
                        userDTO.Password = cmd.Parameters["@Password"].Value?.ToString() ?? "";
                        userDTO.PhotoPath = cmd.Parameters["@PhotoPath"].Value?.ToString() ?? "";
                        userDTO.Permission = cmd.Parameters["@Permission"].Value == DBNull.Value ? 0 : Convert.ToInt32(cmd.Parameters["@Permission"].Value);
                        userDTO.PersonID = cmd.Parameters["@PersonID"].Value == DBNull.Value ? -1 : Convert.ToInt32(cmd.Parameters["@PersonID"].Value);
                    }else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
               return null;
            }

            return userDTO;
        }

        public static UserDTO FindUserWithUserName(string UserName)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Address = new AddressDTO();
            userDTO.UserName = UserName;

            try
            {            
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_FindUserWithUserName", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 25).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@NationalID", SqlDbType.NVarChar, 14).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@AddressID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PhotoPath", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Permission", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PersonID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    SqlParameter returnValue = new SqlParameter("RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(returnValue);

                    Connection.Open();
                    cmd.ExecuteNonQuery();

                    if ((int)cmd.Parameters["RETURN_VALUE"].Value == 1)
                    {
                        userDTO.ID = Convert.ToInt32(cmd.Parameters["@ID"].Value);
                        userDTO.FirstName = cmd.Parameters["@FirstName"].Value?.ToString() ?? "";
                        userDTO.SecondName = cmd.Parameters["@SecondName"].Value?.ToString() ?? "";
                        userDTO.ThirdName = cmd.Parameters["@ThirdName"].Value?.ToString() ?? "";
                        userDTO.LastName = cmd.Parameters["@LastName"].Value?.ToString() ?? "";
                        userDTO.Email = cmd.Parameters["@Email"].Value?.ToString() ?? "";
                        userDTO.DateOfBirth = cmd.Parameters["@DateOfBirth"].Value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(cmd.Parameters["@DateOfBirth"].Value);
                        userDTO.NationalID = cmd.Parameters["@NationalID"].Value?.ToString() ?? "";
                        userDTO.Gender = cmd.Parameters["@Gender"].Value?.ToString() ?? "";
                        userDTO.Address.ID = cmd.Parameters["@AddressID"].Value == DBNull.Value ? -1 : Convert.ToInt32(cmd.Parameters["@AddressID"].Value);                 
                        userDTO.Password = cmd.Parameters["@Password"].Value?.ToString() ?? "";
                        userDTO.PhotoPath = cmd.Parameters["@PhotoPath"].Value?.ToString() ?? "";
                        userDTO.Permission = cmd.Parameters["@Permission"].Value == DBNull.Value ? 0 : Convert.ToInt32(cmd.Parameters["@Permission"].Value);
                        userDTO.PersonID = cmd.Parameters["@PersonID"].Value == DBNull.Value ? -1 : Convert.ToInt32(cmd.Parameters["@PersonID"].Value);

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

            return userDTO;
        }

        public static UserDTO FindByUserNameAndPassword(string UserName, string Password)
        {
           UserDTO userDTO = new UserDTO();
            userDTO.Address = new AddressDTO();
            userDTO.UserName = UserName;
            userDTO.Password = Password;

            try
            {
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_FindUserByUserNameAndPassword", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 25).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@NationalID", SqlDbType.NVarChar, 14).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@AddressID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PhotoPath", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Permission", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PersonID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    SqlParameter ReturnValue = new SqlParameter("RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(ReturnValue);

                    Connection.Open();
                    cmd.ExecuteNonQuery();

                    if ((int)(cmd.Parameters["RETURN_VALUE"].Value ?? 0) == 1)
                    {
                        userDTO.ID = Convert.ToInt32(cmd.Parameters["@ID"].Value);
                        userDTO.FirstName = cmd.Parameters["@FirstName"].Value?.ToString() ?? "";
                        userDTO.SecondName = cmd.Parameters["@SecondName"].Value?.ToString() ?? "";
                        userDTO.ThirdName = cmd.Parameters["@ThirdName"].Value?.ToString() ?? "";
                        userDTO.LastName = cmd.Parameters["@LastName"].Value?.ToString() ?? "";
                        userDTO.Email = cmd.Parameters["@Email"].Value?.ToString() ?? "";
                        userDTO.DateOfBirth = cmd.Parameters["@DateOfBirth"].Value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(cmd.Parameters["@DateOfBirth"].Value);
                        userDTO.NationalID = cmd.Parameters["@NationalID"].Value?.ToString() ?? "";
                        userDTO.Gender = cmd.Parameters["@Gender"].Value?.ToString() ?? "";
                        userDTO.Address.ID = cmd.Parameters["@AddressID"].Value == DBNull.Value ? -1 : Convert.ToInt32(cmd.Parameters["@AddressID"].Value);   
                        userDTO.PhotoPath = cmd.Parameters["@PhotoPath"].Value?.ToString() ?? "";
                        userDTO.Permission = cmd.Parameters["@Permission"].Value == DBNull.Value ? 0 : Convert.ToInt32(cmd.Parameters["@Permission"].Value);
                        userDTO.PersonID = cmd.Parameters["@PersonID"].Value == DBNull.Value ? -1 : Convert.ToInt32(cmd.Parameters["@PersonID"].Value);

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
                Msg.Invoke($"Error: {ex.Message}");
                return null;
            }

            return userDTO;
        }

        public async static Task<(DataTable,int)> GetAllUsersWithPaging(short PageNumber, short PageSize)
        {
            DataTable dt = new DataTable();
            int TotalRows = 0;
       
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_GetAllUsersWithPaging", Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PageNumber", PageNumber);
                cmd.Parameters.AddWithValue("@PageSize", PageSize);
                cmd.Parameters.Add("@TotalRows", SqlDbType.Int).Direction = ParameterDirection.Output;

                try
                {
                    await Connection.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }

                    TotalRows = cmd.Parameters["@TotalRows"].Value == DBNull.Value
                                ? 0
                                : Convert.ToInt32(cmd.Parameters["@TotalRows"].Value);
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                    Msg.Invoke($"Error: {ex.Message}");
                }
            }

            return (dt,TotalRows);
        }

        public static DataTable SearchWithUserName(string UserName, short PageNumber, short PageSize, ref int TotalRows)
        {
            DataTable dt = new DataTable();

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_SearchUsersWithUserNamePaging", Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@PageNumber", PageNumber);
                cmd.Parameters.AddWithValue("@PageSize", PageSize);
                cmd.Parameters.Add("@TotalRows", SqlDbType.Int).Direction = ParameterDirection.Output;

                try
                {
                    Connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }

                    TotalRows = cmd.Parameters["@TotalRows"].Value == DBNull.Value
                                ? 0
                                : Convert.ToInt32(cmd.Parameters["@TotalRows"].Value);
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                    Msg.Invoke($"Error: {ex.Message}");
                }
            }

            return dt;
        }

        public static DataTable SearchWithFirstName(string FirstName, short PageNumber, short PageSize, ref int TotalRows)
        {
            DataTable dt = new DataTable();
     
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_SearchUsersWithFirstNamePaging", Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@PageNumber", PageNumber);
                cmd.Parameters.AddWithValue("@PageSize", PageSize);
                cmd.Parameters.Add("@TotalRows", SqlDbType.Int).Direction = ParameterDirection.Output;

                try
                {
                    Connection.Open();

                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.HasRows)
                            dt.Load(Reader);
                    }

                    TotalRows = cmd.Parameters["@TotalRows"].Value == DBNull.Value? 0: Convert.ToInt32(cmd.Parameters["@TotalRows"].Value);
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                    Msg.Invoke($"Error: {ex.Message}");
                    return null;
                }
            }

            return dt;
        }

        public static int AddNewUser(ref UserDTO userDTO)
        {
            int NewUserID = -1;
      
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_AddNewUser", Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", userDTO.FirstName);
                cmd.Parameters.AddWithValue("@SecondName", userDTO.SecondName);
                cmd.Parameters.AddWithValue("@ThirdName", userDTO.ThirdName);
                cmd.Parameters.AddWithValue("@LastName", userDTO.LastName);
                cmd.Parameters.AddWithValue("@Email", userDTO.Email);
                cmd.Parameters.AddWithValue("@DateOfBirth", userDTO.DateOfBirth);
                cmd.Parameters.AddWithValue("@NationalID", userDTO.NationalID);
                cmd.Parameters.AddWithValue("@Gender", userDTO.Gender);
                cmd.Parameters.AddWithValue("@PhotoPath", userDTO.PhotoPath);
                cmd.Parameters.AddWithValue("@AddressID", userDTO.Address.ID);
                cmd.Parameters.AddWithValue("@Password", userDTO.Password);
                cmd.Parameters.AddWithValue("@UserName", userDTO.UserName);
                cmd.Parameters.AddWithValue("@Permission", userDTO.Permission);

                SqlParameter outputUserID = new SqlParameter("@NewUserID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputUserID);


                SqlParameter outputPersonID = new SqlParameter("@PersonID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputPersonID);

                try
                {
                    Connection.Open();
                    cmd.ExecuteNonQuery();

                    if (outputUserID.Value != DBNull.Value)
                        NewUserID = Convert.ToInt32(outputUserID.Value);

                    if (outputPersonID.Value != DBNull.Value)
                        userDTO.PersonID = Convert.ToInt32(outputPersonID.Value);
                
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                    Msg.Invoke($"Error : {ex.Message}");
                    return -1;
                }
            }

            return NewUserID;
        }

        public static bool DeleteUser(int ID)
        {
            int ReturnValue = -1;

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_DeleteUserWithID", Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);

                SqlParameter returnParam = new SqlParameter("RETURN_VALUE", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                cmd.Parameters.Add(returnParam);

                try
                {
                    Connection.Open();
                    cmd.ExecuteNonQuery();

                    ReturnValue = cmd.Parameters["RETURN_VALUE"].Value != DBNull.Value ? Convert.ToInt32(cmd.Parameters["RETURN_VALUE"].Value) : -1;
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                    clsErrorEvents.onError(ex.Message);
                    Msg.Invoke($"Error: {ex.Message}");
                }
            }     

            return ReturnValue == 1;
        }

        public static bool UpdateUser(UserDTO userDTO)
        {
            int ReturnValue = -1;

            try
            {      
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_UpdateUser", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", userDTO.ID);
                    cmd.Parameters.AddWithValue("@FirstName", userDTO.FirstName);
                    cmd.Parameters.AddWithValue("@SecondName", userDTO.SecondName);
                    cmd.Parameters.AddWithValue("@ThirdName", userDTO.ThirdName);
                    cmd.Parameters.AddWithValue("@LastName", userDTO.LastName);
                    cmd.Parameters.AddWithValue("@Email", userDTO.Email);
                    cmd.Parameters.AddWithValue("@DateOfBirth", userDTO.DateOfBirth);
                    cmd.Parameters.AddWithValue("@NationalID", userDTO.NationalID);
                    cmd.Parameters.AddWithValue("@PhotoPath", userDTO.PhotoPath);
                    if (userDTO.Gender == "Male")
                    {
                        cmd.Parameters.AddWithValue("@Gender", 0);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Gender", 1);
                    }
                    cmd.Parameters.AddWithValue("@AddressID", userDTO.Address.ID);
                    cmd.Parameters.AddWithValue("@UserName", userDTO.UserName);
                    cmd.Parameters.AddWithValue("@Password", userDTO.Password);
                    cmd.Parameters.AddWithValue("@Permission", userDTO.Permission);

                    SqlParameter returnParam = new SqlParameter("RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(returnParam);

                    Connection.Open();
                    cmd.ExecuteNonQuery();

                    ReturnValue = cmd.Parameters["RETURN_VALUE"].Value != DBNull.Value ? Convert.ToInt32(cmd.Parameters["RETURN_VALUE"].Value) : -1;
                }
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);  
                return false;
            }

            return ReturnValue == 1;
        }

        public static bool IsExist(string UserName)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_IsUserExistWithUserName", Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", UserName);

                    SqlParameter ReturnValue = new SqlParameter("RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(ReturnValue);

                    Connection.Open();
                    cmd.ExecuteNonQuery();

                    int result = cmd.Parameters["RETURN_VALUE"].Value != DBNull.Value ? Convert.ToInt32(cmd.Parameters["RETURN_VALUE"].Value) : -1;

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

    }
}
