using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;

namespace Business_Layer
{
    public class AccountService
    {
        public static (bool Success, string Message) CreateAccountWithCreditCard(AccountCreationDTO dto)
        {
            var client = clsClient.FindByNationalID(dto.NationalId);
            if (client == null)
                return (false, "This National ID is not linked with any client.");

            if (clsAccounts.CheckForSameAccountType(client.ID, dto.AccountTypeId))
                return (false, "This client already has the same account type.");

            var account = new clsAccounts
            {
                Balance = dto.Balance,
                AccountNumber = dto.AccountNumber,
                AccountTypeID = dto.AccountTypeId,
                ClientID = client.ID,
                CurrencyID = dto.CurrencyId
            };

            if (!account.Save())
                return (false, "Account failed to be added.");

            var creditCard = new clsCreditCard
            {
                Card_Network_ID = dto.CardNetworkId,
                Card_Type_ID = dto.CardTypeId,
                Card_Number = dto.CardNumber,
                Password = dto.CardPassword,
                Expiration_Date = DateTime.Now.AddYears(3),
                Account_ID = account.ID
            };

            if (!creditCard.Save())
            {
                clsAccounts.DeleteAccount(account.ID);
                return (false, "Credit card failed to be added.");
            }

            return (true, $"Account [{account.AccountNumber}] added successfully.");
        }
    }
}
