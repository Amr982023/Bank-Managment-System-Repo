using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsTransactionsBusiness
    {
        public static bool Deposit(TransactionDTO DTO)
        {
            return clsTransactionDataAccess.Deposit(DTO);
        }

        public static bool WithDraw(TransactionDTO DTO)
        {
            return clsTransactionDataAccess.Withdraw(DTO);
        }
  
        public async static Task<(DataTable,int)> GetTransfersPaged(short pageNumber, short pageSize)
        {
            return await clsTransactionDataAccess.GetTransfersPaged(pageNumber, pageSize);
        }

        public static int TotalTransactionsPerDay(DateTime Date)
        {
            return clsTransactionDataAccess.TotalTransactionsPerDay(Date);
        }

        public static bool Transfer(TransferDTO DTO)
        {
            return clsTransactionDataAccess.TransferBetweenAccounts(DTO);
        }

        public static DataTable GetAllBanks()
        {
            return clsTransactionDataAccess.GetAllBanks();
        }

    }
}
