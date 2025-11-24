using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Layer
{
    public static class clsLoginLogs
    {      

        public static int Save(int UserID)
        {
           return  clsLoginLogsDataAccess.SaveLoginLog(UserID);
        }

        public static void Logout(int LoginID)
        {
           clsLoginLogsDataAccess.Logout(LoginID);
        }

        public static async Task <(DataTable, int)> GetAllWithPagination(short PageNumber, short PageSize)
        {
            return await clsLoginLogsDataAccess.GetLoginLogs(PageNumber, PageSize);
        }

    }

}
