using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.DTOS;
using Data_Access_Layer;
using Mapster;

namespace Business_Layer
{
    public class clsAccounts
    {

        //Block_Reasons 
        /*Suspicious_Activity = 1, Fraudulent_Transactions = 2, KYC_Documents_Expired = 3,
        Unpaid_Fees = 4, Regulatory_Requirements = 5, Exceeded_Transaction_Limits = 6, Customer_Request = 7,
        Chargeback_Abuse = 8, Blacklist_Match = 9, System_Policy_Violation = 10*/

        /*Account Types
        Current = 1 , Saving = 2, Fixed = 3, Deposit = 4 , Salary = 5 , Joint = 6 , Student= 7 */

        public enum enStatus { Active = 1, Frozen = 2, Blocked = 3 }

        enum enMode { AddNew = 1 , Update = 2}
        enMode _Mode = enMode.AddNew;
        public int ID { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }

        public int StatusID { get; set; }
        public int CurrencyID { get; set; }
        public int AccountTypeID { get; set; }
        public int ClientID { get; set; }

        public DateTime? LastFeeProcessedDate { get; set; }
        public DateTime? LastTransactionDate { get; set; }

        public clsAccounts()
        {
            ID = -1;
            OpenDate = DateTime.Now;
            CloseDate = null;
            LastFeeProcessedDate = null;
            Balance = 0;
            AccountNumber = string.Empty;
            this.LastTransactionDate = null;

            StatusID = 1;
            CurrencyID = -1;
            AccountTypeID = -1;
            ClientID = -1;

            _Mode = enMode.AddNew;
        }

        bool AddNewAccount()
        {
            // Business Rule Example: Balance cannot be less than 200
            if (this.Balance < 500)
                throw new ArgumentException("Balance cannot be less than 500.");

            if(this.CurrencyID <= 0 || this.StatusID <= 0|| this.AccountTypeID <=0 ||this.ClientID <= 0 ||this.AccountNumber == string.Empty)
            {
                throw new Exception("Please fill All Required Fields");
            }

            AccountDTO DTO = this.Adapt<AccountDTO>();
            this.ID = clsAccountsDataAccess.AddNewAccount(DTO);
            return (this.ID != -1);
        }

        public static clsAccounts GetAccountByID(int accountID)
        {
            if (accountID <= 0)
                throw new ArgumentException("Invalid Account ID.");


            AccountDTO DTO = clsAccountsDataAccess.GetAccountByID(accountID);
            if (DTO == null)
                return null;


            clsAccounts Account = DTO.Adapt<clsAccounts>();
            Account._Mode = enMode.Update;
            return Account ;
        }

        public static clsAccounts GetAccountByClientID(int ClientID)
        {
            if (ClientID <= 0)
                throw new ArgumentException("Invalid Client ID.");


            AccountDTO DTO = clsAccountsDataAccess.GetAccountByClientID(ClientID);
            if (DTO == null)
                return null;


            clsAccounts Account = DTO.Adapt<clsAccounts>();
            Account._Mode = enMode.Update;
            return Account;
        }

        public static clsAccounts GetAccountByAccountNumber(string AccountNumber)
        {
            AccountDTO DTO = clsAccountsDataAccess.GetAccountByAccountNumber(AccountNumber);
            if (DTO == null)
                return null;

            clsAccounts Account = DTO.Adapt<clsAccounts>();
            Account._Mode = enMode.Update;

            return Account;
        }

        public async static Task<(DataTable,int)> SearchWithAccountNumber(string AccountNumber, int PageNumber, int PageSize)
        {
            return await clsAccountsDataAccess.SearchWithAccountNumber(AccountNumber, PageNumber, PageSize);
        }

        public async static Task<(DataTable,int)> SearchWithName(string Name, int PageNumber, int PageSize)
        {
            return await clsAccountsDataAccess.SearchWithName(Name, PageNumber, PageSize);
        }

        public static decimal GetTotalBalance()
        {
            return clsAccountsDataAccess.GetTotalBalance();
        }

        bool UpdateAccount()
        {
            AccountDTO DTO = this.Adapt<AccountDTO>();
            if (DTO == null)
                throw new ArgumentNullException(nameof(DTO));

            if (DTO.ID <= 0)
                throw new ArgumentException("Invalid Account ID.");

            return clsAccountsDataAccess.UpdateAccount(DTO);
        }
   
