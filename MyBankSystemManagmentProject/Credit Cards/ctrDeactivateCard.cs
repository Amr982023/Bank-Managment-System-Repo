using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace MyBankSystemManagmentProject
{
    public partial class ctrDeactivateCard : UserControl
    {
        public ctrDeactivateCard(int AccountID)
        {
            InitializeComponent();
            lbl_Deactivate.Text = $"Deactivate Card With Account ID : {AccountID}";
            _AccountID = AccountID ;
        }

        int _AccountID = -1;

        clsCreditCard _Card = null;

        public event Action onClose ;

        int GetCardStatusID()
        {
            switch (cb_CardStatus.SelectedItem.ToString())
            {
                case "Frozen": return 3;
                case "Lost": return 4;
                case "Cancelled": return 6;
                case "Reissued": return 7;
                default: return 0;
            }
        } 

        private void btn_Deactivate_Click(object sender, EventArgs e)
        {
            int StatusID = GetCardStatusID();
            _Card = clsCreditCard.GetCardByAccountID(_AccountID);

            if (StatusID == 7)
            {
                _Card.Card_Status_ID = StatusID;
                if (_Card.Save())
                {
                    clsCreditCard NewCard = new clsCreditCard();
                    NewCard.Card_Status_ID = 2;
                    NewCard.Card_Number = clsGlobal.GenerateRandomNumber(16);
                    NewCard.Card_Network_ID = _Card.Card_Network_ID;
                    NewCard.Account_ID = _AccountID;
                    NewCard.Card_Type_ID = _Card.Card_Type_ID;
                    NewCard.Password = _Card.Password;

                    if (NewCard.Save())
                    {
                        MessageBox.Show("Card has Reissued Successfully", "Reissued");
                        onClose?.Invoke();
                        Back();
                    }
                    else
                    {
                        MessageBox.Show("Failed To Reissue Card", "Failed!");
                        onClose?.Invoke();
                        Back();
                    }
                }
            }
            else
            {
                _Card.Card_Status_ID = StatusID;
                if (_Card.Save())
                {
                    MessageBox.Show("Card has Deactivated Successfully", "Deactivated");
                    onClose?.Invoke();
                    Back();
                }
                else
                {
                    MessageBox.Show("Failed To Deactivate Card", "Failed");
                    onClose?.Invoke();
                    Back();
                }
            }
        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            clsGlobal.LoadMainPage();
            this.Dispose();
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

        private void ctrDeactivateCard_Load(object sender, EventArgs e)
        {
            cb_CardStatus.SelectedIndex = 0;
        }

    }
}
