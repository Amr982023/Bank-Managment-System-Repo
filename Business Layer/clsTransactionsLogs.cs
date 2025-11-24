using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Layer
{
    public static class clsTransactionsLogs
    {
        public static void Save(int UserID, int TransactionTypeID, string Description, string AccountNumber, decimal Amount)
        {
            clsTransactionLogsDataAccess.SaveTransactionLog(UserID, TransactionTypeID, Description, AccountNumber, Amount);
        }

        public static DataTable GetLastTransactions(string accountNumber)
        {
            return clsTransactionLogsDataAccess.GetLastTransactions(accountNumber);
        }

        public static async Task<(DataTable, int)> GetDepositTransactionsWithPagination(short pageNumber, short pageSize)
        {
            return await clsTransactionLogsDataAccess.GetDepositTransactionsWithPagination(pageNumber, pageSize);
        }

        public static async Task<(DataTable, int)> GetWithdrawTransactionsWithPagination(short pageNumber, short pageSize)
        {
            return await clsTransactionLogsDataAccess.GetWithdrawTransactionsWithPagination(pageNumber, pageSize);
        }

        public static async Task<(DataTable, int)> GetAllWithPagination(short PageNumber, short PageSize)
        {
            return await clsTransactionLogsDataAccess.GetTransactionLogs(PageNumber, PageSize);
        }

    }
}
