using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsCurrencyExchange
    {
        public static bool AddCurrencyExchange(CurrencyExchangeDTO DTO)
        {
            return clsCurrencyExchangeDataAccess.AddCurrencyExchange(DTO) != -1;
        }

        public async static Task<(DataTable,int)> GetAllCurrencyExchanges(int PageSize , int PageNumber)
        {
            return await clsCurrencyExchangeDataAccess.GetAllCurrencyExchanges(PageSize, PageNumber);
        }

    }
}
