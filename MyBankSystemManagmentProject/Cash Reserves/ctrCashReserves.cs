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
    public partial class ctrCashReserves : UserControl
    {
        public ctrCashReserves()
        {
            InitializeComponent();
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

        private void btn_RecordCashReserves_Click(object sender, EventArgs e)
        {
            if (clsCashReserve.RecordCashReserve(clsGlobal.CurrentUser.ID))
            {
                MessageBox.Show("Cash Reserve Recorded Successfully", "Recorded");
            }else
            {
                MessageBox.Show("Failed To Record Cash Reserves", "Failed !");
            }
      
        }

        private void btn_CashReservesList_Click(object sender, EventArgs e)
        {
            ctrShowList showList = new ctrShowList();
            showList.Subscribe(clsCashReserve.GetCashReservesListAsync);
            showList.SetLabel("Cash Reserves List");
            clsGlobal.History.Push(this);
            clsGlobal.Form.LoadPage(showList);
        }

    }
}
