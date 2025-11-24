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
using Common.DTOS;
using Mapster.Utils;

namespace MyBankSystemManagmentProject
{
    public partial class ctrAddNewAccount : UserControl
    {
        public ctrAddNewAccount()
        {
            InitializeComponent();
        }

        clsAccounts Account = new clsAccounts();
        clsCreditCard CreditCard = new clsCreditCard();

        int GetCardTypeID()
        {
            switch (cb_CreditCardType.SelectedItem.ToString())
            {
                case "Debit Card": return 1;
                case "Credit Card": return 2;
                case "Prepaid Card": return 3;
                case "Charge Card": return 4;
                default: return 0;
            }
        }

        int GetNetworkTypeID()
        {
            switch (cb_CreditCardNetwork.SelectedItem.ToString())
            {
                case "Visa": return 1;
                case "MasterCard": return 2;
                case "American Express": return 3;
                case "Discover": return 4;
                case "UnionPay": return 5;
                default: return 0;
            }
        }

        int GetAccountTypeID()
        {
            switch (cb_AccountType.SelectedItem.ToString())
            {
                case "Current": return 1;
                case "Saving": return 2;
                case "Fixed": return 3;
                case "Deposit": return 4;
                case "Salary": return 5;
                case "Joint": return 6;
                case "Student": return 7;
                default: return 0;
            }
        }

        void CurrencyHandle()
        {
            //Currency Handling
            DataTable dt = clsCurrency.GetAllCurrencies();

            //placeholder
            DataRow dr = dt.NewRow();
            dr["ID"] = 0;
            dr["Code"] = "Currency";
            dr["Name"] = "SelectCurrency";
            dt.Rows.InsertAt(dr, 0);
            cb_Currency.DataSource = dt;
            cb_Currency.DisplayMember = "Code";
            cb_Currency.ValueMember = "ID";
            cb_Currency.SelectedIndex = 0;
        }

        void HandleComboBoxes()
        {
            CurrencyHandle();       
            cb_CreditCardNetwork.SelectedIndex = 0;
            cb_CreditCardType.SelectedIndex = 0;
            cb_AccountType.SelectedIndex = 0;
        }
    
        private void ctrAddNewAccount_Load(object sender, EventArgs e)
        {
            HandleComboBoxes();
        }

        void Back()
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            clsGlobal.History.Pop();
            this.Dispose();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            clsGlobal.LoadMainPage();
            this.Dispose();
        }

        private void btn_AddNewAccount_Click(object sender, EventArgs e)
        {
            var dto = new AccountCreationDTO
            {
                NationalId = txt_AddAccount_NationalID.Text,
                AccountNumber = txt_AddAccount_AccountNumber.Text,
                Balance = Convert.ToDecimal(txt_Balance_AddAccount.Text),
                AccountTypeId = GetAccountTypeID(),
                CurrencyId = Convert.ToInt32(cb_Currency.SelectedValue),
                CardTypeId = GetCardTypeID(),
                CardNetworkId = GetNetworkTypeID(),
                CardPassword = Txt_CreditPassword_AddAccount.Text.Trim(),
                CardNumber = clsGlobal.GenerateRandomNumber(16)
            };

            var result = AccountService.CreateAccountWithCreditCard(dto);

            MessageBox.Show(result.Message, result.Success ? "Success" : "Error");

            if (result.Success)
                Back();

        }

        private void txt_AddAccount_NationalID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AddAccount_NationalID.Text))
            {
                errorProvider1.SetError(txt_AddAccount_NationalID, "This field is required.");
                e.Cancel = true;
            }
            else if (!clsValidation.ValidateInteger(txt_AddAccount_NationalID.Text))
            {
                errorProvider1.SetError(txt_AddAccount_NationalID, "This is not valid Format, Please Enter Numbers only.");
                e.Cancel = true;
            }
            else if (txt_AddAccount_NationalID.Text.Length != 14)
            {
                errorProvider1.SetError(txt_AddAccount_NationalID, "The National ID Should Contain 14 Digit.");
                e.Cancel = true;
            }
            else if (!clsClient.IsExist(txt_AddAccount_NationalID.Text))
            {
                errorProvider1.SetError(txt_AddAccount_NationalID, "There is no client with this National ID.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_AddAccount_NationalID, "");
                e.Cancel = false;
            }
        }

        private void txt_AddAccount_AccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AddAccount_AccountNumber.Text))
            {
                errorProvider1.SetError(txt_AddAccount_AccountNumber, "This field is required.");
                e.Cancel = true;
            }
            else if (clsAccounts.IsAccountExist(txt_AddAccount_AccountNumber.Text))
            {
                errorProvider1.SetError(txt_AddAccount_AccountNumber, "This Account Number is Taken Before.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_AddAccount_AccountNumber, "");
                e.Cancel = false;
            }
        }

        private void txt_Balance_AddAccount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Balance_AddAccount.Text))
            {
                errorProvider1.SetError(txt_Balance_AddAccount, "This field is required.");
                e.Cancel = true;
            }
            else if (!clsValidation.IsNumber(txt_Balance_AddAccount.Text))
            {
                errorProvider1.SetError(txt_Balance_AddAccount, "This field Should Contains only numbers.");
                e.Cancel = true;
            }
            else if (Convert.ToDecimal(txt_Balance_AddAccount.Text) < 500)
            {
                errorProvider1.SetError(txt_Balance_AddAccount, "Balance Should be equal or greater than 500.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_Balance_AddAccount, "");
                e.Cancel = false;
            }
        }

        private void Txt_CreditPassword_AddAccount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_CreditPassword_AddAccount.Text))
            {
                errorProvider1.SetError(Txt_CreditPassword_AddAccount, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(Txt_CreditPassword_AddAccount, "");
                e.Cancel = false;
            }
        }

        private void cb_AccountType_Validating(object sender, CancelEventArgs e)
        {
            if (cb_AccountType.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cb_AccountType, "Please Choose Account Type");
            }
            else
            {
                errorProvider1.SetError(cb_AccountType, "");
                e.Cancel = false;
            }
        }

        private void cb_CreditCardType_Validating(object sender, CancelEventArgs e)
        {
            if (cb_CreditCardType.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cb_CreditCardType, "Please Choose Credit Card Type");
            }
            else
            {
                errorProvider1.SetError(cb_CreditCardType, "");
            }
        }

        private void cb_CreditCardNetwork_Validating(object sender, CancelEventArgs e)
        {
            if (cb_CreditCardNetwork.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cb_CreditCardNetwork, "Please Choose Credit Card Network");
            }
            else
            {
                errorProvider1.SetError(cb_CreditCardNetwork, "");
            }
        }

        private void cb_Currency_Validating(object sender, CancelEventArgs e)
        {
            if (cb_Currency.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cb_Currency, "Please Choose Currency");
            }
            else
            {
                errorProvider1.SetError(cb_Currency, "");
                e.Cancel = false;
            }
        }

    }
}
