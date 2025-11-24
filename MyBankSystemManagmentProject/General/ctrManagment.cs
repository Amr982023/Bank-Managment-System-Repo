using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBankSystemManagmentProject
{
    public partial class ctrManagment : UserControl
    {
        public ctrManagment()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            if (clsGlobal.History.Count > 1)
            {
                clsGlobal.History.Pop();
            }
            this.Dispose();
        }

        private void btn_AccountsGeneral_Click(object sender, EventArgs e)
        {
            clsGlobal.History.Push(this);
            ctrAccounts accounts = new ctrAccounts();
            clsGlobal.Form.LoadPage(accounts);
        }

        private void btn_ClientsGeneral_Click(object sender, EventArgs e)
        {
            clsGlobal.History.Push(this);
            ctrlClientManagment ClientManagment = new ctrlClientManagment();
            clsGlobal.Form.LoadPage(ClientManagment);
        }

        private void btn_CreditCardsGeneral_Click(object sender, EventArgs e)
        {
            clsGlobal.History.Push(this);
            ctrCreditCard CreditCard = new ctrCreditCard();
            clsGlobal.Form.LoadPage(CreditCard);
        }

        private void btn_CashReservesGeneral_Click(object sender, EventArgs e)
        {
            ctrCashReserves cashReserves = new ctrCashReserves();
            clsGlobal.History.Push(this);
            clsGlobal.Form.LoadPage(cashReserves);
        }

    }
}
