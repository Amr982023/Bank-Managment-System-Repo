using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace MyBankSystemManagmentProject
{
    public partial class ctrViewAccount : UserControl
    {
        public ctrViewAccount()
        {
            InitializeComponent();
           
        }

        public string AccountNumber {

            set { FillInformations(value); }

            }
 

        string GetAcountStatus(int ID)
        {
            switch (ID)
            {
                case 1: return "Active";
                case 2: return "Freezed";
                case 3: return "Blocked";
               
                default: return "Unknown";
            }
        }
      
        string GetAccountType(int ID)
        {
            switch (ID)
            {
                case 1: return "Current";
                case 2: return "Saving";
                case 3: return "Fixed"; 
                case 4: return "Deposit";
                case 5: return "Salary";
                case 6: return "Joint";
                case 7: return "Student";
                default: return "UnKnown";
            }
        }

        void FillInformations(string AccountNumber)
        {
            clsAccounts Account = clsAccounts.GetAccountByAccountNumber(AccountNumber);
            clsCurrency Currency = clsCurrency.GetCurrency(Account.CurrencyID);

            lbl_AccountID.Text = Account.ID.ToString();
            lbl_Accountnumber.Text = Account.AccountNumber;
            lbl_AccountStatus.Text = GetAcountStatus(Account.StatusID);
            lbl_Currency.Text = Currency.Name;
            lbl_AccountType.Text = GetAccountType(Account.AccountTypeID);
            lbl_LastTransactionDate.Text = Account.LastTransactionDate.ToString() ?? " ";
            lbl_OpenDate.Text = Account.OpenDate.ToString();
            lbl_CloseDate.Text = Account.CloseDate.ToString() ?? " ";
            lbl_Balance.Text = Account.Balance.ToString();
            lbl_MonthlyInterest.Text = clsAccounts.GetMonthlyInterest(Account.AccountNumber).ToString();
        }

     
    }
}
