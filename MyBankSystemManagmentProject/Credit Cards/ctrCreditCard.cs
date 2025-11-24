using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyBankSystemManagmentProject
{
    public partial class ctrCreditCard : UserControl
    {


        public enum enStatus { Active = 1, PendingActivation = 2, Frozen = 3, Lost = 4, Expired = 5, Cancelled = 6 }
        public enum enType { DebitCard = 1, CreditCard = 2, PrepaidCard = 3, ChargeCard = 4 }

        public enum enNetworkType { Visa = 1, MasterCard = 2, AmericanExpress = 3, Discover = 4, UnionPay = 5 }

        clsAccounts _Account;
        clsCreditCard _card;
        public ctrCreditCard()
        {
            InitializeComponent();
            HandleCreditCard();
            Visibilty_Off(); 
            pb_NotFound.Visible = false;
        }

        void HandleCreditCard()
        {
            lbl_CardType.Parent = pb_Card;
            lbl_CardType.BackColor = Color.Transparent;
            lbl_BankName.Parent = pb_Card;
            lbl_BankName.BackColor = Color.Transparent;
            lbl_ValidThru.Parent = pb_Card;
            lbl_ValidThru.BackColor = Color.Transparent;
            lbl_ExpireDate.Parent = pb_Card;
            lbl_ExpireDate.BackColor = Color.Transparent;
            lbl_CustomerName.Parent = pb_Card;
            lbl_CustomerName.BackColor = Color.Transparent;
            lbl_CardNumber.Parent = pb_Card;
            lbl_CardNumber.BackColor = Color.Transparent;
            pb_Network.Parent = pb_Card;
            pb_Network.BackColor = Color.Transparent;
            pb_Network.BringToFront();
        }

        void Visibilty_Off()
        {
            lbl_CardType.Visible = false;

            lbl_BankName.Visible = false;

            lbl_ValidThru.Visible = false;

            lbl_ExpireDate.Visible = false;

            lbl_CustomerName.Visible = false;

            lbl_CardNumber.Visible = false;

            pb_Network.Visible = false;

            pb_Card.Visible = false;

            pb_Network.Visible = false;

            Panel_Status.Visible = false;

            btn_Activate.Visible = false;

            btn_Deactivate.Visible = false;

            btn_Reissue.Visible = false;

            btn_Renew.Visible = false;
        }

        void Visibilty_On()
        {
            lbl_CardType.Visible = true;

            lbl_BankName.Visible = true;

            lbl_ValidThru.Visible = true;

            lbl_ExpireDate.Visible = true;

            lbl_CustomerName.Visible = true;

            lbl_CardNumber.Visible = true;

            pb_Network.Visible = true;

            pb_Card.Visible = true;

            pb_Network.Visible = true;

            Panel_Status.Visible = true;

            btn_Activate.Visible = true;

            btn_Deactivate.Visible = true;

            btn_Reissue.Visible = true;

            btn_Renew.Visible = true;
        }

        private Image GetNetworkLogo(int networkTypeId)
        {
            switch ((enNetworkType)networkTypeId)
            {
                case enNetworkType.Visa: return Properties.Resources.visaLogo;
                case enNetworkType.MasterCard: return Properties.Resources.MasterCardLogo;
                case enNetworkType.AmericanExpress: return Properties.Resources.american_express_finance_payment_icon;
                case enNetworkType.Discover: return Properties.Resources.discover_icon;
                case enNetworkType.UnionPay: return Properties.Resources.unionpay_icon;
                default: return null;
            }
        }

        private string GetCardTypeName(int typeId)
        {
            switch ((enType)typeId)
            {
                case enType.DebitCard: return "Debit Card";
                case enType.CreditCard: return "Credit Card";
                case enType.PrepaidCard: return "Prepaid Card";
                case enType.ChargeCard: return "Charge Card";
                default: return "Unknown";
            }
        }

        private string GetCardStatusName(int StatusID)
        {
            switch ((enStatus)StatusID)
            {
                case enStatus.Active: return "Active";
                case enStatus.PendingActivation: return "PendingActivation";
                case enStatus.Frozen: return "Frozen";
                case enStatus.Lost: return "Lost";
                case enStatus.Expired: return "Expired";
                case enStatus.Cancelled: return "Cancelled";          
                default: return "Unknown";
            }
        }

        void HandleCardAndStatus(int AccountID, int ClientID)
        {
            _card = clsCreditCard.GetCardByAccountID(AccountID);
            clsClient Client = clsClient.Find(ClientID);

            lbl_CardType.Text = GetCardTypeName(_card.Card_Type_ID);
            lbl_CustomerName.Text = Client.FirstName + " " + Client.SecondName + " " + Client.LastName;
            if (_card.Expiration_Date.HasValue)
                lbl_ExpireDate.Text = _card.Expiration_Date.Value.ToString("MM/yy");
            else
                lbl_ExpireDate.Text = "";

            lbl_CardNumber.Text = string.Join("    ", Enumerable.Range(0, _card.Card_Number.Length / 4).Select(i => _card.Card_Number.Substring(i * 4, 4)));

            pb_Network.Image = GetNetworkLogo(_card.Card_Network_ID);

            HandleStatus(_card.Card_Status_ID);
        }

        void HandleStatus(int StatusID)
        {
            if (StatusID == 1)
            {
                lbl_Status.Text = GetCardStatusName(StatusID);
                lbl_Status.ForeColor = Color.Green;
                btn_Activate.Enabled = false;
                btn_Deactivate.Enabled = true;
                btn_Renew.Enabled = false;
                btn_Reissue.Enabled = false;

            }
            else if (StatusID == 2)
            {
                lbl_Status.Text = GetCardStatusName(StatusID);
                lbl_Status.ForeColor = Color.Yellow;
                btn_Activate.Enabled = true;
                btn_Deactivate.Enabled = false;
                btn_Renew.Enabled = false;
                btn_Reissue.Enabled = false;

            }
            else if (StatusID == 3)
            {
                lbl_Status.Text = GetCardStatusName(StatusID);
                lbl_Status.ForeColor = Color.Blue;
                btn_Activate.Enabled = true;
                btn_Deactivate.Enabled = false;
                btn_Renew.Enabled = false;
                btn_Reissue.Enabled = false;
            }
            else if (StatusID == 4)
            {
                lbl_Status.Text = GetCardStatusName(StatusID);
                lbl_Status.ForeColor = Color.Red;
                btn_Activate.Enabled = false;
                btn_Deactivate.Enabled = false;
                btn_Renew.Enabled = false;
                btn_Reissue.Enabled = true;
            }
            else if (StatusID == 5)
            {
                lbl_Status.Text = GetCardStatusName(StatusID);
                lbl_Status.ForeColor = Color.Red;
                btn_Activate.Enabled = false;
                btn_Deactivate.Enabled = false;
                btn_Renew.Enabled = true;
                btn_Reissue.Enabled = false;
            }
            else if (StatusID == 6)
            {
                lbl_Status.Text = GetCardStatusName(StatusID);
                lbl_Status.ForeColor = Color.Red;
                btn_Activate.Enabled = false;
                btn_Deactivate.Enabled = false;
                btn_Renew.Enabled = false;
                btn_Reissue.Enabled = true;
            }
        
        }

        void RefreshPage()
        {
            _Account = clsAccounts.GetAccountByAccountNumber(txt_Search.Text.Trim());

            if (_Account != null)
            {
                
                pb_NotFound.Visible = false;
                HandleCardAndStatus(_Account.ID, _Account.ClientID);
                Visibilty_On();
            }
            else
            {
               
                pb_NotFound.Visible = true;
                Visibilty_Off();

            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            clsGlobal.LoadMainPage();
            this.Dispose();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            clsGlobal.History.Pop();
            this.Dispose();
        }

        private void btn_Reissue_Click(object sender, EventArgs e)
        {
            clsGlobal.History.Push(this);
            ctrIssueNewCard Issue = new ctrIssueNewCard(_Account.ID);       
            clsGlobal.Form.LoadPage(Issue);
            Issue.onClose += RefreshPage;
        }

        private void btn_Activate_Click(object sender, EventArgs e)
        {
            if (clsCreditCard.Activate_Card(_card.ID))
            {
                MessageBox.Show($"Card With Number : {_card.Card_Number} is Activated Successfully", "Activated");
                RefreshPage();
            }
            else
            {
                MessageBox.Show($"Failed to Activate Card With Number : {_card.Card_Number}", "Failed!");
            }
        }

        private void btn_Renew_Click(object sender, EventArgs e)
        {
            if (_card.Renew())
            {
                MessageBox.Show($"Card With Number : {_card.Card_Number} is Renewed Successfully", "Renewed");
                RefreshPage();
            }
            else
            {
                MessageBox.Show($"Failed to Renew Card With Number : {_card.Card_Number}", "Failed!");
            }
        }

        private void btn_Deactivate_Click(object sender, EventArgs e)
        {
            clsGlobal.History.Push(this);
            ctrDeactivateCard Deactivate = new ctrDeactivateCard(_Account.ID);
            clsGlobal.Form.LoadPage(Deactivate);
            Deactivate.onClose += RefreshPage;

        }

    }
}
