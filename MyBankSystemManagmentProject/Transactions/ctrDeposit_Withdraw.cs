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
using Common.Services;

namespace MyBankSystemManagmentProject
{
    public partial class ctrDeposit_Withdraw : UserControl
    {
        public ctrDeposit_Withdraw()
        {
            InitializeComponent();
        }

        void Back()
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            if (clsGlobal.History.Count > 1)
            {
                clsGlobal.History.Pop();
            }
                
            this.Dispose();
        }

        public enum enMode { Deposit = 1, Withdraw = 2 };

        public event Action OnClose;

        private enMode _Mode;

        public enMode Mode {
            
            set 
            {
                _Mode = value;
            switch(value)
                {
                    case enMode.Deposit:
                        lbl_Main.Text = "Deposit";
                        btn_General.Text = "Deposit";
                        break;
                    case enMode.Withdraw:
                        lbl_Main.Text = "Withdraw";
                        btn_General.Text = "Withdraw";
                        break;
                }            
            }
        }

         void HandleTransaction()
        {
            var dto = new TransactionDTO
            {
                AccountNumber = txt_AccountNumber.Text,
                Amount = Convert.ToDecimal(txt_Amount.Text),
                CreatedByUserID = clsGlobal.CurrentUser.ID
            };

            (bool success, string message, decimal newBalance) result;

            if (_Mode == enMode.Deposit)
                result = clsTransactionService.Deposit(dto);
            else
                result = clsTransactionService.Withdraw(dto);

            MessageBox.Show(result.message, result.success ? "Success" : "Error");

            if (result.success)
            {
                
                    SendMails.SendMessage(
                        clsClient.Find(clsAccounts.GetAccountByAccountNumber(dto.AccountNumber).ClientID).Email,
                        $"Amount {dto.Amount} has been {(_Mode == enMode.Deposit ? "deposited to" : "withdrawn from")} your account. New Balance: {result.newBalance}"
                    );
                

                if (MessageBox.Show($"Do you want to make another {_Mode} operation?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txt_AccountNumber.Clear();
                    txt_Amount.Clear();
                }
                else
                {
                    OnClose?.Invoke();
                    Back();
                }
            }
            else
            {
                OnClose?.Invoke();
                Back();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //OnClose?.Invoke();
            Back();
        }

        private void btn_General_Click(object sender, EventArgs e)
        {
            HandleTransaction();
        }

    }
}
