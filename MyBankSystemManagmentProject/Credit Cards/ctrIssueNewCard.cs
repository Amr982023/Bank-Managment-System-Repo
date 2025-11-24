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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace MyBankSystemManagmentProject
{
    public partial class ctrIssueNewCard : UserControl
    {
        public ctrIssueNewCard(int AccountID)
        {
            InitializeComponent();
            _AccountID = AccountID;
            lbl_Issue.Text = $"Issue New Card For Account With Account ID {_AccountID}";
        }

        int _AccountID;
        clsCreditCard _Card= new clsCreditCard();
        public event Action onClose;
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

        private void btn_Issue_Click(object sender, EventArgs e)
        {
            _Card.Card_Network_ID = GetNetworkTypeID();
            _Card.Account_ID = _AccountID;
            _Card.Card_Number = clsGlobal.GenerateRandomNumber(16);
            _Card.Card_Status_ID = 2;
            _Card.Card_Type_ID = GetCardTypeID();
            _Card.Password = Txt_CreditPassword_AddClient.Text;

            if(_Card.Save())
            {
                MessageBox.Show("New Card Has Issued Successfully", "Issued");
                onClose?.Invoke();
                Back();
            }
            else
            {
                MessageBox.Show("Failed To Issue New Card", "Issued");
                onClose?.Invoke();
                Back();
            }
        }

        void Back()
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            clsGlobal.History.Pop();
            this.Dispose();
        }

        private void btn_Back_AddNewClient_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            clsGlobal.LoadMainPage();
            this.Dispose();
        }

    }
}
