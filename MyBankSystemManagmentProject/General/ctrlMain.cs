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
    public partial class ctrlMain : UserControl
    {
        public ctrlMain()
        {
            InitializeComponent();
        }

        decimal TotalBalances = 0;
        double TotalClients = 0;
        decimal AverageBalances = 0;
        double TodayTransactions = 0;

       public void RefreshPage()
        {
            TotalBalances = clsClient.TotalBalances();
            TotalClients = clsClient.TotalClientsNumber();
            AverageBalances = clsClient.AverageBalances();
            TodayTransactions = clsTransactionsBusiness.TotalTransactionsPerDay(DateTime.Today);

            lbl_TotalBalances.Text = TotalBalances.ToString() + " $";
            lbl_TotalClients.Text = TotalClients.ToString();
            lbl_TodayTransactions.Text = TodayTransactions.ToString();
            lbl_AverageBalances.Text = AverageBalances.ToString() + " $";
        }

        private void ctrlMain_Load(object sender, EventArgs e)
        {
            TimerClock.Start();
            RefreshPage();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("dd MMMM yyyy - hh:mm tt");
        }

    }
}