        public static bool IsAccountExist(string accountNumber)
        {
            return clsAccountsDataAccess.IsAccountExist(accountNumber);
        }

        public static async Task<(DataTable,int)> GetAccountsWithPagingAsync(short pageNumber, short pageSize)
        {
            if (pageNumber <= 0 || pageSize <= 0)
                throw new ArgumentException("Page number and size must be positive.");

            return await clsAccountsDataAccess.GetAccountsWithPagingAsync(pageNumber, pageSize);

        }

        static bool _ChangeAccountStatus(int accountId, short statusId)
        {
            return clsAccountsDataAccess.ChangeAccountStatus(accountId, statusId);
        }

        static bool _RecordAccountBlock(int accountId, short reasonId, string notes, int createdBy)
        {
            return clsAccountsDataAccess.RecordAccountBlock(accountId, reasonId, notes, createdBy) != -1;
        }

        public static bool CheckForSameAccountType(int ClientID, int AccountTypeID)
        {
            return clsAccountsDataAccess.CheckForSameAccountType(ClientID, AccountTypeID);
        }

        public static int GetAccountStatusID(int accountId)
        {
            return clsAccountsDataAccess.GetAccountStatusID(accountId);
        }

        public bool Activate(int createdBy)
        {
            int? status = GetAccountStatusID(this.ID);
            if (status == 3)
            {
                return false;
            }
            _AddToAccountActivateHistory(this.ID, createdBy);//Record The Process
            return _ChangeAccountStatus(this.ID, (int)enStatus.Active);
        }

        public static bool DeleteAccount(int accountId)
        {
            return clsAccountsDataAccess.DeleteAccount(accountId);
        }

        public static bool ActivateAccount(int AccountID, int CreatedBy)
        {
            int? status = GetAccountStatusID(AccountID);
            if (status == 3)
            {
                return false;
            }
            _AddToAccountActivateHistory(AccountID, CreatedBy);//Record The Process
            return _ChangeAccountStatus(AccountID, (int)enStatus.Active);
        }

        public bool Freeze(short ReasonID, int CreatedBy)
        {
            int status = GetAccountStatusID(this.ID);
            if (status == 3)
            {
                return false;
            }

            _AddToAccountFreezeHistory(this.ID, ReasonID, CreatedBy);//Record The Process
            return _ChangeAccountStatus(this.ID, (int)enStatus.Frozen);
        }

        public static bool FreezeAccount(int AccountID,short ReasonID,int CreatedBy)
        {
            int? status = GetAccountStatusID(AccountID);
            if (status == 3)
            {
                return false;
            }
            _AddToAccountFreezeHistory(AccountID, ReasonID, CreatedBy);//Record The Process
            return _ChangeAccountStatus(AccountID, (short)enStatus.Frozen);
        }

        public bool Block(short Reason,int UserID,string Notes ="")
        {
            _RecordAccountBlock(this.ID, Reason, Notes, UserID); //Record process
            
            return _ChangeAccountStatus(this.ID, (short)enStatus.Blocked);
        }

        public static bool BlockAccount(int AccountID,short Reason, int UserID, string Notes = "")
        {
            _RecordAccountBlock(AccountID, Reason, Notes, UserID); //Record Process
           
            return _ChangeAccountStatus(AccountID, (short)enStatus.Blocked);
        }

        static void _AddToAccountFreezeHistory(int accountId, short reasonId, int createdBy, string notes = null)
        {
            clsAccountsDataAccess.AddToAccountFreezeHistory(accountId, reasonId, createdBy, notes);
        }

        static void _AddToAccountActivateHistory(int accountId, int createdBy, string notes = null)
        {
            clsAccountsDataAccess.AddToAccountActivateHistory(accountId, createdBy, notes);
        }

        public static decimal GetMonthlyInterest(string AccountNumber, decimal rate = 0.06m )
        {
            return clsAccountsDataAccess.GetMonthlyInterest(AccountNumber, rate);
        }

        public bool Save()
        {
            if (this._Mode == enMode.AddNew)
                return AddNewAccount();
           else
                return UpdateAccount();
        }

    }
}
