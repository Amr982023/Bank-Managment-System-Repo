using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsCashReserve
    {
        public static bool RecordCashReserve(int UserID)
        {
            return clsCashReserveDataAccess.RecordCashReserve(UserID);
        }

        public static async Task<(DataTable Data, int TotalRows)> GetCashReservesListAsync(short pageNumber, short pageSize)
        {
            return await clsCashReserveDataAccess.GetCashReservesListAsync(pageSize, pageNumber);
        }

    }
}
