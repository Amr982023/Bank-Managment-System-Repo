using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;

namespace Business_Layer
{
    public class clsTransactionService
    {
        public static (bool Success, string Message, decimal NewBalance) Deposit(TransactionDTO dto)
        {
            var account = clsAccounts.GetAccountByAccountNumber(dto.AccountNumber);
            if (account == null)
                return (false, "Invalid Account Number.", 0);

            dto.Description = $"Deposit {dto.Amount} to Account Number: {dto.AccountNumber}";

            if (!clsTransactionsBusiness.Deposit(dto))
                return (false, "Deposit operation failed.", account.Balance);

            return (true, $"Deposited {dto.Amount} successfully.", account.Balance + dto.Amount);
        }

        public static (bool Success, string Message, decimal NewBalance) Withdraw(TransactionDTO dto)
        {
            var account = clsAccounts.GetAccountByAccountNumber(dto.AccountNumber);
            if (account == null)
                return (false, "Invalid Account Number.", 0);

            if (dto.Amount > account.Balance)
                return (false, $"Insufficient balance. Current: {account.Balance}, Requested: {dto.Amount}", account.Balance);

            dto.Description = $"Withdraw {dto.Amount} from Account Number: {dto.AccountNumber}";

            if (!clsTransactionsBusiness.WithDraw(dto))
                return (false, "Withdraw operation failed.", account.Balance);

            return (true, $"Withdrawn {dto.Amount} successfully.", account.Balance - dto.Amount);
        }

    }
}
