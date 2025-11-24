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
    public partial class ctrAccountStatusChange : UserControl
    {
        public ctrAccountStatusChange(EnMode Mode)
        {
            InitializeComponent();   
            this.Mode = Mode;
        }

        public enum EnMode { Activate = 1 , Freeze = 2 , Block = 3};

        public EnMode Mode { set; get; }

        short GetReasonID()
        {
            switch (cb_Reasons.SelectedItem?.ToString())
            {
                case "Suspicious_Activity": return 1;
                case "Fraudulent_Transactions": return 2;
                case "KYC_Documents_Expired": return 3;
                case "Unpaid_Fees": return 4;
                case "Regulatory_Requirements": return 5;
                case "Exceeded_Transaction_Limits": return 6;
                case "Customer_Request": return 7;
                case "Chargeback_Abuse": return 8;
                case "Blacklist_Match": return 9;
                case "System_Policy_Violation": return 10;
                default: return 0; 
            }
        }

        void Update_ctrl()
        {
            cb_Reasons.Items.Clear();

            switch (Mode)
            {
                case EnMode.Activate:
                    btn_General.Text = "Activate";
                    lbl_General.Text = "Activate Account";
                    cb_Reasons.Visible = false;
                    break;

                case EnMode.Freeze:
                    btn_General.Text = "Freeze";
                    lbl_General.Text = "Freeze Account";
                    cb_Reasons.Visible = true;

                    // default choice
                    cb_Reasons.Items.Add("Reason");

                    cb_Reasons.Items.Add("Suspicious_Activity");        // 1
                    cb_Reasons.Items.Add("KYC_Documents_Expired");      // 3
                    cb_Reasons.Items.Add("Unpaid_Fees");               // 4
                    cb_Reasons.Items.Add("Regulatory_Requirements");  // 5
                    cb_Reasons.Items.Add("Exceeded_Transaction_Limits");// 6
                    cb_Reasons.Items.Add("Customer_Request");          // 7
                    break;

                case EnMode.Block:
                    btn_General.Text = "Block";
                    lbl_General.Text = "Block Account";
                    cb_Reasons.Visible = true;

                    // default choice
                    cb_Reasons.Items.Add("Reason");

                    cb_Reasons.Items.Add("Fraudulent_Transactions");   // 2
                    cb_Reasons.Items.Add("Chargeback_Abuse");          // 8
                    cb_Reasons.Items.Add("Blacklist_Match");           // 9
                    cb_Reasons.Items.Add("System_Policy_Violation");   // 10
                    break;
            }

            // Default index
            if (cb_Reasons.Items.Count > 0)
                cb_Reasons.SelectedIndex = 0;
        }

        private void ctrAccountStatusChange_Load(object sender, EventArgs e)
        {
            Update_ctrl();

        }

        private void btn_General_Click(object sender, EventArgs e)
        {
            clsAccounts Account = clsAccounts.GetAccountByAccountNumber(txt_AccountNumber.Text);
            clsCreditCard Card = clsCreditCard.GetCardByAccountID(Account.ID);
            if (Account == null)
            {
                MessageBox.Show($"There is no Account With this Account Number {txt_AccountNumber.Text}", "Not Found!");
                return;
            }
            else {
                if (Mode == EnMode.Activate)
                {
                    int statusID = clsAccounts.GetAccountStatusID(Account.ID);
                    if (statusID == 3)
                    {
                        MessageBox.Show("Can't Activate A Blocked Account", "Failed!");
                        return;
                    }
                    else
                    {
                        if(Account.Activate(clsGlobal.CurrentUser.ID))
                        {
                            MessageBox.Show("The Account is Activated Successfully", "Activated!");
                        }
                        else
                        {
                            MessageBox.Show("Activation Failed", "Failed!");
                        }
                    }


                }
                else 
                {
                    short ReasonID = GetReasonID();
                    if (ReasonID == 0)
                    {
                        MessageBox.Show("You Should Choose Reason", "Failed");
                        return;
                    }

                    if (Mode == EnMode.Freeze)
                    {


                        if (Account.Freeze(ReasonID, clsGlobal.CurrentUser.ID) && clsCreditCard.Freeze_Card(Card.ID))
                        {
                            MessageBox.Show("Account and linked credit card have been frozen successfully.", "Freezed!");
                        }
                        else
                        {
                            MessageBox.Show("Deactivation Failed", "Failed!");
                        }
                    }
                    else
                    {
                        if(Account.Block(ReasonID, clsGlobal.CurrentUser.ID) && Card.Cancel())
                        {
                            MessageBox.Show("The Account is Blocked Successfully", "Blocked!");
                        }else
                        {
                            MessageBox.Show("Blocking Failed", "Failed!");
                        }
                    }
                }
                
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            clsGlobal.History.Pop();
            this.Dispose();
        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            clsGlobal.LoadMainPage();
            this.Dispose();
        }

    }
}
