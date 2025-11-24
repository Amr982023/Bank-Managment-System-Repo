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

namespace MyBankSystemManagmentProject
{
    public partial class ctrTransfer : UserControl
    {
        public ctrTransfer()
        {
            InitializeComponent();
        }

        public event Action OnClose;

        void Back()
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            if (clsGlobal.History.Count > 1)
            {
                clsGlobal.History.Pop();
            }
            this.Dispose();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //OnClose?.Invoke();
            Back();
        }

        void Internal_Transfer ()
        {
            string Destination_AccountNumber = txt_Destination_AccountNumber.Text;
            string Source_AccountNumber = txt_Source_Accountnumber.Text;
            decimal Amount = Convert.ToDecimal(txt_Amount.Text);
            clsAccounts Destination_Account = clsAccounts.GetAccountByAccountNumber(Destination_AccountNumber);

            clsAccounts Source_Account = clsAccounts.GetAccountByAccountNumber(Source_AccountNumber);

            if (Destination_Account == null || Source_Account == null)
            {

                if (Destination_Account == null)
                {
                    MessageBox.Show("Invalid Destination Account Number !", "Invalid !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (Source_Account == null)
                {
                    MessageBox.Show("Invalid Source Account Number !", "Invalid !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {

                if (Amount > Source_Account.Balance)
                {
                    if (MessageBox.Show($"Can't Do this Operation , Because Amount : {Amount} is More Than the Account Balance : {Source_Account.Balance}", "Failed !", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        OnClose?.Invoke();
                        Back();
                    }
                }

                TransferDTO TransferDTO = new TransferDTO();
                TransferDTO.SourceAccountNumber = Source_AccountNumber;
                TransferDTO.DestinationAccountNumber = Destination_AccountNumber;
                TransferDTO.Amount = Amount;
                TransferDTO.CreatedByUserId = clsGlobal.CurrentUser.ID;
                TransferDTO.DestinationBankID = 26;//MyBank

                if (clsTransactionsBusiness.Transfer(TransferDTO))
                {
                    if (MessageBox.Show($"{Amount} have been Transfered From Account with Account number : {Source_AccountNumber} to Account With Account Number : {Destination_AccountNumber} Successfully.\n The Current Balance of Destination Account is : {Destination_Account.Balance + Amount} and The Current Balance of Source Account is : {Source_Account.Balance - Amount} ", "Transfered Successfully", MessageBoxButtons.OK) == DialogResult.OK)
                    {

                        if (MessageBox.Show("Do You Want To Make Another Transfer Operation ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txt_Source_Accountnumber.Clear();
                            txt_Destination_AccountNumber.Clear();
                            txt_Amount.Clear();
                            cb_Banks.SelectedIndex = 0;
                            
                        }
                        else
                        {
                            OnClose?.Invoke();
                            Back();
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Operation is Failed !", "Failed !", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        OnClose?.Invoke();
                        Back();
                    }
                }
            }
        }

        void External_Transfer()
        {
            string Source_AccountNumber = txt_SourceAccountNumberExternal.Text;
            decimal Amount = Convert.ToDecimal(txt_AmountExternal.Text);
            
           
            clsAccounts Source_Account = clsAccounts.GetAccountByAccountNumber(Source_AccountNumber);

            if ( Source_Account == null)
            {

                if (Source_Account == null)
                {
                    MessageBox.Show("Invalid Source Account Number !", "Invalid !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                if (Amount > Source_Account.Balance)
                {
                    if (MessageBox.Show($"Can't Do this Operation , Because Amount : {Amount} is More Than the Account Balance : {Source_Account.Balance}", "Failed !", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        OnClose?.Invoke();
                        Back();
                    }
                }

                BeneficiaryDTO beneficiaryDTO = new BeneficiaryDTO();
                beneficiaryDTO.AccountNumber = txt_DestinationAccountNumberExternal.Text;     
                beneficiaryDTO.IBAN = txt_IBAN.Text;
                beneficiaryDTO.NationalID = txt_BeneficiaryNationalID.Text;
                beneficiaryDTO.FirstName = txt_FirstName.Text;
                beneficiaryDTO.LastName = txt_LastName.Text;
                beneficiaryDTO.BankID = Convert.ToInt32(cb_Banks.SelectedValue);
                beneficiaryDTO.ClientID = Source_Account.ClientID;
                Source_Account.Balance -= Amount;




                if (Source_Account.Save() && clsBeneficiaries.AddNewBeneficiary(beneficiaryDTO))
                {
                    if (MessageBox.Show($"{Amount} have been Transfered From Account with Account number : {Source_AccountNumber} to Account With Account Number : {txt_DestinationAccountNumberExternal} Successfully.\n The Current Balance of Source Account is : {Source_Account.Balance} ", "Transfered Successfully", MessageBoxButtons.OK) == DialogResult.OK)
                    {

                        if (MessageBox.Show("Do You Want To Make Another Transfer Operation ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txt_SourceAccountNumberExternal.Clear();
                            txt_DestinationAccountNumberExternal.Clear();
                            txt_AmountExternal.Clear();
                            cb_Banks.SelectedIndex = 0;
                            txt_FirstName.Clear();
                            txt_LastName.Clear();
                            txt_BeneficiaryNationalID.Clear();
                            txt_IBAN.Clear();
                        }
                        else
                        {
                            OnClose?.Invoke();
                            Back();
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Operation is Failed !", "Failed !", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        OnClose?.Invoke();
                        Back();
                    }
                }
            }
        }

        private void btn_Transfer_Click_1(object sender, EventArgs e)
        {
            Internal_Transfer();
        }

        void comboBoxHandling()
        {
            cb_Banks.DataSource = clsTransactionsBusiness.GetAllBanks();
            cb_Banks.DisplayMember = "BankName";
            cb_Banks.ValueMember = "ID";
            cb_Banks.SelectedIndex = 0;
        }

        private void ctrTransfer_Load(object sender, EventArgs e)
        {
            comboBoxHandling();     
        }

        private void btn_TransferExternal_Click(object sender, EventArgs e)
        {
            External_Transfer();
        }

        private void btn_Back2_Click(object sender, EventArgs e)
        {
            Back();
        }

    }
    

}
