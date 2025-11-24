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

namespace Data_Access_Layer
{
    public class clsCardTypeDataAccess
    {
        public static DataTable Get_Credit_Card_Types_List()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_Get_Credit_Card_Types_List", Conn))
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

    }
}
